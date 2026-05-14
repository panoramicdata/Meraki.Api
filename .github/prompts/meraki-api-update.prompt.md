---
agent: ask
model: Auto (copilot)
description: "Run a Meraki.Api version update workflow. Accept a target version or discover the latest version and suggest it before proceeding."
---
Update the Meraki.Api repository to a target Meraki Dashboard API version.

Inputs:
- Optional target version from the user, for example `1.63.0` or `v1.63.0`.

Behavior:
1. If the user did not provide a version, run:
   `pwsh -File .\.github\skills\meraki-api-update\Prepare-MerakiApiUpdate.ps1 -Latest`
2. Read the discovered version from the script output and suggest it to the user for confirmation.
3. Prepare update inputs for the confirmed version:
   `pwsh -File .\.github\skills\meraki-api-update\Prepare-MerakiApiUpdate.ps1 -Version <confirmed-version>`
4. Follow the workflow in:
   `.github/skills/meraki-api-update/SKILL.md`
5. Implement feasible missing model members and related updates in the same run.
6. Clearly list missing endpoints or larger follow-up items not yet implemented.
7. Build and validate with:
   `dotnet build Meraki.Api.slnx -c Debug`

Constraints:
- Follow `.github/copilot-instructions.md`.
- Keep compatibility with .NET Standard 2.0 and .NET 10.
- Do not commit changes automatically.
