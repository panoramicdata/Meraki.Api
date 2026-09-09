<#
.SYNOPSIS
	Reports places where a Meraki.Api model disagrees with a versioned OpenAPI spec in shape rather
	than in membership: wrong return-type shape, and property names that look like misspellings of a
	spec name.

.DESCRIPTION
	Find-MissingModelMembers.ps1 compares names one way (spec to model) and so reports a wrong return
	type as a pile of missing members. This script asks the two questions that separates cannot:

	1. Shape. For each Refit method matched to a spec operation, does the 2xx schema's top-level shape
	   agree with the return type? An {items, meta} wrapper returned into a List<T>, or a bare array
	   returned into a single object, means the call cannot deserialize at all.

	2. Spelling. At each object level walked in parallel, is there a [DataMember] name that is absent
	   from the spec but within a small edit distance of a spec property that is itself unmapped? That
	   is the signature of a typo such as "intiator" for "initiator": the property has never bound.

	Members that are absent from the spec with no near match are not reported. Many are deliberately
	mapped from observed responses the spec omits.

	Build the solution before running this; it reflects over the compiled assembly.

.PARAMETER SpecVersion
	Spec folder under tmp/meraki-api-update, for example v1.74.0.

.EXAMPLE
	pwsh -File .\.github\skills\meraki-api-update\Find-ModelShapeMismatches.ps1 -SpecVersion v1.74.0
#>
[CmdletBinding()]
param(
	[Parameter(Mandatory = $true)]
	[string]$SpecVersion,

	[string]$RepoRoot,

	[string]$Configuration = 'Debug',

	[string]$TargetFramework = 'net10.0',

	[int]$MaxEditDistance = 2,

	[string]$OutCsv
)

Set-StrictMode -Version Latest
$ErrorActionPreference = 'Stop'
$InformationPreference = 'Continue'

if ([string]::IsNullOrWhiteSpace($RepoRoot)) {
	$RepoRoot = [System.IO.Path]::GetFullPath((Join-Path $PSScriptRoot '..\..\..'))
}

$probeDirectory = Join-Path $RepoRoot "Meraki.Api.Test\bin\$Configuration\$TargetFramework"
if (-not (Test-Path -LiteralPath $probeDirectory)) { throw "Build the solution first: '$probeDirectory' does not exist." }
$probeDirectory = (Resolve-Path -LiteralPath $probeDirectory).Path

$specPath = Join-Path $RepoRoot "tmp\meraki-api-update\$SpecVersion\spec3.json"
if (-not (Test-Path -LiteralPath $specPath)) { throw "Spec not found at '$specPath'. Fetch it with Prepare-MerakiApiUpdate.ps1." }

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
	return ([regex]::Replace($value, '\{[^}]*\}', '{}')).TrimEnd('/').ToLowerInvariant()
}

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

function Test-DictionaryType {
	param([Type]$Type)
	return $Type.IsGenericType -and $Type.GetGenericTypeDefinition().Name -in @('Dictionary`2', 'IDictionary`2', 'IReadOnlyDictionary`2', 'SortedDictionary`2')
}

function Test-OpaqueType {
	param([Type]$Type)
	if ($null -eq $Type) { return $true }
	$underlying = [Nullable]::GetUnderlyingType($Type)
	if ($underlying) { $Type = $underlying }
	if ($Type.IsPrimitive -or $Type.IsEnum) { return $true }
	if ($Type.FullName -in @('System.Threading.Tasks.Task', 'System.Void')) { return $true }
	if (Test-DictionaryType -Type $Type) { return $true }
	return $Type.FullName -in @('System.String', 'System.Object', 'System.DateTime', 'System.DateTimeOffset', 'System.TimeSpan', 'System.Decimal', 'System.Guid')
}

