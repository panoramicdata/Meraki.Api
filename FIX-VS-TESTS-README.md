# How to Fix VS Test Runner

## Quick Fix (5 steps)

1. **Close Visual Studio**

2. **Run the quick fix script:**
   ```powershell
   .\quick-fix-vs-tests.ps1
   ```

3. **Open Visual Studio**

4. **Rebuild Solution:**
   - Right-click solution ? Clean Solution
   - Right-click solution ? Rebuild Solution

5. **Open Test Explorer:**
   - Press `Ctrl+E, T`
   - Click refresh button (?)
   - Tests should appear!

## If That Doesn't Work

See: `VS-TEST-RUNNER-TROUBLESHOOTING.md` for detailed troubleshooting steps.

## Verify Tests Work from Command Line

```powershell
# List all tests
dotnet test --list-tests

# Run all tests
dotnet test
```

If tests work from command line but not in VS, it's definitely a VS cache issue.
