---
name: meraki-api-update
description: >-
  Update the Meraki.Api library for a specific Meraki Dashboard API version by
  downloading the versioned OpenAPI spec and changelog, comparing them against
  existing models and Refit interfaces, implementing missing model members when
  feasible, and noting missing endpoints or related follow-up changes. Use this
  when asked to update Meraki.Api to a version like 1.63.0 or v1.63.0, review a
  Meraki API release, fill in missing schema members, or identify missing
  endpoints.
---
# Meraki API Update Skill

Use this skill when the user wants to update the main Meraki.Api library for a
specific Meraki Dashboard API version.

## Required Input

- A single Meraki API version such as `1.63.0` or `v1.63.0`

If the user has not supplied a version, ask for it before proceeding.

To suggest the latest available version automatically, run:

```powershell
pwsh -File .\.github\skills\meraki-api-update\Prepare-MerakiApiUpdate.ps1 -Latest
```

## Workflow

1. Normalize the version to `vX.Y.Z`.
2. Download the official changelog and OpenAPI spec for that version by running:

```powershell
pwsh -File .\.github\skills\meraki-api-update\Prepare-MerakiApiUpdate.ps1 -Version 1.63.0
```

If no version was provided by the user, discover and suggest the latest version
first using `-Latest`, then continue after confirmation.

3. Review the downloaded files under `tmp/meraki-api-update/<version>/`:
   - `changelog.md`
   - `spec3.json`
   - `metadata.json`
4. Compare the changelog and OpenAPI schemas against the existing codebase.
5. Implement feasible missing model members and other directly supported code
   changes.
6. Identify missing endpoints, section wiring, request/response models, or other
   follow-up work that should be implemented.
7. Update `CHANGELOG.md` with the changes made in the repository.
8. Validate with a repository build.

## What To Compare

- Existing models under `Meraki.Api/Data/`
- Refit interfaces under `Meraki.Api/Interfaces/`
- Section exposure under `Meraki.Api/Sections/`
- Existing request and response types
- Existing XML documentation and nullability

## Implementation Rules

Follow the repository instructions in `.github/copilot-instructions.md` while
applying this workflow.

- Keep changes compatible with `.NET Standard 2.0` and `.NET 10`.
- Follow existing naming and file placement patterns.
- Add XML documentation to new public APIs.
- Use `[DataMember(Name = "apiName")]` for model properties.
- Use `[ApiAccess(...)]` when the model pattern calls for it.
- Default optional properties to nullable types.
- Do not use `[AliasAs]` on path parameters.
- Include `CancellationToken cancellationToken = default` on async Refit
  methods.
- Separate request models from response models when appropriate.

## Expected Changes

Implement when feasible in the same run:

- Missing model members on existing classes
- New model classes required by newly exposed schemas
- Missing Refit interface methods for clearly supported endpoints
- Missing section properties needed to reach new interfaces
- Repository changelog updates for the versioned work you completed

Always note when you find additional work that is not completed, such as:

- Endpoints that still need implementation
- Ambiguous schema changes that need a product decision
- Large or risky surface-area changes deferred for review
- Documentation mismatches or likely generator follow-up work

## Recommended Search Strategy

- Start from the schema or endpoint named in the changelog or OpenAPI spec.
- Search for the nearest existing model or interface with the same resource
  family.
- Prefer updating the owning abstraction rather than scattering one-off changes.
- Reuse nearby patterns for pagination, query parameters, request models, and
  sections.

## Helper Assets

- `.github/skills/meraki-api-update/Prepare-MerakiApiUpdate.ps1`
- `.github/tools/Add-XmlDocumentation.ps1`

The preparation script fetches the versioned source documents into the ignored
`tmp` folder. The XML documentation helper can be used after model and interface
updates if new public members need doc comments.

## Validation

Run the repository build from the root after making changes:

```powershell
dotnet build Meraki.Api.slnx -c Debug
```

If the build passes but the changelog or spec clearly indicates additional
unimplemented endpoints, call those out explicitly in the final summary.