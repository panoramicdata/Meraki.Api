# Generating documentation

Documentation is generated using DocFX.

The conceptual pages live in `Documentation/docs/`. The API reference is generated from the built
assembly and its XML documentation — see [Why the built assembly](#why-the-built-assembly) below.

## Development instructions

1. Ensure that docfx is installed:

```powershell
dotnet tool install -g docfx
```

2. Checkout the Meraki.Api repository *on the gh-pages branch* into a sibling directory to the Meraki.Api repository:

```powershell
mkdir ..\Meraki.Api.Docs
git clone https://github.com/panoramicdata/Meraki.Api -b gh-pages ..\Meraki.Api.Docs
```

3. **Build the library in Release first.** The API reference is generated from the built assembly, so
   this step is mandatory and must come before docfx:

```powershell
dotnet build .\Meraki.Api\Meraki.Api.csproj -c Release
```

4. Generate the documentation, from the `Documentation` folder:

```powershell
cd Documentation
Remove-Item -Recurse -Force .\api -ErrorAction SilentlyContinue
docfx .\docfx.json
```

Removing `.\api` first is worth doing: it is generated output and is not tracked, so stale YAML from a
previous run for a since-renamed or removed type would otherwise linger and be published.

5. Commit and push the changes in the `Meraki.Api.Docs` directory. That is the `gh-pages` branch of
   this same repository, so pushing it publishes the site at
   <https://panoramicdata.github.io/Meraki.Api/>.

## Why the built assembly

`docfx.json` points its metadata source at `../Meraki.Api/bin/Release/net10.0/Meraki.Api.dll` rather
than at the `.csproj`. Project-based generation was broken in two independent ways
(issue [#373](https://github.com/panoramicdata/Meraki.Api/issues/373)):

1. **The source generator would not load.** docfx bundles an older Roslyn than
   `RefitClassSourceGenerator` is built against, so docfx skipped it
   (`FailedToLoadAnalyzer: ... ReferencesNewerCompiler`). The generated partial implementations then
   did not exist, the section classes legitimately failed to satisfy their Refit interfaces with
   `CS0535`, and docfx reported `No .NET API detected` — an empty API reference.
2. **The wrong target framework.** `Meraki.Api` multi-targets `netstandard2.0;net10.0`, and
   project-based generation resolves the default target framework. Anything compiled only for
   `net10.0` — which is the entire `Meraki.Api.Mcp` namespace — would have been silently absent.

Generating from the compiled assembly sidesteps both: the generated partials are already in the
assembly, and the target framework is pinned by the path.

The trade-off is that metadata comes from the assembly rather than from source, so there are no
source-file links in the API reference. Given the alternative was no API reference at all, that is
worth it.
