<#
.SYNOPSIS
	Reports response members present in a versioned Meraki OpenAPI spec but absent from the
	Meraki.Api models.

.DESCRIPTION
	Matches every Refit interface method's verb and path template to a spec operation, then walks
	that operation's 2xx JSON response schema in parallel with the C# return type, comparing spec
	property names against [DataMember] names.

	Three classes of legitimate mismatch are excluded, because the spec describes them as ordinary
	properties while the models represent them as open-ended maps or as no payload at all:

	- Dictionary-typed models (HTTP status-code maps, per-camera-model video settings).
	- Methods declared to return the non-generic Task.
	- Purely numeric property names (latency histogram buckets, HTTP status codes).

	The solution must be built before running this, because the report is produced by reflecting
	over the compiled assembly. Dependencies are probed from the test project's output directory,
	which is the only place every transitive dependency sits beside Meraki.Api.dll.

.PARAMETER SpecVersion
	Spec folder under tmp/meraki-api-update, for example v1.74.0. Fetch it first with
	Prepare-MerakiApiUpdate.ps1.

.PARAMETER OutCsv
	Optional path to write the full findings to as CSV.

.EXAMPLE
	pwsh -File .\.github\skills\meraki-api-update\Find-MissingModelMembers.ps1 -SpecVersion v1.74.0 -OutCsv gap.csv
#>
[CmdletBinding()]
param(
	[Parameter(Mandatory = $true)]
	[string]$SpecVersion,

	[string]$RepoRoot,

	[string]$Configuration = 'Debug',

	[string]$TargetFramework = 'net10.0',

	[string]$OutCsv
)

Set-StrictMode -Version Latest
$ErrorActionPreference = 'Stop'
$InformationPreference = 'Continue'

if ([string]::IsNullOrWhiteSpace($RepoRoot)) {
	$RepoRoot = [System.IO.Path]::GetFullPath((Join-Path $PSScriptRoot '..\..\..'))
}

$probeDirectory = Join-Path $RepoRoot "Meraki.Api.Test\bin\$Configuration\$TargetFramework"
if (-not (Test-Path -LiteralPath $probeDirectory)) {
	throw "Build the solution first: '$probeDirectory' does not exist."
}
$probeDirectory = (Resolve-Path -LiteralPath $probeDirectory).Path

$specPath = Join-Path $RepoRoot "tmp\meraki-api-update\$SpecVersion\spec3.json"
if (-not (Test-Path -LiteralPath $specPath)) {
	throw "Spec not found at '$specPath'. Fetch it with Prepare-MerakiApiUpdate.ps1 -Version $SpecVersion."
}

# Meraki.Api.dll alone cannot be reflected over: GetTypes() needs Refit and the logging
# abstractions, which only sit beside the assembly in the test project's output.
$resolveHandler = [System.ResolveEventHandler] {
	param($sender, $eventArgs)
	$simpleName = ($eventArgs.Name -split ',')[0]
	$candidate = Join-Path $probeDirectory "$simpleName.dll"
	if (Test-Path -LiteralPath $candidate) { [System.Reflection.Assembly]::LoadFrom($candidate) } else { $null }
}
[System.AppDomain]::CurrentDomain.add_AssemblyResolve($resolveHandler)
$assembly = [System.Reflection.Assembly]::LoadFrom((Join-Path $probeDirectory 'Meraki.Api.dll'))

function Get-NormalizedPath {
	param([Parameter(Mandatory = $true)][string]$Path)

	$value = $Path
	if (-not $value.StartsWith('/')) { $value = "/$value" }
	# Parameter names differ between the Refit attributes and the spec, so compare structure only.
	return ([regex]::Replace($value, '\{[^}]*\}', '{}')).TrimEnd('/').ToLowerInvariant()
}

# ---- Refit endpoints ---------------------------------------------------------------------------
$endpoints = [System.Collections.Generic.List[object]]::new()
$interfaces = $assembly.GetTypes() |
	Where-Object { $_.IsInterface -and $_.Namespace -and $_.Namespace.StartsWith('Meraki.Api.Interfaces') }
foreach ($interface in $interfaces) {
	foreach ($method in $interface.GetMethods()) {
		$httpAttributes = @(
			$method.GetCustomAttributes($true) |
				Where-Object { $_.GetType().FullName -like 'Refit.*' -and ($_.PSObject.Properties.Name -contains 'Path') }
		)
		if ($httpAttributes.Count -eq 0) { continue }
		$endpoints.Add([PSCustomObject]@{
				Verb       = "$($httpAttributes[0].Method)".ToLowerInvariant()
				Path       = $httpAttributes[0].Path
				ReturnType = $method.ReturnType
				Interface  = $interface.Name
				MethodName = $method.Name
			})
	}
}
Write-Information "Refit endpoints found: $($endpoints.Count)"

