using ModelContextProtocol.Client;
using Newtonsoft.Json.Linq;

namespace Meraki.Api.Mcp;

// Codacy analyses each file on its own, so it reports 'partial' as gratuitous (S2333) and the static-only parts as S1118. The other parts live in sibling files.
#pragma warning disable S2333, S1118
public sealed partial class MerakiMcpClient
{
	/// <summary>
	/// Builds a session over an arbitrary SDK transport. Used by tests to drive the real SDK client
	/// against an in-process server.
	/// </summary>
	internal static async Task<IMerakiMcpSession> CreateSessionFromTransportAsync(
		IClientTransport transport,
		CancellationToken cancellationToken)
	{
		var client = await McpClient
			.CreateAsync(transport, cancellationToken: cancellationToken)
			.ConfigureAwait(false);

		return new McpSdkSession(client, ownedResource: null);
	}

	private Task<IMerakiMcpSession> CreateSdkSessionAsync(CancellationToken cancellationToken)
		=> _options.Transport == MerakiMcpTransport.Stdio
			? CreateStdioSessionAsync(cancellationToken)
			: CreateHttpSessionAsync(cancellationToken);

	private async Task<IMerakiMcpSession> CreateHttpSessionAsync(CancellationToken cancellationToken)
	{
		var handler = new MerakiMcpBackingOffHttpMessageHandler(_options, Statistics, _logger)
		{
			InnerHandler = new HttpClientHandler()
		};

		var httpClient = new HttpClient(handler)
		{
			Timeout = TimeSpan.FromSeconds(_options.HttpClientTimeoutSeconds)
		};

		try
		{
			var transport = new HttpClientTransport(
				new HttpClientTransportOptions
				{
					Endpoint = new Uri(_options.Uri),
					TransportMode = HttpTransportMode.StreamableHttp,
					Name = "Meraki"
				},
				httpClient);

			var client = await McpClient
				.CreateAsync(transport, cancellationToken: cancellationToken)
				.ConfigureAwait(false);

			return new McpSdkSession(client, httpClient);
		}
		catch
		{
			httpClient.Dispose();
			throw;
		}
	}

	private async Task<IMerakiMcpSession> CreateStdioSessionAsync(CancellationToken cancellationToken)
	{
		var transportOptions = new StdioClientTransportOptions
		{
			Command = _options.Command!,
			Name = "Meraki"
		};

		if (_options.Arguments.Count > 0)
		{
			transportOptions.Arguments ??= [];
			foreach (var argument in _options.Arguments)
			{
				transportOptions.Arguments.Add(argument);
			}
		}

		if (_options.WorkingDirectory is not null)
		{
			transportOptions.WorkingDirectory = _options.WorkingDirectory;
		}

		// The stdio server reads the API key from its environment, as documented by Cisco.
		var environmentVariables = new Dictionary<string, string?>(StringComparer.Ordinal)
		{
			["MERAKI_DASHBOARD_API_KEY"] = _options.ApiKey
		};

		foreach (var pair in _options.EnvironmentVariables)
		{
			environmentVariables[pair.Key] = pair.Value;
		}

		transportOptions.EnvironmentVariables = environmentVariables;

		var transport = new StdioClientTransport(transportOptions);

		try
		{
			var client = await McpClient
				.CreateAsync(transport, cancellationToken: cancellationToken)
				.ConfigureAwait(false);

			return new McpSdkSession(client, ownedResource: null);
		}
		catch (Exception ex) when (ex is not OperationCanceledException and not MerakiMcpException)
		{
			throw new MerakiMcpTransportException(
				$"Could not start or communicate with the Meraki MCP server child process '{_options.Command}'. Check that the command exists, is executable, and speaks MCP over stdio.",
				ex);
		}
	}

	/// <summary>
	/// Translates an SDK or transport exception into this package's exception taxonomy, preserving any
	/// exception the HTTP handler already produced.
	/// </summary>
	internal static Exception Translate(Exception exception, string activity)
	{
		for (var candidate = exception; candidate is not null; candidate = candidate.InnerException)
		{
			if (candidate is MerakiMcpException merakiMcpException)
			{
				return merakiMcpException;
			}

			if (candidate is OperationCanceledException operationCanceledException)
			{
				return operationCanceledException;
			}
		}

		return new MerakiMcpProtocolException(
			$"The Meraki MCP server failed while {activity}: {exception.Message}",
			exception);
	}
}
