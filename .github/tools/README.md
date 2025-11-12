# Meraki.Api Tools

This directory contains utility scripts for maintaining the Meraki.Api library.

## Add-XmlDocumentation.ps1

A PowerShell script that automatically adds XML documentation comments to C# files to resolve CS1591 warnings.

### Purpose

The script downloads the [Meraki OpenAPI specification](https://raw.githubusercontent.com/meraki/openapi/refs/heads/v1-beta/openapi/spec3.json) and uses it to add missing XML documentation comments (`///`) to:
- Classes
- Interfaces
- Properties
- Methods
- Enums
- Structs

### Usage

#### Basic usage (from repository root):
```powershell
.\.github\tools\Add-XmlDocumentation.ps1
```

#### Preview changes without modifying files:
```powershell
.\.github\tools\Add-XmlDocumentation.ps1 -PreviewOnly
```

#### Verbose output to see what's being processed:
```powershell
.\.github\tools\Add-XmlDocumentation.ps1 -Verbose
```

#### Specify a custom source path:
```powershell
.\.github\tools\Add-XmlDocumentation.ps1 -SourcePath "C:\MyProject\Meraki.Api"
```

#### Use a different OpenAPI specification version:
```powershell
.\.github\tools\Add-XmlDocumentation.ps1 -OpenApiUrl "https://raw.githubusercontent.com/meraki/openapi/refs/tags/v1.63.0/openapi/spec3.json"
```

### Parameters

| Parameter | Description | Default |
|-----------|-------------|---------|
| `SourcePath` | Root path containing C# source files to update | `.\Meraki.Api` |
| `OpenApiUrl` | URL to the Meraki OpenAPI specification | `https://raw.githubusercontent.com/meraki/openapi/refs/heads/v1-beta/openapi/spec3.json` |
| `PreviewOnly` | Preview changes without modifying files | Not set |
| `Verbose` | Show detailed output | Not set |

### What the Script Does

1. Downloads the Meraki OpenAPI specification
2. Scans all C# files in the source path (excluding `obj`, `bin`, and generated files)
3. Identifies public members without XML documentation comments
4. Adds placeholder XML documentation comments
5. Reports which files were updated

### Notes

- The script excludes auto-generated files (`.g.cs`, `generated` folders)
- The script excludes build output directories (`obj`, `bin`)
- Changes are only written when not using `-PreviewOnly`
- Use version control to review changes before committing

### Example Output

```
=== Meraki.Api XML Documentation Generator ===
This script adds XML documentation comments to resolve CS1591 warnings

Source path: C:\Projects\Meraki.Api\Meraki.Api
Downloading OpenAPI specification from: https://raw.githubusercontent.com/meraki/openapi/refs/heads/v1-beta/openapi/spec3.json
Successfully downloaded OpenAPI specification

Found 234 C# files to process

Updating: C:\Projects\Meraki.Api\Meraki.Api\Data\Device.cs
Updating: C:\Projects\Meraki.Api\Meraki.Api\Data\Network.cs

=== Summary ===
Updated 2 file(s)
Complete!
```

## Future Enhancements

Potential improvements for this script:
- Extract actual descriptions from OpenAPI spec schemas
- Match property names to OpenAPI schema properties
- Extract parameter documentation for methods
- Support for adding `<param>`, `<returns>`, and `<exception>` tags
- Integration with CI/CD pipeline to validate documentation coverage