# ---- Spec operations ---------------------------------------------------------------------------
$spec = Get-Content -LiteralPath $specPath -Raw | ConvertFrom-Json -Depth 100
$specOperations = @{}
foreach ($pathProperty in $spec.paths.PSObject.Properties) {
	$normalized = Get-NormalizedPath -Path $pathProperty.Name
	foreach ($verbProperty in $pathProperty.Value.PSObject.Properties) {
		$verb = $verbProperty.Name.ToLowerInvariant()
		if ($verb -notin @('get', 'post', 'put', 'delete')) { continue }
		$specOperations["$verb $normalized"] = $verbProperty.Value
	}
}
Write-Information "Spec operations found: $($specOperations.Count)"

# ---- CLR type helpers --------------------------------------------------------------------------
function Get-PayloadType {
	param([Parameter(Mandatory = $true)][Type]$Type)

	$current = $Type
	while ($current.IsGenericType -and $current.GetGenericTypeDefinition().Name -in @('Task`1', 'ValueTask`1', 'ApiResponse`1', 'IApiResponse`1')) {
		$current = $current.GetGenericArguments()[0]
	}
	return $current
}

function Get-ElementType {
	param([Parameter(Mandatory = $true)][Type]$Type)

	if ($Type.IsArray) { return $Type.GetElementType() }
	if ($Type.IsGenericType -and $Type.GetGenericTypeDefinition().Name -in @('List`1', 'IList`1', 'ICollection`1', 'IEnumerable`1', 'IReadOnlyList`1')) {
		return $Type.GetGenericArguments()[0]
	}
	return $null
}

$script:memberCache = @{}
function Get-JsonMemberMap {
	param([Parameter(Mandatory = $true)][Type]$Type)

	if ($script:memberCache.ContainsKey($Type.FullName)) { return $script:memberCache[$Type.FullName] }
	$map = @{}
	foreach ($property in $Type.GetProperties()) {
		$dataMembers = @($property.GetCustomAttributes([System.Runtime.Serialization.DataMemberAttribute], $true))
		$name = if ($dataMembers.Count -gt 0 -and $dataMembers[0].Name) { $dataMembers[0].Name } else { $property.Name }
		if (-not $map.ContainsKey($name)) { $map[$name] = $property.PropertyType }
	}
	$script:memberCache[$Type.FullName] = $map
	return $map
}

function Test-OpaqueType {
	param([Type]$Type)

	if ($null -eq $Type) { return $true }
	$underlying = [Nullable]::GetUnderlyingType($Type)
	if ($underlying) { $Type = $underlying }
	if ($Type.IsPrimitive -or $Type.IsEnum) { return $true }
	if ($Type.FullName -in @('System.Threading.Tasks.Task', 'System.Void')) { return $true }
	if ($Type.IsGenericType -and $Type.GetGenericTypeDefinition().Name -in @('Dictionary`2', 'IDictionary`2', 'IReadOnlyDictionary`2', 'SortedDictionary`2')) { return $true }
	return $Type.FullName -in @('System.String', 'System.Object', 'System.DateTime', 'System.DateTimeOffset', 'System.TimeSpan', 'System.Decimal', 'System.Guid')
}

function Resolve-Schema {
	param($Schema)

	if ($null -eq $Schema) { return $null }
	if ($Schema.PSObject.Properties.Name -notcontains 'allOf') { return $Schema }

	$properties = @{}
	foreach ($subSchema in $Schema.allOf) {
		$resolved = Resolve-Schema -Schema $subSchema
		if ($resolved -and ($resolved.PSObject.Properties.Name -contains 'properties') -and $resolved.properties) {
			foreach ($property in $resolved.properties.PSObject.Properties) { $properties[$property.Name] = $property.Value }
		}
	}
	return [PSCustomObject]@{ type = 'object'; properties = [PSCustomObject]$properties }
}

# ---- Parallel walk -----------------------------------------------------------------------------
$script:findings = [System.Collections.Generic.List[object]]::new()
$script:visited = [System.Collections.Generic.HashSet[string]]::new()

