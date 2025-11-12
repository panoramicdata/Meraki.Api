$files = @(
    @{Path="Meraki.Api\Sections\Products\Appliance\ApplianceTrafficShapingSection.cs"; Name="appliance traffic shaping"},
    @{Path="Meraki.Api\Sections\Products\Appliance\ApplianceVlansSection.cs"; Name="appliance vlans"},
    @{Path="Meraki.Api\Sections\Products\Camera\CameraOnboardingSection.cs"; Name="camera onboarding"},
    @{Path="Meraki.Api\Sections\Products\Camera\CameraSection.cs"; Name="camera"},
    @{Path="Meraki.Api\Sections\Products\Camera\CameraSenseSection.cs"; Name="camera sense"},
    @{Path="Meraki.Api\Sections\Products\Camera\CameraVideoSection.cs"; Name="camera video"},
    @{Path="Meraki.Api\Sections\Products\CellularGateway\CellularGatewayUplinkSection.cs"; Name="cellular gateway uplink"},
    @{Path="Meraki.Api\Sections\General\Organizations\OrganizationBrandingPoliciesSection.cs"; Name="organization branding policies"},
    @{Path="Meraki.Api\Sections\General\Organizations\OrganizationsCertificatesSection.cs"; Name="organizations certificates"},
    @{Path="Meraki.Api\Sections\General\Organizations\OrganizationsConfigTemplates.cs"; Name="organizations config templates"},
    @{Path="Meraki.Api\Sections\General\Organizations\OrganizationsDeviceSection.cs"; Name="organizations device"},
    @{Path="Meraki.Api\Sections\General\Organizations\OrganizationsDevicesSystemSection.cs"; Name="organizations devices system"},
    @{Path="Meraki.Api\Sections\General\Organizations\OrganizationsInsightSection.cs"; Name="organizations insight"},
    @{Path="Meraki.Api\Sections\General\Organizations\OrganizationsSamlSection.cs"; Name="organizations saml"},
    @{Path="Meraki.Api\Sections\General\Organizations\OrganizationsWirelessControllerSection.cs"; Name="organizations wireless controller"},
    @{Path="Meraki.Api\Sections\Products\Sm\SmDevicesSection.cs"; Name="sm devices"},
    @{Path="Meraki.Api\Sections\Products\Sm\SmUsersSection.cs"; Name="sm users"},
    @{Path="Meraki.Api\Sections\Products\Wireless\WirelessSsidsSection.cs"; Name="wireless ssids"}
)

foreach ($file in $files) {
    $path = $file.Path
    if (Test-Path $path) {
        $content = Get-Content $path -Raw
        
        # Check if already has documentation
        if ($content -match 'public (partial )?class \w+Section' -and $content -notmatch '/// <summary>[\s\S]*?/// </summary>[\s\S]*?public (partial )?class') {
            $doc = "/// <summary>`r`n/// Provides access to $($file.Name) API endpoints`r`n/// </summary>`r`n"
            $content = $content -replace '(namespace .*?;\r?\n)', "`$1`r`n$doc"
            Set-Content -Path $path -Value $content -NoNewline
            Write-Host "Added documentation to $($file.Path)" -ForegroundColor Green
        } else {
            Write-Host "Skipped $($file.Path) - already has documentation or pattern not found" -ForegroundColor Yellow
        }
    }
}
