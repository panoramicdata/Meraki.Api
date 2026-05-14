[CmdletBinding()]
param(
    [string]$Version,

    [switch]$Latest,

    [string]$OutputRoot,

    [switch]$Force
)

Set-StrictMode -Version Latest
$ErrorActionPreference = 'Stop'

if (-not $Latest -and [string]::IsNullOrWhiteSpace($Version)) {
    throw 'Specify -Version (for example 1.63.0) or use -Latest.'
}

if ($Latest -and -not [string]::IsNullOrWhiteSpace($Version)) {
    throw 'Use either -Version or -Latest, not both.'
}

function Normalize-Version {
    param(
        [Parameter(Mandatory = $true)]
        [string]$Value
    )

    $trimmed = $Value.Trim()
    if ([string]::IsNullOrWhiteSpace($trimmed)) {
        throw 'Version must not be empty.'
    }

    if ($trimmed.StartsWith('v', [System.StringComparison]::OrdinalIgnoreCase)) {
        return 'v' + $trimmed.Substring(1)
    }

    return "v$trimmed"
}

function Get-LatestMerakiApiVersion {
    $apiUrl = 'https://api.github.com/repos/CiscoDevNet/Meraki-Portal-What-s-New-Changelog/contents/changelog'
    $headers = @{ 'User-Agent' = 'Meraki.Api update preparation script' }

    Write-Host "Discovering latest version from $apiUrl"
    $items = Invoke-RestMethod -Method Get -Uri $apiUrl -Headers $headers

    $versionItems = foreach ($item in $items) {
        if ($item.name -match '^v(\d+)\.(\d+)\.(\d+)\.md$') {
            $versionText = "$($Matches[1]).$($Matches[2]).$($Matches[3])"
            [PSCustomObject]@{
                Tag = "v$versionText"
                Version = [Version]$versionText
            }
        }
    }

    if (-not $versionItems) {
        throw 'No semantic versions were found in the Meraki changelog listing.'
    }

    $latest = $versionItems | Sort-Object Version -Descending | Select-Object -First 1
    return $latest.Tag
}

function Download-File {
    param(
        [Parameter(Mandatory = $true)]
        [string]$Uri,

        [Parameter(Mandatory = $true)]
        [string]$Path,

        [switch]$ForceDownload
    )

    if ((-not $ForceDownload) -and (Test-Path -LiteralPath $Path)) {
        Write-Host "Using existing file: $Path"
        return
    }

    Write-Host "Downloading $Uri"
    Invoke-WebRequest -Uri $Uri -OutFile $Path
}

$normalizedVersion = if ($Latest) {
    Get-LatestMerakiApiVersion
}
else {
    Normalize-Version -Value $Version
}
$repoRoot = [System.IO.Path]::GetFullPath((Join-Path $PSScriptRoot '..\..\..'))

if ([string]::IsNullOrWhiteSpace($OutputRoot)) {
    $OutputRoot = Join-Path $repoRoot (Join-Path 'tmp' (Join-Path 'meraki-api-update' $normalizedVersion))
}

$null = New-Item -ItemType Directory -Path $OutputRoot -Force

$changelogUrl = "https://raw.githubusercontent.com/CiscoDevNet/Meraki-Portal-What-s-New-Changelog/master/changelog/$normalizedVersion.md"
$openApiUrl = "https://raw.githubusercontent.com/meraki/openapi/refs/tags/$normalizedVersion/openapi/spec3.json"

$changelogPath = Join-Path $OutputRoot 'changelog.md'
$openApiPath = Join-Path $OutputRoot 'spec3.json'
$metadataPath = Join-Path $OutputRoot 'metadata.json'

Download-File -Uri $changelogUrl -Path $changelogPath -ForceDownload:$Force
Download-File -Uri $openApiUrl -Path $openApiPath -ForceDownload:$Force

$metadata = [ordered]@{
    version = $normalizedVersion
    generatedAtUtc = [DateTime]::UtcNow.ToString('o')
    repoRoot = $repoRoot
    outputRoot = $OutputRoot
    changelog = [ordered]@{
        url = $changelogUrl
        path = $changelogPath
    }
    openApi = [ordered]@{
        url = $openApiUrl
        path = $openApiPath
    }
}

$metadata | ConvertTo-Json -Depth 5 | Set-Content -LiteralPath $metadataPath -Encoding UTF8

Write-Host ''
Write-Host 'Prepared Meraki API update inputs:'
Write-Host "  Version:   $normalizedVersion"
Write-Host "  Changelog: $changelogPath"
Write-Host "  OpenAPI:   $openApiPath"
Write-Host "  Metadata:  $metadataPath"