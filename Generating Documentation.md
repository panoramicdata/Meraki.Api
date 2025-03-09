# Generating documentation

Documentation is generated using DocFX

## Development instructions

1. Ensure that docfx is installed:

```powershell
dotnet tool install -g docfx
```

2. Checkout the Meraki.Api.Docs repository into a sibling directory to the Meraki.Api repository.

3. Build:

Build the documentation:
```powershell
docfx .\docfx.json
```

4. Commit and Push the changes to the Meraki.Api.Docs repository.
