# Meraki.Api

[![Nuget](https://img.shields.io/nuget/v/Meraki.Api)](https://www.nuget.org/packages/Meraki.Api/)
[![Nuget](https://img.shields.io/nuget/dt/Meraki.Api)](https://www.nuget.org/packages/Meraki.Api/)
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)
[![Codacy Badge](https://app.codacy.com/project/badge/Grade/d52eda04578e471e90b8495c40bdcb9d)](https://www.codacy.com/gh/panoramicdata/Meraki.Api/dashboard?utm_source=github.com&amp;utm_medium=referral&amp;utm_content=panoramicdata/Meraki.Api&amp;utm_campaign=Badge_Grade)

This project implements access to the v1 Meraki API

See the [contribution guide](CONTRIBUTING.md) for more information regarding contributing to this project.

## Library documentation

**[Full documentation is available here](https://panoramicdata.github.io/Meraki.Api/)** including:
* how to use the library
* all methods and properties

## MCP server support

In addition to the REST client, this package can act as a client for the
[Cisco Meraki MCP server](https://developer.cisco.com/meraki/api-v1/mcp-server/), letting an agent
you build search the Meraki Dashboard API capability catalogue in natural language and execute the
capability it selects.

The MCP types target `net10.0` only. The `netstandard2.0` target is unchanged.

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
