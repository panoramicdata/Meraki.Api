# Visual Studio Test Runner Troubleshooting Guide

## Problem
Visual Studio Test Explorer is not discovering or running tests after .NET 10 upgrade.

## Root Cause
After upgrading to .NET 10, Visual Studio's test discovery cache can become stale and needs to be cleared.

## Solution

### Quick Fix (With VS Closed)
1. **Close Visual Studio completely**
2. Run: `.\quick-fix-vs-tests.ps1`
3. Open Visual Studio
4. Clean and Rebuild solution
5. Open Test Explorer (Ctrl+E, T)

### Manual Fix (If Script Doesn't Work)

#### Step 1: Close Visual Studio
Make sure Visual Studio is completely closed.

#### Step 2: Clear Caches
Delete these folders:
```
%LOCALAPPDATA%\Microsoft\VisualStudio\*\ComponentModelCache
%LOCALAPPDATA%\Temp\.net
%TEMP%\VisualStudioTestExplorerExtensions
```

#### Step 3: Clean Project
```powershell
# In PowerShell
Get-ChildItem -Path . -Include bin,obj -Recurse -Directory | Remove-Item -Recurse -Force
```

#### Step 4: Rebuild in VS
1. Open Visual Studio
2. Open `Meraki.Api.sln`
3. Right-click solution ? **Clean Solution**
4. Right-click solution ? **Rebuild Solution**
5. Wait for build to complete

#### Step 5: Configure Test Explorer
1. Go to **Tools ? Options ? Test**
2. Enable: **Automatically detect test frameworks**
3. Enable: **Discover tests in real time from source files**
4. Enable: **Keep test execution engine running**
5. Click **OK**

#### Step 6: Restart VS
Close and reopen Visual Studio

#### Step 7: Open Test Explorer
1. **Test ? Test Explorer** (or press Ctrl+E, T)
2. Click the refresh button (?) in Test Explorer toolbar
3. Wait for test discovery to complete

## Verification

### Check Test Project Builds
```powershell
dotnet build Meraki.Api.Test\Meraki.Api.Test.csproj
```
Should succeed with output showing:
```
Build succeeded with 1 warning(s)
? Meraki.Api.Test\bin\Debug\net10.0\Meraki.Api.Test.dll
```

### Check Test Discovery
```powershell
dotnet test Meraki.Api.Test\Meraki.Api.Test.csproj --list-tests
```
Should list all available tests.

### Check .NET SDK
```powershell
dotnet --list-sdks
```
Should show 10.0.100 or higher.

## Common Issues

### Issue 1: "No tests discovered"
**Symptoms:** Test Explorer shows "No tests found"

**Solutions:**
1. Ensure test project builds successfully
2. Check that test methods have `[Fact]` or `[Theory]` attributes
3. Verify xUnit packages are correct version:
   - `xunit.v3` version 3.2.0
   - `xunit.runner.visualstudio` version 3.1.5
   - `Microsoft.NET.Test.Sdk` version 18.0.1

### Issue 2: "Test adapter not found"
**Symptoms:** Error about missing test adapter

**Solutions:**
1. Clean NuGet cache: `dotnet nuget locals all --clear`
2. Restore packages: `dotnet restore`
3. Rebuild solution in Visual Studio

### Issue 3: Tests show but won't run
**Symptoms:** Tests appear in Test Explorer but fail immediately

**Solutions:**
1. Check target framework matches installed SDK
2. Verify no runtime errors in test project
3. Run tests from command line to see detailed errors:
   ```powershell
   dotnet test Meraki.Api.Test\Meraki.Api.Test.csproj
   ```

### Issue 4: Visual Studio hangs during test discovery
**Symptoms:** VS becomes unresponsive when opening Test Explorer

**Solutions:**
1. Disable real-time discovery temporarily:
   - Tools ? Options ? Test
   - Uncheck "Discover tests in real time from source files"
2. Use manual discovery: Click refresh button after changes

## Test Project Configuration

Current configuration in `Meraki.Api.Test.csproj`:
```xml
<PropertyGroup>
  <TargetFramework>net10.0</TargetFramework>
  <IsTestProject>true</IsTestProject>
</PropertyGroup>

<ItemGroup>
  <PackageReference Include="Microsoft.NET.Test.Sdk" Version="18.0.1" />
  <PackageReference Include="xunit.v3" Version="3.2.0" />
  <PackageReference Include="xunit.runner.visualstudio" Version="3.1.5" />
</ItemGroup>
```

## Additional Resources

- [Visual Studio Test Explorer](https://learn.microsoft.com/en-us/visualstudio/test/run-unit-tests-with-test-explorer)
- [xUnit Documentation](https://xunit.net/docs/getting-started/netcore/visual-studio)
- [.NET 10 Testing](https://learn.microsoft.com/en-us/dotnet/core/testing/)

## Still Not Working?

If tests still don't appear after trying all solutions:

1. Check Visual Studio version:
   - Help ? About Microsoft Visual Studio
   - Ensure you have latest updates installed

2. Verify .NET 10 SDK is installed:
   ```powershell
   dotnet --version
   # Should show 10.0.x
   ```

3. Try running tests from command line:
   ```powershell
   dotnet test
   ```
   If this works but VS doesn't, it's a VS-specific issue.

4. Reset Visual Studio settings:
   - Tools ? Import and Export Settings
   - Reset all settings
   - (Warning: This will reset all VS customizations)

5. Repair Visual Studio installation:
   - Visual Studio Installer
   - Modify ? Repair