$script:memberCache = @{}
function Get-JsonMemberMap {
	param([Parameter(Mandatory = $true)][Type]$Type)
	if ($script:memberCache.ContainsKey($Type.FullName)) { return $script:memberCache[$Type.FullName] }
	$map = [ordered]@{}
	foreach ($property in $Type.GetProperties()) {
		$dataMembers = @($property.GetCustomAttributes([System.Runtime.Serialization.DataMemberAttribute], $true))
		$name = if ($dataMembers.Count -gt 0 -and $dataMembers[0].Name) { $dataMembers[0].Name } else { $property.Name }
		if (-not $map.Contains($name)) { $map[$name] = [PSCustomObject]@{ Type = $property.PropertyType; Property = $property.Name } }
	}
	$script:memberCache[$Type.FullName] = $map
	return $map
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

function Get-SchemaKind {
	param($Schema)
	if ($null -eq $Schema) { return 'none' }
	$keys = $Schema.PSObject.Properties.Name
	if (($keys -contains 'type' -and "$($Schema.type)" -eq 'array') -or ($keys -contains 'items')) { return 'array' }
	if (($keys -contains 'type' -and "$($Schema.type)" -eq 'object') -or ($keys -contains 'properties') -or ($keys -contains 'allOf')) { return 'object' }
	if ($keys -contains 'type') { return "$($Schema.type)" }
	return 'unknown'
}

function Get-EditDistance {
	param([string]$A, [string]$B)
	$a = $A.ToLowerInvariant(); $b = $B.ToLowerInvariant()
	if ($a -eq $b) { return 0 }
	$m = $a.Length; $n = $b.Length
	if ($m -eq 0) { return $n }
	if ($n -eq 0) { return $m }
	$previous = 0..$n
	for ($i = 1; $i -le $m; $i++) {
		$current = New-Object int[] ($n + 1)
		$current[0] = $i
		for ($j = 1; $j -le $n; $j++) {
			$cost = if ($a[$i - 1] -eq $b[$j - 1]) { 0 } else { 1 }
			$current[$j] = [Math]::Min([Math]::Min($previous[$j] + 1, $current[$j - 1] + 1), $previous[$j - 1] + $cost)
		}
		$previous = $current
	}
	return $previous[$n]
}

# ---- Refit endpoints and spec operations -------------------------------------------------------
$endpoints = [System.Collections.Generic.List[object]]::new()
$interfaces = $assembly.GetTypes() | Where-Object { $_.IsInterface -and $_.Namespace -and $_.Namespace.StartsWith('Meraki.Api.Interfaces') }
foreach ($interface in $interfaces) {
	foreach ($method in $interface.GetMethods()) {
		$httpAttributes = @($method.GetCustomAttributes($true) | Where-Object { $_.GetType().FullName -like 'Refit.*' -and ($_.PSObject.Properties.Name -contains 'Path') })
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

# ---- Checks ------------------------------------------------------------------------------------
$script:findings = [System.Collections.Generic.List[object]]::new()
$script:visited = [System.Collections.Generic.HashSet[string]]::new()

function Add-Finding {
	param([string]$Kind, [string]$ClrType, [string]$Detail, [string]$OperationId, [string]$Method, [string]$Suggestion)
	$script:findings.Add([PSCustomObject]@{
			Kind        = $Kind
			ClrType     = $ClrType
			Detail      = $Detail
			Suggestion  = $Suggestion
			OperationId = $OperationId
			Method      = $Method
		})
}

function Find-Typos {
	param($Schema, [Type]$ClrType, [int]$Depth, [string]$OperationId, [string]$Method)

	if ($Depth -gt 8 -or $null -eq $Schema -or $null -eq $ClrType) { return }
	$Schema = Resolve-Schema -Schema $Schema
	$kind = Get-SchemaKind -Schema $Schema

	if ($kind -eq 'array') {
		$element = Get-ElementType -Type $ClrType
		if ($null -eq $element) { $element = $ClrType }
		if ($Schema.PSObject.Properties.Name -contains 'items') { Find-Typos -Schema $Schema.items -ClrType $element -Depth ($Depth + 1) -OperationId $OperationId -Method $Method }
		return
	}
	if ($kind -ne 'object' -or $Schema.PSObject.Properties.Name -notcontains 'properties' -or $null -eq $Schema.properties) { return }

	$underlying = [Nullable]::GetUnderlyingType($ClrType)
	if ($underlying) { $ClrType = $underlying }
	$element = Get-ElementType -Type $ClrType
	if ($element) { $ClrType = $element }
	if (Test-OpaqueType -Type $ClrType) { return }
	if (-not $script:visited.Add("$($ClrType.FullName)|$OperationId")) { return }

	$members = Get-JsonMemberMap -Type $ClrType
	$specNames = @($Schema.properties.PSObject.Properties.Name)
	$unmappedSpecNames = @($specNames | Where-Object { -not $members.Contains($_) })

	foreach ($entry in $members.GetEnumerator()) {
		$clrJsonName = $entry.Key
		if ($specNames -contains $clrJsonName) {
			Find-Typos -Schema $Schema.properties.$clrJsonName -ClrType $entry.Value.Type -Depth ($Depth + 1) -OperationId $OperationId -Method $Method
			continue
		}
		# Absent from the spec. Only interesting if it is a near miss of a spec name nothing else claims.
		foreach ($candidate in $unmappedSpecNames) {
			$distance = Get-EditDistance -A $clrJsonName -B $candidate
			if ($distance -gt 0 -and $distance -le $MaxEditDistance) {
				Add-Finding -Kind 'LikelyTypo' -ClrType $ClrType.Name -Detail "[DataMember(Name = `"$clrJsonName`")] on $($entry.Value.Property)" -Suggestion "spec has `"$candidate`" (edit distance $distance)" -OperationId $OperationId -Method $Method
			}
		}
	}
}

$matched = 0
foreach ($endpoint in $endpoints) {
	$key = "$($endpoint.Verb) $(Get-NormalizedPath -Path $endpoint.Path)"
	if (-not $specOperations.ContainsKey($key)) { continue }
	$matched++
	$operation = $specOperations[$key]
	$operationId = if ($operation.PSObject.Properties.Name -contains 'operationId') { "$($operation.operationId)" } else { $key }
	$methodLabel = "$($endpoint.Interface).$($endpoint.MethodName)"

	if ($operation.PSObject.Properties.Name -notcontains 'responses') { continue }
	$successName = @($operation.responses.PSObject.Properties.Name | Where-Object { $_ -match '^2' }) | Select-Object -First 1
	if (-not $successName) { continue }
	$success = $operation.responses.$successName
	$hasBody = ($success.PSObject.Properties.Name -contains 'content')
	$payloadType = Get-PayloadType -Type $endpoint.ReturnType
	$returnsPayload = -not (Test-OpaqueType -Type $payloadType) -or ($payloadType.FullName -notin @('System.Threading.Tasks.Task', 'System.Void'))

	if (-not $hasBody) {
		if ($payloadType.FullName -notin @('System.Threading.Tasks.Task', 'System.Void') -and $payloadType.Name -notin @('HttpResponseMessage', 'IApiResponse')) {
			Add-Finding -Kind 'BodyExpectedButSpecHasNone' -ClrType $payloadType.Name -Detail "returns $($payloadType.Name) but the spec's $successName has no body" -Suggestion 'consider returning Task' -OperationId $operationId -Method $methodLabel
		}
		continue
	}

	$jsonContent = $success.content.PSObject.Properties | Where-Object { $_.Name -like 'application/json*' } | Select-Object -First 1
	if (-not $jsonContent -or ($jsonContent.Value.PSObject.Properties.Name -notcontains 'schema')) { continue }
	$schema = Resolve-Schema -Schema $jsonContent.Value.schema
	$specKind = Get-SchemaKind -Schema $schema

	if ($payloadType.FullName -in @('System.Threading.Tasks.Task', 'System.Void')) {
		Add-Finding -Kind 'BodyDiscarded' -ClrType '(none)' -Detail "returns Task but the spec's $successName carries a $specKind body" -Suggestion 'consider returning the payload' -OperationId $operationId -Method $methodLabel
		continue
	}

	$clrIsCollection = $null -ne (Get-ElementType -Type $payloadType)
	$clrIsDictionary = Test-DictionaryType -Type $payloadType
	$specKeys = if ($specKind -eq 'object' -and ($schema.PSObject.Properties.Name -contains 'properties') -and $schema.properties) { @($schema.properties.PSObject.Properties.Name) } else { @() }
	$isWrapper = ($specKind -eq 'object') -and ($specKeys -contains 'items')

	if ($specKind -eq 'array' -and -not $clrIsCollection -and -not $clrIsDictionary) {
		Add-Finding -Kind 'ShapeMismatch' -ClrType $payloadType.Name -Detail "spec returns an array, method returns a single $($payloadType.Name)" -Suggestion "List<$($payloadType.Name)>" -OperationId $operationId -Method $methodLabel
	}
	elseif ($specKind -eq 'object' -and $clrIsCollection) {
		$suggestion = if ($isWrapper) { "a wrapper type with Items and Meta" } else { "a single object" }
		$shape = if ($isWrapper) { "an {$($specKeys -join ', ')} wrapper" } else { "an object" }
		Add-Finding -Kind 'ShapeMismatch' -ClrType $payloadType.Name -Detail "spec returns $shape, method returns $($payloadType.Name)" -Suggestion $suggestion -OperationId $operationId -Method $methodLabel
	}
	elseif ($isWrapper -and -not $clrIsCollection) {
		# Object into object: only a mismatch if the CLR type has no 'items' member itself.
		$members = Get-JsonMemberMap -Type $payloadType
		if (-not $members.Contains('items')) {
			Add-Finding -Kind 'ShapeMismatch' -ClrType $payloadType.Name -Detail "spec returns an {$($specKeys -join ', ')} wrapper, $($payloadType.Name) has no 'items' member" -Suggestion "a wrapper type with Items and Meta" -OperationId $operationId -Method $methodLabel
		}
	}

	Find-Typos -Schema $schema -ClrType $payloadType -Depth 0 -OperationId $operationId -Method $methodLabel
}

Write-Information "Endpoints matched to a spec operation: $matched"
$byKind = $script:findings | Group-Object Kind | ForEach-Object { "$($_.Name)=$($_.Count)" }
Write-Information "Findings: $($script:findings.Count) ($($byKind -join ', '))"

$sorted = $script:findings | Sort-Object Kind, ClrType, Method
if ($OutCsv) {
	$sorted | Export-Csv -LiteralPath $OutCsv -NoTypeInformation -Encoding UTF8
	Write-Information "Wrote $OutCsv"
}
return $sorted
