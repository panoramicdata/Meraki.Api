$extensionFiles = Get-ChildItem "Meraki.Api\Extensions" -Filter "*Extensions.cs"

foreach ($file in $extensionFiles) {
    $content = Get-Content $file.FullName -Raw
    
    # Check if already has documentation
    if ($content -match 'public static class (\w+)' -and $content -notmatch '/// <summary>[\s\S]*?/// </summary>[\s\S]*?public static class') {
        $className = $Matches[1]
        $description = $className -replace 'Extensions$', '' -creplace '([a-z])([A-Z])', '$1 $2'
        $doc = "/// <summary>`r`n/// Extension methods for $description`r`n/// </summary>`r`n"
        $content = $content -replace '(namespace .*?;\r?\n)', "`$1`r`n$doc"
        Set-Content -Path $file.FullName -Value $content -NoNewline
        Write-Host "Added documentation to $($file.Name)" -ForegroundColor Green
    } else {
        Write-Host "Skipped $($file.Name)" -ForegroundColor Yellow
    }
}
