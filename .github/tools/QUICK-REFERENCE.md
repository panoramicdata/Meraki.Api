# Quick Reference: Add-XmlDocumentation.ps1

## Quick Start

```powershell
# From repository root directory:

# 1. Preview changes (safe, no modifications)
.\.github\tools\Add-XmlDocumentation.ps1 -WhatIf

# 2. Apply changes
.\.github\tools\Add-XmlDocumentation.ps1

# 3. Apply with detailed output
.\.github\tools\Add-XmlDocumentation.ps1 -Verbose
```

## Common Scenarios

### I want to see what would change first
```powershell
.\.github\tools\Add-XmlDocumentation.ps1 -WhatIf -Verbose
```

### I want to update only specific files
```powershell
# Not directly supported - manually edit the file filter in the script
# Or process files manually using the functions
```

### I want to use a specific API version
```powershell
$apiVersion = "v1.63.0"
$url = "https://raw.githubusercontent.com/meraki/openapi/refs/tags/$apiVersion/openapi/spec3.json"
.\.github\tools\Add-XmlDocumentation.ps1 -OpenApiUrl $url
```

### I want to check what descriptions would be added
```powershell
.\.github\tools\Add-XmlDocumentation.ps1 -WhatIf -Verbose | Out-File -FilePath "documentation-preview.txt"
```

## What Gets Updated

? **Included:**
- Public classes without `/// <summary>`
- Public interfaces without `/// <summary>`
- Public properties without `/// <summary>`
- Public methods without `/// <summary>`
- Public enums without `/// <summary>`
- Public structs without `/// <summary>`

? **Excluded:**
- Generated files (`*.g.cs`)
- Build artifacts (`obj\`, `bin\`)
- Members that already have `/// <summary>`
- Private/internal members
- Members with existing XML documentation

## Expected Output

```
=== Meraki.Api XML Documentation Generator ===
This script adds XML documentation comments to resolve CS1591 warnings

Source path: C:\Projects\Meraki.Api\Meraki.Api
Downloading OpenAPI specification from: https://raw.githubusercontent.com/meraki/...
Successfully downloaded OpenAPI specification (version: 1.63.0)

Found 234 C# files to process

Updating: C:\Projects\Meraki.Api\Meraki.Api\Data\Device.cs
Updating: C:\Projects\Meraki.Api\Meraki.Api\Data\Network.cs

=== Summary ===
Updated 2 file(s)
Complete!
```

## Troubleshooting

| Problem | Solution |
|---------|----------|
| Script won't run | Check PowerShell execution policy: `Set-ExecutionPolicy -Scope Process -ExecutionPolicy Bypass` |
| Can't download spec | Check internet connection and firewall settings |
| No files updated | All files may already have documentation - run with `-Verbose` to confirm |
| Wrong indentation | Check that source files use tabs consistently |
| Changes look wrong | Use `-PreviewOnly` first, review in Git, revert if needed |

## After Running

1. **Review changes in Git:**
   ```powershell
   git diff
   ```

2. **Build to check for remaining warnings:**
   ```powershell
   dotnet build
   ```

3. **Commit if satisfied:**
   ```powershell
   git add .
   git commit -m "Add XML documentation comments"
   ```

## Integration with Build

Add to your build process:
```powershell
# In your build script or CI/CD pipeline
.\.github\tools\Add-XmlDocumentation.ps1
if ($LASTEXITCODE -ne 0) {
    Write-Error "Documentation update failed"
    exit 1
}
```

## Getting Help

```powershell
Get-Help .\.github\tools\Add-XmlDocumentation.ps1 -Full
```

## Tips

- Always use `-PreviewOnly` first on important projects
- Commit before running to make it easy to revert
- Use `-Verbose` to understand what's happening
- Review the diff carefully before pushing changes
- Consider running on a feature branch first

## Performance

- **Small projects** (< 100 files): ~5-10 seconds
- **Medium projects** (100-500 files): ~20-30 seconds  
- **Large projects** (> 500 files): ~1-2 minutes

Most time is spent downloading the OpenAPI spec on first run.
