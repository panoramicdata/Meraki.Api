# Using the Cisco Workflows API

Cisco Workflows is a separate Automation API for creating, managing, and running workflows. The
`MerakiClient.Workflows` property exposes the complete published OpenAPI contract as typed .NET
methods and models.

The surface includes all 156 operations across the following areas:

- workflows and atomic actions, including v1, v1.1, v1.2, and v2 operations;
- workflow instances, action instances, start, pause, resume, cancel, and batch removal;
- targets, target groups, remotes, variables, variable types, tables, and table types;
- schedules, rules, triggers, events, webhooks, calendars, tasks, comments, and categories;
- sharing, ownership, schemas, runtime users, tenants, ratings, and rate-limit information;
- Exchange import, export, duplicate, install, uninstall, image, and release-note operations.

The types live in the `Meraki.Api.Workflows` namespace. They are available on both the
`netstandard2.0` and `net10.0` targets.

## Prerequisites

Cisco requires the caller to have full access to every organization being managed. The role must
include write permission for both network-level and organization-level settings. Use a valid Meraki
Dashboard API key and the organization ID shown in the Dashboard footer.

Cisco currently makes Workflows available to organizations in Asia-Pacific, Canada, Europe, India,
and the United States. It is not available in the China or US Government regions. `ApiRegion`
continues to select the matching API hostname, but it cannot make an unsupported regional service
available; see Cisco's current [Workflows Access](https://documentation.meraki.com/Platform_Management/Workflows/Getting_Started/Workflows_Access)
page before enabling this feature for a regional organization.

The Workflows API expects the Dashboard API key in an `Authorization: Bearer` header. `MerakiClient`
selects that scheme automatically for `/api/automate/organizations/...`; ordinary Dashboard API
requests continue to use `X-Cisco-Meraki-API-Key`. Credentials are never added to URLs.

## Create the client

Use the same `MerakiClient` and options as the Dashboard API:

```csharp
using Meraki.Api;
using Meraki.Api.Workflows;

using var meraki = new MerakiClient(new MerakiClientOptions
{
	ApiKey = merakiDashboardApiKey,
	UserAgent = "YourProduct/1.0 YourCompany"
});
```

`ApiRegion`, `ReadOnly`, `RateLimiter`, `MaxAttemptCount`, `BackOffDelayFactor`, timeout options,
logging, `LastRequestUri`, and `Statistics` all apply to Workflows calls. In particular, setting
`ReadOnly = true` rejects every POST, PUT, PATCH, and DELETE before it reaches Cisco.

## List workflows

Cisco's current example uses the paginated v1.1 POST operation:

```csharp
var page = await meraki.Workflows.GetAllWorkflowsPostQueryParamsAsync(
	organizationId,
	limit: 100,
	search: "backup");

foreach (var workflow in page.Results ?? [])
{
	Console.WriteLine($"{workflow.Id}: {workflow.Title}");
}
```

The v1 GET variant is also available:

```csharp
var workflows = await meraki.Workflows.GetAllWorkflowsQueryParamsV1Async(
	organizationId,
	is_atomic: false,
	categories: "Operations");
```

Parameter and property names follow Cisco's OpenAPI document. This deliberately preserves wire
terminology such as `workflow_id`, `unique_name`, and `Input_variables`, which makes it easy to map
examples from Cisco's REST documentation directly to the .NET call.

## Start a workflow

For the JSON v1 start operation:

```csharp
var instances = await meraki.Workflows.StartWorkflowRequestAsync(
	organizationId,
	workflow_id: workflowId,
	sync: false,
	body: new StartWorklfowPostRequestPayload
	{
		Runtime_user_id = runtimeUserId,
		Input_variables =
		[
			new VariableStartPutRequest
			{
				// Populate the fields required by the workflow input variable.
			}
		]
	});
```

The v1.1 operation supports a file and a JSON request body in one multipart request:

```csharp
await using var stream = File.OpenRead("input.csv");

var instances = await meraki.Workflows.StartWorkflowRequestV1Dot1Async(
	organizationId,
	workflow_id: workflowId,
	sync: true,
	file_name: new FileParameter(stream, "input.csv", "text/csv"),
	request_body: "{\"input_variables\":[]}");
```

Keep the stream open until the awaited operation completes.

## Create and update a workflow

```csharp
var created = await meraki.Workflows.WorkflowCreateRequestAsync(
	new WorkflowDefinitionPostRequest
	{
		Name = "Nightly backup",
		Title = "Nightly backup",
		Type = "generic.workflow",
		Properties = new Dictionary<string, object>
		{
			["display_name"] = "Nightly backup"
		}
	},
	organizationId);

var updated = await meraki.Workflows.WorkflowUpdateRequestAsync(
	organizationId,
	created.Id!,
	new WorkflowDefinitionPutRequest
	{
		Description = "Back up network configuration every night"
	});
```

Methods throw `MerakiWorkflowsApiException` for an HTTP status not declared as successful by the
published contract. The exception includes the status code, response body, and response headers.
Rate-limit and transient 502/503/504 responses first use the same retry and `Retry-After` behaviour
as the rest of `MerakiClient`.

