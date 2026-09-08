# Meraki.Api

[![Nuget](https://img.shields.io/nuget/v/Meraki.Api)](https://www.nuget.org/packages/Meraki.Api/)
[![Nuget](https://img.shields.io/nuget/dt/Meraki.Api)](https://www.nuget.org/packages/Meraki.Api/)
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)
[![Codacy Badge](https://app.codacy.com/project/badge/Grade/d52eda04578e471e90b8495c40bdcb9d)](https://www.codacy.com/gh/panoramicdata/Meraki.Api/dashboard?utm_source=github.com&amp;utm_medium=referral&amp;utm_content=panoramicdata/Meraki.Api&amp;utm_campaign=Badge_Grade)

This project implements access to the v1 Meraki API

See the [contribution guide](CONTRIBUTING.md) for more information regarding contributing to this project.

## Versioning

**This package's version tracks the Cisco Meraki Dashboard API version it targets. It is not
semantic versioning.**

    1.70.79
    │  │  └── build height, incremented automatically by Nerdbank.GitVersioning
    │  └───── Meraki Dashboard API minor version (this package targets API v1.70)
    └──────── Meraki Dashboard API major version

So `1.70.x` means "generated against Meraki Dashboard API v1.70". The major and minor parts move
when this library is regenerated against a newer Meraki API, and only then.

The practical consequence: **do not bump the major version to signal a breaking change in this
library.** Releasing a `2.0.x` would announce a Meraki Dashboard API v2.0 that does not exist.
Breaking changes to this library are called out in [CHANGELOG.md](CHANGELOG.md) instead, and the
version continues to follow Meraki.

When updating to a new Meraki API version, see the guidance in
[.github/copilot-instructions.md](.github/copilot-instructions.md).

## Supported frameworks

`net10.0` only. Panoramic Data does not support anything lower.

The `netstandard2.0` target was dropped after 1.70.79. It existed to serve .NET Framework and older
.NET consumers, but it also forced a second, quietly different build: several methods could not pass
a `CancellationToken`, and the retry logic compared error strings case-sensitively on
`netstandard2.0` and case-insensitively on `net10.0`, so the two targets could disagree about
whether to retry. The MCP client was excluded from it entirely. Consumers who need `netstandard2.0`
should stay on 1.70.79.

## Library documentation

**[Full documentation is available here](https://panoramicdata.github.io/Meraki.Api/)** including:
* how to use the library
* all methods and properties

## Cisco Workflows API support

`MerakiClient.Workflows` is a typed client for the complete
[Cisco Workflows Automation API](https://documentation.meraki.com/Platform_Management/Workflows/Workflows/API_Usage).
It covers all 156 published operations and their request and response models, including workflows,
runs, targets, variables, schedules, rules, triggers, tables, and Exchange import/export.

```csharp
using var meraki = new MerakiClient(new MerakiClientOptions
{
    ApiKey = merakiDashboardApiKey,
    UserAgent = "YourProduct/1.0 YourCompany"
});

var page = await meraki.Workflows.GetAllWorkflowsPostQueryParamsAsync(
    organizationId,
    limit: 100);

foreach (var workflow in page.Results ?? [])
{
    Console.WriteLine($"{workflow.Id}: {workflow.Title}");
}
```

Every operation takes `organizationId` because Workflows routes are organization-scoped. The
existing `MerakiClientOptions` region, read-only guard, rate limiter, retry/back-off, logging, and
statistics apply unchanged. API keys are automatically sent as `Authorization: Bearer`, as required
by Workflows, without changing authentication for Dashboard API calls.

See the [Workflows API guide](Documentation/docs/workflows-api.md) for listing, creating, validating,
executing, inspecting, and cleaning up a minimal workflow, plus multipart upload, prerequisites,
versioning, and the opt-in live integration test.

## MCP server support

In addition to the REST client, this package can act as a client for the
[Cisco Meraki MCP server](https://developer.cisco.com/meraki/api-v1/mcp-server/), letting an agent
you build search the Meraki Dashboard API capability catalogue in natural language and execute the
capability it selects.


```csharp
using Meraki.Api.Mcp;

// The Cisco-hosted server (the default).
await using var client = new MerakiMcpClient(new MerakiMcpClientOptions
{
    ApiKey = merakiDashboardApiKey
});

var capabilities = await client.SemanticSearchAsync("which clients are on this network?");

var result = await client.ExecuteApiAsync(
    capabilities[0].CapabilityId,
    new Dictionary<string, object?> { ["networkId"] = "N_123" });

// The server wraps results in an envelope. Payload is the "data" element alone, which
// matches the shape the equivalent MerakiClient call returns. Deserialize<T>() uses it.
Console.WriteLine(result.Payload);
var clients = result.Deserialize<List<Client>>();
```

A self-hosted instance of the
[open-source server](https://github.com/CiscoDevNet/cisco-meraki-mcp-official) over HTTP:

```csharp
await using var client = new MerakiMcpClient(new MerakiMcpClientOptions
{
    Transport = MerakiMcpTransport.LocalHttp,
    Uri = "http://localhost:8080/mcp",
    ApiKey = merakiDashboardApiKey,
    ApiRegion = ApiRegion.Government
});
```

Or launched as a child process over stdio:

```csharp
var options = new MerakiMcpClientOptions
{
    Transport = MerakiMcpTransport.Stdio,
    Command = "npx",
    ApiKey = merakiDashboardApiKey
};
options.Arguments.Add("cisco-meraki-mcp-official");

await using var client = new MerakiMcpClient(options);
```

Use `GetStatusAsync()` for a non-destructive connectivity and credential check.

Two things observed against the live hosted server that are worth knowing:

- `MerakiCapability.Score` is currently always `null` — the beta server returns no relevance score, so
  the ranking is the list order alone. Do not filter on a score threshold.
- The server reports some failures, such as a capability called without its required parameters, in
  the payload of an otherwise successful tool result. Both operations detect that and throw
  `MerakiMcpProtocolException` including the server's recovery suggestion, so if a call returns, you
  have data rather than an error document.

### Limitations

These come from Cisco's own documentation, and are worth reading before you design around the server:

- **The server is in beta**, and Cisco documents that breaking changes are possible.
- **Operations are read-only.** `execute_api` cannot mutate anything. Use `MerakiClient` for writes;
  `ExecuteApiAsync` refuses non-read capabilities rather than letting you discover this at runtime.
- **Authentication is by API key only.** OAuth is not yet supported.
- **The hosted server supports Meraki.com environments only** — not Federal, GovCloud, or localised
  instances. Those require a self-hosted server, so `MerakiMcpTransport.HostedHttp` rejects a
  non-default `ApiRegion`.
- **Six static egress IP addresses** may require allowlisting for the hosted server. They are listed
  on `MerakiMcpTransportException.HostedEgressIpAddresses`, and named in the exception message when a
  connection times out.
- **Rate limits are shared.** The server respects the Dashboard limit of 10 requests per second per
  organization, and that budget is shared with any `MerakiClient` traffic in the same process.

## Retries, back-off and rate limiting

Meraki's Dashboard API rate limit is **per organization**, and it is shared with every other
consumer of that organization's API: other applications, scripts, and monitoring tools such as Splunk
that poll aggressively. When the limit is hit the API answers `429 Too Many Requests` with a
`Retry-After` header.

`MerakiClient` retries 429s (and 502/503/504s, per-attempt timeouts and transient connection
failures) transparently. The relevant `MerakiClientOptions` are:

| Option | Default | Meaning |
|---|---|---|
| `MaxAttemptCount` | 500 | Attempts per call before giving up |
| `BackOffDelayFactor` | 1.0 | Base of the exponential back-off. 1.0 is a flat delay |
| `MaxBackOffDelaySeconds` | 30 | Ceiling on any single wait |
| `HttpClientInnerTimeoutSeconds` | 25 | Timeout for one attempt |
| `HttpClientTimeoutSeconds` | 600 | Timeout for the whole call, spanning all attempts and waits |

Before attempt *n* the client waits `min(max(BackOffDelayFactor^(n-1), Retry-After), MaxBackOffDelaySeconds)`
seconds plus a small upward jitter. At the default factor of 1.0 that is simply `Retry-After`, or one
second where the server sends none.

**The defaults are deliberately persistent.** Against a saturated organization, growing back-off is
counter-productive: the longer this client waits, the more of the shared budget the other consumers
take. The most reliable way to get a call through is to keep re-asking, honouring `Retry-After`,
until a slot opens. So out of the box a call *most likely completes*, at the cost of possibly taking a
long time. In practice the bound on that time is `HttpClientTimeoutSeconds`, which ends a still-throttled
call with a `TaskCanceledException` long before attempt 500 is reached.

**To fail fast instead**, override the defaults:

```csharp
var client = new MerakiClient(new MerakiClientOptions
{
    ApiKey = apiKey,
    UserAgent = "YourProduct/1.0 YourCompany",
    MaxAttemptCount = 5,          // give up after five attempts
    BackOffDelayFactor = 2.0,     // 1s, 2s, 4s, 8s between them (capped by MaxBackOffDelaySeconds)
    HttpClientTimeoutSeconds = 60 // and never spend more than a minute on one call
});
```

When attempts run out the client returns the last response, so Refit raises an ordinary `ApiException`
carrying that status (typically 429). That response is indistinguishable from a first-attempt 429; if
you would rather be told "throttled for ten minutes" than "HTTP 429", set
`ThrowOnRetryExhaustion = true` and the client throws `RetryExhaustedException` instead, carrying the
attempt count, the time spent and the final status. It is off by default and is not an `ApiException`,
so existing `catch (ApiException)` handlers will not see it. Per-attempt timeouts that run out of
attempts throw `TimeoutException`.

## API Documentation

The Meraki API documentation can be found here:
- [Meraki API Documentation v1](https://developer.cisco.com/meraki/api-v1/)
- [Meraki OpenAPI Specification (v1-beta)](https://raw.githubusercontent.com/meraki/openapi/refs/heads/v1-beta/openapi/spec3.json)

## Testing

You can test this using a Meraki Sandbox here:
- [Meraki Always On](https://devnetsandbox.cisco.com/RM/Diagram/Index/a9487767-deef-4855-b3e3-880e7f39eadc?diagramType=Topology)
- [Meraki Enterprise](https://devnetsandbox.cisco.com/RM/Diagram/Index/e7b3932b-0d47-408e-946e-c23a0c031bda?diagramType=Topology)
- [Meraki Small Business](https://devnetsandbox.cisco.com/RM/Diagram/Index/aa48e6e2-3e59-4b87-bfe5-7833c45f8db8?diagramType=Topology)

After signing in, look in the lower left hand side of the page for your API key.
