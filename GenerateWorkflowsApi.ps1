param(
	[string]$NswagVersion = "14.6.3"
)

$ErrorActionPreference = "Stop"

$repositoryRoot = $PSScriptRoot
$generationDirectory = Join-Path ([System.IO.Path]::GetTempPath()) "meraki-workflows-codegen"
$toolDirectory = Join-Path $generationDirectory "tools-$NswagVersion"
$sourceSpecification = Join-Path $generationDirectory "oas.json"
$clientSpecification = Join-Path $generationDirectory "oas-client.json"
$output = Join-Path $repositoryRoot "Meraki.Api\Workflows\Generated\MerakiWorkflowsApi.g.cs"
$specificationUrl = "https://documentation.meraki.com/@api/deki/files/36507/oas.json?revision=1"

New-Item -ItemType Directory -Force -Path $generationDirectory, $toolDirectory | Out-Null

Write-Host "Downloading the Cisco Workflows OpenAPI specification..."
Invoke-WebRequest -Uri $specificationUrl -OutFile $sourceSpecification

$specification = Get-Content $sourceSpecification -Raw | ConvertFrom-Json -AsHashtable
$httpMethods = @("get", "post", "put", "patch", "delete")
$paths = [ordered]@{}

# Cisco publishes organizationId as a server variable. Project it into each operation so one
# MerakiClient instance can be reused across organizations without mutating a shared BaseAddress.
foreach ($pathEntry in $specification.paths.GetEnumerator()) {
	$pathItem = $pathEntry.Value

	foreach ($methodEntry in $pathItem.GetEnumerator()) {
		if ($methodEntry.Key -notin $httpMethods) {
			continue
		}

		$operation = $methodEntry.Value
		$organizationParameter = @{
			name = "organizationId"
			in = "path"
			required = $true
			description = "The Meraki organization ID."
			schema = @{ type = "string" }
		}
		$existingParameters = if ($operation.ContainsKey("parameters") -and $null -ne $operation.parameters) {
			@($operation.parameters)
		} else {
			@()
		}

		$operation.parameters = @($organizationParameter) + $existingParameters
	}

	$paths["/{organizationId}$($pathEntry.Key)"] = $pathItem
}

$specification.paths = $paths
$specification | ConvertTo-Json -Depth 100 | Set-Content -Encoding utf8 $clientSpecification

$nswag = Join-Path $toolDirectory "nswag.exe"
if (-not (Test-Path $nswag)) {
	dotnet tool install NSwag.ConsoleCore --tool-path $toolDirectory --version $NswagVersion
	if ($LASTEXITCODE -ne 0) {
		exit $LASTEXITCODE
	}
}

Write-Host "Generating the typed Workflows client..."
& $nswag openapi2csclient `
	"/Input:$clientSpecification" `
	"/Output:$output" `
	"/Namespace:Meraki.Api.Workflows" `
	"/ClassName:MerakiWorkflowsApiClient" `
	"/OperationGenerationMode:SingleClientFromOperationId" `
	"/GenerateClientInterfaces:true" `
	"/GenerateNullableReferenceTypes:true" `
	"/GenerateOptionalPropertiesAsNullable:true" `
	"/GenerateOptionalParameters:true" `
	"/RequiredPropertiesMustBeDefined:true" `
	"/GenerateJsonMethods:false" `
	"/UseBaseUrl:false" `
	"/InjectHttpClient:true" `
	"/DisposeHttpClient:false" `
	"/WrapResponses:false" `
	"/GenerateExceptionClasses:true" `
	"/ExceptionClass:MerakiWorkflowsApiException" `
	"/NewLineBehavior:CRLF"

if ($LASTEXITCODE -ne 0) {
	exit $LASTEXITCODE
}

# Preserve wire names while repairing two C#/CLS conflicts in Cisco's current specification.
$generated = Get-Content $output -Raw
$generated = $generated.Replace("bool? async", "bool? @async")
$generated = $generated.Replace("(async != null)", "(@async != null)")
$generated = $generated.Replace("ConvertToString(async,", "ConvertToString(@async,")
$generated = $generated.Replace("public partial class WorkflowMetaData", "public partial class WorkflowRuntimeMetadata")
$generated = $generated.Replace("WorkflowMetaData? Wf_metadata", "WorkflowRuntimeMetadata? Wf_metadata")
$generated = $generated.Replace(
	"Task<WorkflowDefinitionGetResponse> DeleteWorkflowByIdAsync",
	"Task<WorkflowDefinitionGetResponse?> DeleteWorkflowByIdAsync")
$generated = $generated.Replace(
	"if (status_ == 204)`r`n                        {`r`n                            string responseText_ = ( response_.Content == null ) ? string.Empty : await ReadAsStringAsync(response_.Content, cancellationToken).ConfigureAwait(false);`r`n                            throw new MerakiWorkflowsApiException(`"No content`", status_, responseText_, headers_, null);`r`n                        }",
	"if (status_ == 204)`r`n                        {`r`n                            return null;`r`n                        }")
$generated = $generated.Replace(
	"//----------------------`r`n`r`n#nullable enable",
	"//----------------------`r`n`r`n// Source: https://documentation.meraki.com/Platform_Management/Workflows/Workflows/API_Usage`r`n// The published server-level organizationId variable is projected into every operation so the`r`n// generated client remains safe to reuse across organizations. WorkflowMetaData is renamed to`r`n// WorkflowRuntimeMetadata because the source also defines WorkflowMetadata, which is not CLS-safe.`r`n`r`n#nullable enable")
$generated = $generated.Replace(
	"#pragma warning disable 3016 // Disable `"CS3016 Arrays as attribute arguments is not CLS-compliant`"",
	"#pragma warning disable 3016 // Disable `"CS3016 Arrays as attribute arguments is not CLS-compliant`"`r`n#pragma warning disable 3001 // The upstream Workflows schema contains unsigned operation parameters.`r`n#pragma warning disable 3003 // The upstream Workflows schema contains unsigned DTO properties.`r`n#pragma warning disable 3005 // Two upstream schemas differ only by the casing of `"Data`".`r`n#pragma warning disable 3008 // Some upstream JSON property names begin with an underscore.")

if (-not $generated.Contains("Task<WorkflowDefinitionGetResponse?> DeleteWorkflowByIdAsync")) {
	throw "Failed to make the workflow deletion result nullable. Cisco's generated contract may have changed."
}

if ($generated.Contains("throw new MerakiWorkflowsApiException(`"No content`"")) {
	throw "Failed to map the documented 204 workflow deletion response to a successful null result."
}

Set-Content -Path $output -Value $generated -Encoding utf8

$operationCount = @(
	foreach ($pathItem in $specification.paths.Values) {
		foreach ($method in $httpMethods) {
			if ($pathItem.ContainsKey($method)) {
				$pathItem[$method]
			}
		}
	}
).Count

Write-Host "Generated $operationCount operations in $output"