function Compare-Schema {
	param($Schema, [Type]$ClrType, [string]$Breadcrumb, [int]$Depth, [string]$OperationId)

	if ($Depth -gt 8 -or $null -eq $Schema -or $null -eq $ClrType) { return }
	$Schema = Resolve-Schema -Schema $Schema
	if ($null -eq $Schema) { return }

	$schemaKeys = $Schema.PSObject.Properties.Name
	$schemaType = if ($schemaKeys -contains 'type') { "$($Schema.type)" } else { '' }

	if ($schemaType -eq 'array' -or ($schemaKeys -contains 'items')) {
		$elementType = Get-ElementType -Type $ClrType
		if ($null -eq $elementType) { $elementType = $ClrType }
		if ($schemaKeys -contains 'items') {
			Compare-Schema -Schema $Schema.items -ClrType $elementType -Breadcrumb $Breadcrumb -Depth ($Depth + 1) -OperationId $OperationId
		}
		return
	}

	if ($schemaKeys -notcontains 'properties' -or $null -eq $Schema.properties) { return }

	$underlying = [Nullable]::GetUnderlyingType($ClrType)
	if ($underlying) { $ClrType = $underlying }
	$elementType = Get-ElementType -Type $ClrType
	if ($elementType) { $ClrType = $elementType }
	if (Test-OpaqueType -Type $ClrType) { return }

	if (-not $script:visited.Add("$($ClrType.FullName)|$Breadcrumb")) { return }

	$members = Get-JsonMemberMap -Type $ClrType
	foreach ($specProperty in $Schema.properties.PSObject.Properties) {
		$jsonName = $specProperty.Name
		if ($members.ContainsKey($jsonName)) {
			Compare-Schema -Schema $specProperty.Value -ClrType $members[$jsonName] -Breadcrumb "$Breadcrumb.$jsonName" -Depth ($Depth + 1) -OperationId $OperationId
			continue
		}

		$value = $specProperty.Value
		$description = if ($value -and ($value.PSObject.Properties.Name -contains 'description')) { "$($value.description)" } else { '' }
		$jsonType = if ($value -and ($value.PSObject.Properties.Name -contains 'type')) { "$($value.type)" } else { '' }
		$script:findings.Add([PSCustomObject]@{
				ClrType     = $ClrType.Name
				JsonMember  = $jsonName
				JsonType    = $jsonType
				Breadcrumb  = $Breadcrumb
				OperationId = $OperationId
				Description = $description
			})
	}
}

$matchedCount = 0
$unmatched = [System.Collections.Generic.List[string]]::new()
foreach ($endpoint in $endpoints) {
	$key = "$($endpoint.Verb) $(Get-NormalizedPath -Path $endpoint.Path)"
	if (-not $specOperations.ContainsKey($key)) {
		$unmatched.Add("$key ($($endpoint.Interface).$($endpoint.MethodName))")
		continue
	}
	$matchedCount++

	$operation = $specOperations[$key]
	if ($operation.PSObject.Properties.Name -notcontains 'responses') { continue }
	$successName = @($operation.responses.PSObject.Properties.Name | Where-Object { $_ -match '^2' }) | Select-Object -First 1
	if (-not $successName) { continue }
	$success = $operation.responses.$successName
	if ($success.PSObject.Properties.Name -notcontains 'content') { continue }
	$jsonContent = $success.content.PSObject.Properties | Where-Object { $_.Name -like 'application/json*' } | Select-Object -First 1
	if (-not $jsonContent -or ($jsonContent.Value.PSObject.Properties.Name -notcontains 'schema')) { continue }

	$payloadType = Get-PayloadType -Type $endpoint.ReturnType
	$operationId = if ($operation.PSObject.Properties.Name -contains 'operationId') { "$($operation.operationId)" } else { $key }
	Compare-Schema -Schema $jsonContent.Value.schema -ClrType $payloadType -Breadcrumb $payloadType.Name -Depth 0 -OperationId $operationId
}

Write-Information "Endpoints matched to a spec operation: $matchedCount"
Write-Information "Endpoints with no spec match: $($unmatched.Count)"

$notImplemented = @($specOperations.Keys | Where-Object { $key = $_; -not ($endpoints | Where-Object { "$($_.Verb) $(Get-NormalizedPath -Path $_.Path)" -eq $key }) })
Write-Information "Spec operations not implemented: $($notImplemented.Count)"

# Purely numeric names are histogram buckets or HTTP status codes: an open-ended map, not a member.
$realFindings = @($script:findings | Where-Object { $_.JsonMember -notmatch '^\d+(\.\d+)?$' })

$grouped = $realFindings |
	Group-Object { "$($_.ClrType)|$($_.JsonMember)" } |
	ForEach-Object {
		$first = $_.Group[0]
		[PSCustomObject]@{
			ClrType      = $first.ClrType
			JsonMember   = $first.JsonMember
			JsonType     = $first.JsonType
			Hits         = $_.Count
			OperationIds = (($_.Group.OperationId | Sort-Object -Unique) -join '; ')
			Breadcrumb   = $first.Breadcrumb
			Description  = $first.Description
		}
	} |
	Sort-Object ClrType, JsonMember

Write-Information "Unmapped response members: $(@($grouped).Count) across $(@($grouped.ClrType | Sort-Object -Unique).Count) types"

if ($OutCsv) {
	$grouped | Export-Csv -LiteralPath $OutCsv -NoTypeInformation -Encoding UTF8
	Write-Information "Wrote $OutCsv"
}

return $grouped
