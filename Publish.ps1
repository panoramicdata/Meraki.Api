# Panoramic Data NuGet Publish Script (Standard)
# Tags the current commit with the NBGV version and pushes to trigger CI/CD publishing.
# Usage: .\Publish.ps1

$ErrorActionPreference = 'Stop'

# Check for clean working tree (porcelain)
$status = git status --porcelain
if ($status) {
    Write-Error "Working tree is not clean. Commit or stash changes before publishing.`n$status"
    exit 1
}

# Ensure we are on the main branch
$branch = git rev-parse --abbrev-ref HEAD
if ($branch -ne 'main') {
    Write-Error "Publishing is only supported from the 'main' branch (currently on '$branch')."
    exit 1
}

# Ensure local main is up to date with remote
git fetch origin main --quiet
$localHead = git rev-parse HEAD
$remoteHead = git rev-parse origin/main
if ($localHead -ne $remoteHead) {
    Write-Error "Local branch is not up to date with origin/main. Pull or push first."
    exit 1
}

# Get version from NBGV
$versionJson = nbgv get-version -f json | ConvertFrom-Json
$version = $versionJson.SimpleVersion

if (-not $version) {
    Write-Error "Failed to determine version from nbgv."
    exit 1
}

# Check tag doesn't already exist
$existingTag = git tag -l $version
if ($existingTag) {
    Write-Error "Tag '$version' already exists."
    exit 1
}

Write-Host "Tagging as $version ..." -ForegroundColor Cyan
git tag $version
git push origin $version

Write-Host "✅ Published tag $version — CI will build and push to NuGet." -ForegroundColor Green
