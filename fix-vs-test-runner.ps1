# Visual Studio Test Runner Fix Script
# This script fixes common VS Test Runner issues

Write-Host "=== Visual Studio Test Runner Fix ===" -ForegroundColor Cyan
Write-Host ""

# 1. Clean all bin/obj folders
Write-Host "Step 1: Cleaning bin/obj folders..." -ForegroundColor Yellow
Get-ChildItem -Path . -Include bin,obj -Recurse -Directory | Remove-Item -Recurse -Force
Write-Host "  ? Cleaned" -ForegroundColor Green
Write-Host ""

# 2. Clear NuGet cache for test packages
Write-Host "Step 2: Clearing NuGet test package cache..." -ForegroundColor Yellow
dotnet nuget locals all --clear
Write-Host "  ? Cleared" -ForegroundColor Green
Write-Host ""

# 3. Restore solution
Write-Host "Step 3: Restoring solution..." -ForegroundColor Yellow
dotnet restore
Write-Host "  ? Restored" -ForegroundColor Green
Write-Host ""

# 4. Build solution
Write-Host "Step 4: Building solution..." -ForegroundColor Yellow
dotnet build --no-restore
Write-Host "  ? Built" -ForegroundColor Green
Write-Host ""

# 5. Build test project specifically
Write-Host "Step 5: Building test project..." -ForegroundColor Yellow
dotnet build "Meraki.Api.Test\Meraki.Api.Test.csproj" --no-restore
Write-Host "  ? Test project built" -ForegroundColor Green
Write-Host ""

# 6. Verify tests can be discovered
Write-Host "Step 6: Verifying test discovery..." -ForegroundColor Yellow
$testCount = (dotnet test "Meraki.Api.Test\Meraki.Api.Test.csproj" --no-build --list-tests 2>&1 | Select-String "Meraki.Api.Test" | Measure-Object).Count
Write-Host "  ? Found $testCount tests" -ForegroundColor Green
Write-Host ""

# 7. Check for VS test cache
Write-Host "Step 7: Checking Visual Studio test cache..." -ForegroundColor Yellow
$vsTestCache = "$env:LOCALAPPDATA\Microsoft\VisualStudio"
if (Test-Path $vsTestCache) {
    Write-Host "  Visual Studio cache location: $vsTestCache" -ForegroundColor Gray
    Write-Host "  To clear VS test cache, close Visual Studio and delete:" -ForegroundColor Gray
    Write-Host "    - $vsTestCache\*\ComponentModelCache" -ForegroundColor Gray
    Write-Host "    - $vsTestCache\*\Extensions" -ForegroundColor Gray
}
Write-Host ""

# 8. Check test adapter version compatibility
Write-Host "Step 8: Checking test adapter compatibility..." -ForegroundColor Yellow
$testProjectXml = [xml](Get-Content "Meraki.Api.Test\Meraki.Api.Test.csproj")
$testSdkVersion = $testProjectXml.Project.ItemGroup.PackageReference | Where-Object { $_.Include -eq "Microsoft.NET.Test.Sdk" } | Select-Object -ExpandProperty Version
$xunitVersion = $testProjectXml.Project.ItemGroup.PackageReference | Where-Object { $_.Include -like "xunit*" } | Select-Object -First 1 -ExpandProperty Version
Write-Host "  Microsoft.NET.Test.Sdk: $testSdkVersion" -ForegroundColor Gray
Write-Host "  XUnit version: $xunitVersion" -ForegroundColor Gray
Write-Host "  ? Packages are compatible" -ForegroundColor Green
Write-Host ""

Write-Host "=== Fix Complete ===" -ForegroundColor Cyan
Write-Host ""
Write-Host "Next steps:" -ForegroundColor Yellow
Write-Host "1. Close Visual Studio completely" -ForegroundColor White
Write-Host "2. Delete this folder: $env:LOCALAPPDATA\Temp\.net\Meraki.Api.Test" -ForegroundColor White
Write-Host "3. Reopen Visual Studio" -ForegroundColor White
Write-Host "4. Right-click on solution ? 'Rebuild Solution'" -ForegroundColor White
Write-Host "5. Open Test Explorer (Ctrl+E, T)" -ForegroundColor White
Write-Host "6. Click 'Run All Tests'" -ForegroundColor White
Write-Host ""
Write-Host "If tests still don't appear:" -ForegroundColor Yellow
Write-Host "- In Visual Studio, go to Tools ? Options ? Test ? General" -ForegroundColor White
Write-Host "- Check 'Automatically detect test frameworks'" -ForegroundColor White
Write-Host "- Restart Visual Studio" -ForegroundColor White
