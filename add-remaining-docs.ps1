# Add documentation to remaining extension methods and other members

# List of files with simple class-level fixes
$classDocs = @{
    "Meraki.Api\Extensions\ISwitchDhcpServerPolicyArpInspectionTrustedServersExtenions.cs" = "Extension methods for I Switch Dhcp Server Policy Arp Inspection Trusted Servers"
    "Meraki.Api\Extensions\ISwitchPortsBySwitchExtension.cs" = "Extension methods for I Switch Ports By Switch"
    "Meraki.Api\Extensions\IWirelessDevicesEthernetStatusesExtentions.cs" = "Extension methods for I Wireless Devices Ethernet Statuses"
    "Meraki.Api\Extensions\IWirelessRfProfilesExtentions.cs" = "Extension methods for I Wireless Rf Profiles"
}

foreach ($file in $classDocs.Keys) {
    if (Test-Path $file) {
        $content = Get-Content $file -Raw
        if ($content -notmatch '/// <summary>') {
            $doc = "/// <summary>`r`n/// $($classDocs[$file])`r`n/// </summary>`r`n"
            $content = $content -replace '(namespace .*?;\r?\n)', "`$1`r`n$doc"
            Set-Content -Path $file -Value $content -NoNewline
            Write-Host "Added docs to $file" -ForegroundColor Green
        }
    }
}

Write-Host "`nDone!" -ForegroundColor Cyan