[Cisco currently publishes](https://documentation.meraki.com/Platform_Management/Workflows/Workflows#Important_Notes_and_Limits)
Workflows API limits of 20 Start calls per minute, 50 Instances calls per minute, and 8,000 calls per
hour for other APIs. Treat the server's `429` and `Retry-After` response as authoritative even when
local call volume appears lower: tenant- or service-level controls can be more restrictive than a
caller's own request count.

## Complete minimal workflow lifecycle

This deliberately imports an Exchange-format workflow containing only the built-in `Completed`
logic activity, with no inputs, targets, credentials, or external side effects. Cisco considers a
zero-action workflow invalid, so `Completed` is the smallest workflow that can be validated and
executed. Import is used here because it exercises the same complete artifact that can later be
submitted to the Workflow Exchange. The `finally` block removes both the execution record and
workflow definition if a later assertion or API call fails.

```csharp
string? workflowId = null;
string? instanceId = null;

try
{
	// BuildMinimalCompletedWorkflowExport returns an ImportExport_WFExportObjects containing
	// one generic.workflow and one logic.completed action. Its workflow and action
	// unique_name values must be definition_workflow_<KSUID> and definition_activity_<KSUID>.
	var artifact = BuildMinimalCompletedWorkflowExport();
	var workflow = await meraki.Workflows.ImportFromJSONReqAsync(
		artifact,
		organizationId,
		workflow_unique_name: artifact.Workflow!.Unique_name,
		create_new: true,
		overwrite: false,
		skip_all_runtime_users: true,
		skip_all_module_targets: true);
	workflowId = workflow.Id!;

	var validation = await meraki.Workflows.ValidateWorkflowParamsAsync(
		organizationId,
		workflowId);
	if (validation.Workflow_valid != true)
	{
		throw new InvalidOperationException("The workflow did not validate.");
	}

	var executions = await meraki.Workflows.StartWorkflowRequestAsync(
		organizationId,
		workflow_id: workflowId,
		sync: true,
		body: new StartWorklfowPostRequestPayload());
	instanceId = executions.Single().Id!;

	var instance = await meraki.Workflows.GetWFInstanceByIdAsync(
		organizationId,
		instanceId,
		detailed: true);
	Console.WriteLine(instance.Status?.State);
}
finally
{
	try
	{
		if (instanceId is not null)
		{
			await meraki.Workflows.DeleteWFInstanceByIdAsync(organizationId, instanceId);
		}
	}
	finally
	{
		if (workflowId is not null)
		{
			await meraki.Workflows.DeleteWorkflowByIdAsync(organizationId, workflowId);
		}
	}
}
```

The complete executable artifact builder, including KSUID generation and assertions for the
imported workflow, validation totals, completed execution, detailed instance, and cleanup, is in
[`MerakiWorkflowsIntegrationTests.cs`](../../Meraki.Api.Test/Workflows/MerakiWorkflowsIntegrationTests.cs).
Keeping that builder in executable test code prevents the Exchange example from drifting away from
Cisco's accepted wire format.

`DeleteWorkflowByIdAsync` returns the deleted definition when Cisco responds with `202`, or `null`
when Cisco completes the deletion with `204 No Content`.

## Testing

The fast unit suite exercises a complete one-action lifecycle and verifies methods, routes, query
parameters, request JSON, response deserialization, multipart upload, both authentication modes,
error details, and both successful deletion response shapes. It also proves that a Workflows
`429 rate_limit_exceeded` response is retried through the shared `MerakiClient` transport before the
generated client sees a result. A reflection guard checks that all 156 operations in Cisco's
published contract remain present, uniquely named, asynchronous, organization-scoped, and
cancellable. This class runs in CI without needing Meraki credentials.

The real-service lifecycle test is explicit because it creates and deletes resources. It creates a
unique workflow containing only `Completed`, reads and validates it, executes it synchronously, reads
the detailed run, and deletes the run and workflow from a `finally` block:

```powershell
dotnet run --project Meraki.Api.Test/Meraki.Api.Test.csproj -- `
  -class Meraki.Api.Test.Workflows.MerakiWorkflowsIntegrationTests `
  -explicit only
```

Copy `Meraki.Api.Test/appsettings.example.json` to `Meraki.Api.Test/appsettings.json` first and supply
a test organization and API key with full organization access. The test deliberately uses the same
retry count, `Retry-After` handling, maximum back-off, and request timeout as production
`MerakiClient` calls. Keep this test opt-in in CI: it is intentionally a live mutation test, not a
mocked test.

## API versions and contract source

Workflows is not part of the Dashboard `/api/v1` surface. Its base path is:

```text
https://api.meraki.com/api/automate/organizations/{organizationId}
```

The contract currently contains `/v1`, `/v1.1`, `/v1.2`, `/v2`, and `/exchange/v1` routes. Method
names retain version markers where Cisco publishes multiple variants, for example
`StartWorkflowRequestAsync`, `StartWorkflowRequestV1Dot1Async`, and
`GetAllWorkflowsPostQueryParamsV1Dot2Async`.

The generated contract comes from the Automation OpenAPI file linked by Cisco's
[API Usage documentation](https://documentation.meraki.com/Platform_Management/Workflows/Workflows/API_Usage).
The organization ID published as a server variable is projected into every operation, allowing one
`MerakiClient` instance to safely call more than one organization.
