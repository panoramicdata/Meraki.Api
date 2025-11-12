# Quick VS Test Runner Fix
# Run this with Visual Studio CLOSED

Write-Host "=== Quick VS Test Runner Fix ===" -ForegroundColor Cyan
Write-Host ""
Write-Host "??  Make sure Visual Studio is CLOSED before running this script!" -ForegroundColor Yellow
Write-Host ""
Read-Host "Press Enter to continue or Ctrl+C to cancel"

# Clean VS test cache
Write-Host "Cleaning Visual Studio test cache..." -ForegroundColor Yellow
$vsPaths = @(
    "$env:LOCALAPPDATA\Microsoft\VisualStudio\*\ComponentModelCache",
    "$env:LOCALAPPDATA\Temp\.net",
    "$env:TEMP\VisualStudioTestExplorerExtensions"
)

foreach ($path in $vsPaths) {
    if (Test-Path $path) {
        Write-Host "  Removing: $path" -ForegroundColor Gray
        Remove-Item $path -Recurse -Force -ErrorAction SilentlyContinue
    }
}
Write-Host "  ? Cache cleaned" -ForegroundColor Green
Write-Host ""

# Clean solution build artifacts
Write-Host "Cleaning solution build artifacts..." -ForegroundColor Yellow
$folders = Get-ChildItem -Path . -Include bin,obj -Recurse -Directory -ErrorAction SilentlyContinue
$folderCount = ($folders | Measure-Object).Count
Write-Host "  Found $folderCount bin/obj folders to clean" -ForegroundColor Gray
$folders | Remove-Item -Recurse -Force -ErrorAction SilentlyContinue
Write-Host "  ? Build artifacts cleaned" -ForegroundColor Green
Write-Host ""

Write-Host "=== Done! ===" -ForegroundColor Cyan
Write-Host ""
Write-Host "Now do the following:" -ForegroundColor Yellow
Write-Host "1. Open Visual Studio" -ForegroundColor White
Write-Host "2. Open Meraki.Api.sln" -ForegroundColor White
Write-Host "3. Right-click solution ? 'Clean Solution'" -ForegroundColor White
Write-Host "4. Right-click solution ? 'Rebuild Solution'" -ForegroundColor White
Write-Host "5. Open Test Explorer (Test ? Test Explorer or Ctrl+E, T)" -ForegroundColor White
Write-Host "6. Click the refresh button in Test Explorer" -ForegroundColor White
Write-Host "7. Tests should now appear!" -ForegroundColor White
Write-Host ""
Write-Host "If tests still don't show:" -ForegroundColor Yellow
Write-Host "- Check Tools ? Options ? Test" -ForegroundColor White
Write-Host "- Enable 'Automatically detect test frameworks'" -ForegroundColor White
Write-Host "- Disable then re-enable 'Discover tests in real time from source files'" -ForegroundColor White
