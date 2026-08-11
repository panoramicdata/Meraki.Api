# Using the Meraki MCP server

As well as the REST client, this library can act as a client for the
[Cisco Meraki MCP server](https://developer.cisco.com/meraki/api-v1/mcp-server/).

The MCP server exists to solve a specific problem: the Meraki Dashboard API has several hundred
endpoints, and knowing which one answers a given question is itself expertise. The server exposes two
tools that let an agent you build and control do that selection for itself:

- `semantic_search` takes a natural-language query and returns ranked capability identifiers.
- `execute_api` executes one of those capabilities and returns the data.

`MerakiMcpClient` wraps both as typed .NET operations.

> [!IMPORTANT]
> `execute_api` is **read-only**. The MCP server cannot change anything in your Meraki estate.
> Use [MerakiClient](getting-started.md) for any mutation. `MerakiMcpClient` enforces this rather
> than letting you discover it at runtime — see [The read-only boundary](#the-read-only-boundary).

> [!NOTE]
> The MCP types target `net10.0` only, because the underlying Model Context Protocol SDK requires
> `net8.0` or later. The `netstandard2.0` build of this package is unchanged and contains no MCP
> types. If you consume the `netstandard2.0` target, MCP support is not available to you.

## Getting started

Install the same `Meraki.Api` package. No separate package is needed.

The normal shape of an agentic query is search, then execute:

``` C#
using Meraki.Api.Mcp;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace My.Project;
public static class Program
{
	public static async Task Main()
	{
		await using var mcpClient = new MerakiMcpClient(
			new MerakiMcpClientOptions
			{
				ApiKey = "0123456789abcdef0123456789abcdef01234567",
				UserAgent = "YourProductName/YourProductVersion YourCompanyName"
			}
		);

		// 1. Ask the server which capabilities answer the question.
		var capabilities = await mcpClient
			.SemanticSearchAsync("which clients are connected to this network?")
			.ConfigureAwait(false);

		Console.WriteLine("Candidate capabilities:");
		foreach (var capability in capabilities)
		{
			Console.WriteLine($"    - {capability.CapabilityId}: {capability.Description}");
		}

		// 2. Execute the best match.
		var result = await mcpClient
			.ExecuteApiAsync(
				capabilities[0].CapabilityId,
				new Dictionary<string, object?>
				{
					["networkId"] = "N_0123456789"
				})
			.ConfigureAwait(false);

		Console.WriteLine(result.RawJson);
	}
}
```

`capabilities[0]` is the server's highest-ranked match. In an agentic application you would normally
pass the whole ranked list to your model and let it choose, along with each capability's
`ParameterSchemaJson`, so it knows what arguments the capability takes.

### Working with the result

`MerakiMcpResult` gives you the raw JSON plus a typed helper:

``` C#
var result = await mcpClient
	.ExecuteApiAsync("getNetworkClients", new Dictionary<string, object?> { ["networkId"] = networkId })
	.ConfigureAwait(false);

// The raw JSON, taken from the tool result's structured content where present.
Console.WriteLine(result.RawJson);

// Or deserialise it. Unknown members are ignored by default, because the
// MCP server is in beta and its response shapes may change.
var clients = result.Deserialize<List<Client>>();
```

### Checking connectivity without making changes

`GetStatusAsync` performs a non-destructive check: it connects, authenticates and confirms that both
required tools are advertised. It reports failures rather than throwing, so it is safe to call from a
health check or a configuration screen. It never includes your API key in its output.

``` C#
var status = await mcpClient.GetStatusAsync().ConfigureAwait(false);

if (!status.IsConnected)
{
	Console.WriteLine($"Not connected: {status.Message}");
	return;
}

Console.WriteLine($"Tools available: {string.Join(", ", status.AvailableToolNames)}");
```

## Choosing a transport

Cisco offers two deployments of the server, and this library supports three ways of reaching them.

### Cisco-hosted (the default)

Cisco hosts and manages the server. Nothing to run.

``` C#
await using var mcpClient = new MerakiMcpClient(
	new MerakiMcpClientOptions
	{
		Transport = MerakiMcpTransport.HostedHttp,   // the default
		ApiKey = apiKey
	}
);
```

The endpoint defaults to `https://mcp.meraki.com/mcp`. This deployment supports Meraki.com
environments **only**.

### Self-hosted over HTTP

Run the [open-source server](https://github.com/CiscoDevNet/cisco-meraki-mcp-official) yourself and
point the client at it. This is the route for any Meraki environment the hosted server does not
support, and for air-gapped or egress-restricted networks.

``` C#
await using var mcpClient = new MerakiMcpClient(
	new MerakiMcpClientOptions
	{
		Transport = MerakiMcpTransport.LocalHttp,
		Uri = "http://localhost:8080/mcp",
		ApiKey = apiKey,
		ApiRegion = ApiRegion.Government
	}
);
```

### Self-hosted over stdio

The client launches the server as a child process and speaks to it over stdin and stdout. The child
process is terminated when the client is disposed. The API key is passed to the child as
`MERAKI_DASHBOARD_API_KEY`, as Cisco documents.

``` C#
var options = new MerakiMcpClientOptions
{
	Transport = MerakiMcpTransport.Stdio,
	Command = "npx",
	ApiKey = apiKey
};

options.Arguments.Add("cisco-meraki-mcp-official");
options.EnvironmentVariables["LOG_LEVEL"] = "debug";

await using var mcpClient = new MerakiMcpClient(options);
```

### Which regions work where

The Cisco-hosted server supports Meraki.com environments only. Federal, GovCloud and localised
instances require a self-hosted server. Rather than let that fail confusingly at runtime, combining
`HostedHttp` with a non-default `ApiRegion` throws `ConfigurationException` when the client is
constructed, and the message names `LocalHttp` and `Stdio` as the remedy.

## The read-only boundary

`execute_api` cannot mutate anything. That is a property of Cisco's server, not of this library.

Because every Meraki Dashboard GET operation identifier begins with `get`, `ExecuteApiAsync` can tell
a read from a write before any request leaves your process. Asking it to execute a mutation throws
`MerakiMcpReadOnlyViolationException`, and the message directs you to `MerakiClient`:

``` C#
// Throws MerakiMcpReadOnlyViolationException. Nothing is sent to the server.
await mcpClient.ExecuteApiAsync("updateNetworkWirelessSsid", parameters);
```

The pattern for an application that both diagnoses and remediates is therefore to read through MCP
and write through REST:

``` C#
// Diagnose agentically, through the MCP server.
var capabilities = await mcpClient.SemanticSearchAsync("wireless client connection failures");
var evidence = await mcpClient.ExecuteApiAsync(capabilities[0].CapabilityId, parameters);

// ... decide what to do, and have a human approve it ...

// Then apply the change through the REST client.
using var merakiClient = new MerakiClient(new MerakiClientOptions { ApiKey = apiKey });
await merakiClient.Networks.Wireless.Ssids.UpdateNetworkWirelessSsidAsync(networkId, number, update);
```

Should Cisco change its capability naming during the beta, set
`EnforceReadOnlyCapabilityNames = false` to disable the client-side check. The server remains
read-only regardless.

## Handling failures

Errors are surfaced as specific exception types, so you can react to each case rather than parsing
messages. All derive from `MerakiMcpException`.

| Exception | Meaning | What to do |
|---|---|---|
| `MerakiMcpAuthenticationException` | HTTP 401. The API key is invalid, expired or malformed. | Correct the credential. |
| `MerakiMcpAuthorizationException` | HTTP 403. The key is valid but is not authorised for that organization or capability. | Check the key's organization access. |
| `MerakiMcpRateLimitException` | Still rate limited after `MaxAttemptCount` attempts. | Reduce concurrency, or raise the attempt count. |
| `MerakiMcpToolNotFoundException` | A required tool is not advertised. The server is in beta and its catalogue may change. | Check Cisco's documentation and update this package. The exception lists what the server did advertise. |
| `MerakiMcpReadOnlyViolationException` | A mutation was attempted through MCP. | Use `MerakiClient`. |
| `MerakiMcpTransportException` | The server could not be reached, or a stdio child process failed. | Check connectivity and egress rules. |
| `MerakiMcpProtocolException` | The server reported an error, or its response could not be understood. | Inspect the message; may indicate a beta schema change. |

``` C#
try
{
	var result = await mcpClient.ExecuteApiAsync(capabilityId, parameters).ConfigureAwait(false);
}
catch (MerakiMcpReadOnlyViolationException)
{
	// Route this through MerakiClient instead.
}
catch (MerakiMcpAuthorizationException)
{
	// The key is fine, but it cannot see this organization.
}
catch (MerakiMcpException ex)
{
	// Everything else. The message never contains your API key.
	logger.LogError(ex, "Meraki MCP query failed.");
}
```

### Egress allowlisting

Cisco publishes six static egress IP addresses for the hosted server, which some networks will need
to allowlist. They are available on `MerakiMcpTransportException.HostedEgressIpAddresses`, and are
named in the exception message when a connection to the hosted server times out, so the cause is
obvious from the log alone.

## Rate limits, retries and statistics

The server respects the Dashboard API limit of 10 requests per second per organization.

> [!WARNING]
> That budget is **shared** with any `MerakiClient` traffic in the same process. A multi-step agentic
> investigation competes with your scheduled polling.

Retries are handled inside the client, honouring `Retry-After` and then applying exponential back-off:

``` C#
var options = new MerakiMcpClientOptions
{
	ApiKey = apiKey,
	MaxAttemptCount = 10,          // attempts before giving up
	BackOffDelayFactor = 1.5,      // exponential factor per attempt
	MaxBackOffDelaySeconds = 30    // ceiling on any single wait
};
```

Do not add your own retry loop on top, or the effective attempt count multiplies.

`MerakiMcpClientStatistics` exposes what actually happened, which is worth logging in a long-running
service:

``` C#
Console.WriteLine(mcpClient.Statistics);
// Tool calls: 14, Retries: 2, Back-off: 3,000ms. Total Requests: 31, Status codes: 200: 29 ..., 429: 2 ...
```

## Logging

Pass an `ILogger` as the second constructor argument to see transport-level detail. No secret value
is ever written to a log or included in an exception message.

``` C#
await using var mcpClient = new MerakiMcpClient(options, logger);
```

## Limitations

These are properties of Cisco's server, taken from their documentation. They are worth reading before
designing around it:

- **The server is in beta**, and Cisco documents that breaking changes are possible. This client
  tolerates unknown JSON members and variations in response shape for that reason, but a renamed tool
  will still require a package update.
- **Operations are read-only.**
- **Authentication is by API key only.** OAuth is not supported yet, so the credential is a
  full-scope Dashboard key. Treat it accordingly.
- **The hosted server supports Meraki.com only** — not Federal, GovCloud or localised instances.
- **Six static egress IP addresses** may require allowlisting for the hosted server.
- **Rate limits are shared** with your REST traffic.

## A note on untrusted content

Data returned from Meraki includes strings that people other than you control: device names, SSIDs,
client hostnames and note fields. If you are feeding these into a language model, treat them as
untrusted input rather than as instructions. This matters as much as any of the limitations above.
