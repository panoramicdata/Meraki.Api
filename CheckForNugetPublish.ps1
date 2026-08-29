param (
    [Parameter(Mandatory = $true)]
    [string]$packageName,

    [Parameter(Mandatory = $true)]
    [string]$expectedVersion
)

$InformationPreference = "Continue"

function Get-LatestPackageVersion {
    param (
        [string]$packageName
    )

    $nugetUrl = "https://api.nuget.org/v3-flatcontainer/$packageName/index.json"

    try {
        $response = Invoke-RestMethod -Uri $nugetUrl
        $latestVersion = $response.versions[-1] # Get the last version as it's the latest
        return $latestVersion
    }
    catch {
        Write-Information "An error occurred while fetching the package version: $_"
        return $null
    }
}

while ($true) {
    $latestVersion = Get-LatestPackageVersion -packageName $packageName

    if ($null -eq $latestVersion) {
        Write-Information "Failed to retrieve the package version. Retrying in 5 seconds..."
    }
    elseif ($latestVersion -eq $expectedVersion) {
        Write-Information "The latest version ($latestVersion) matches the expected version ($expectedVersion)."
        break
    }
    else {
        Write-Information "The latest version is $latestVersion. Waiting for version $expectedVersion..."
    }

    Start-Sleep -Seconds 5
}
