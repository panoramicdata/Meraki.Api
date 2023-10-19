$ErrorActionPreference = "Stop"

# This script will tag the current commit and push it to the origin

# Note: If nbgv does not work then install it using either of the following
#dotnet tool install -g nbgv
#dotnet tool update -g nbgv

# Make sure to get latest changes on the branch to ensure we're at the correct git height
git pull

if (git status --porcelain) {
	Write-Error "Git repo is not clean. Make sure any changes have been committed."
	exit 1;
}

$nbgvVersion = nbgv get-version -v Version
$versionParts = $nbgvVersion.Split(".")
$versionString = $versionParts[0] + "." + $versionParts[1] + "." + $versionParts[2];
Write-Information("Tagging as " + $versionString);

git tag -a "$versionString" -m "Tagged version ${versionString}"

Write-Information("Pushing tag...");
git push origin $versionString

& CheckForNugetPublish.ps1 -packageName "Meraki.Api" -expectedVersion $versionString
