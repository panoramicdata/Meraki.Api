param (
    [Parameter(Mandatory = $true)]
    [string]$packageName,

    [Parameter(Mandatory = $true)]
    [string]$expectedVersion
)

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
        Write-Host "An error occurred while fetching the package version: $_"
        return $null
    }
}

while ($true) {
    $latestVersion = Get-LatestPackageVersion -packageName $packageName

    if ($latestVersion -eq $null) {
        Write-Host "Failed to retrieve the package version. Retrying in 5 seconds..."
    }
    elseif ($latestVersion -eq $expectedVersion) {
        Write-Host "The latest version ($latestVersion) matches the expected version ($expectedVersion)."
        break
    }
    else {
        Write-Host "The latest version is $latestVersion. Waiting for version $expectedVersion..."
    }

    Start-Sleep -Seconds 5
}
