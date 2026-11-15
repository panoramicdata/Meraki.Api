using ModelContextProtocol.Client;
using Newtonsoft.Json.Linq;

namespace Meraki.Api.Mcp;

/// <summary>
/// A client for the Cisco Meraki MCP server.
/// </summary>
/// <remarks>
/// <para>
/// The Meraki MCP server exposes two tools: semantic_search, which searches the Meraki Dashboard API
/// capability catalogue with a natural-language query, and execute_api, which executes a
/// <em>read-only</em> capability selected from that search.
/// </para>
/// <para>
/// Mutations are deliberately out of scope. Use <see cref="MerakiClient"/> for those.
/// </para>
/// <para>
/// The server is in beta and Cisco documents that breaking changes are possible. See
/// <see href="https://developer.cisco.com/meraki/api-v1/mcp-server/">Meraki MCP Server</see>.
/// </para>
/// </remarks>
// Codacy analyses each file on its own, so it cannot see the other part of this class and reports
// 'partial' as gratuitous (S2333). The other part is MerakiMcpClient.Parsing.cs.
#pragma warning disable S2333
public sealed partial class MerakiMcpClient : IDisposable, IAsyncDisposable
{
	/// <summary>
	/// The name of the semantic search tool.
	/// </summary>
	public static readonly string SemanticSearchToolName = "semantic_search";

	/// <summary>
	/// The name of the API execution tool.
	/// </summary>
	public static readonly string ExecuteApiToolName = "execute_api";

	private readonly MerakiMcpClientOptions _options;
	private readonly ILogger _logger;
	private readonly Func<CancellationToken, Task<IMerakiMcpSession>> _sessionFactory;
	private readonly SemaphoreSlim _sessionLock = new(1, 1);

	private IMerakiMcpSession? _session;
	private IReadOnlyList<string>? _toolNames;
	private bool _isDisposed;

	/// <summary>
	/// Statistics for this client.
	/// </summary>
	public MerakiMcpClientStatistics Statistics { get; } = new();

	/// <summary>
	/// Initializes a new instance of the <see cref="MerakiMcpClient"/> class.
	/// </summary>
	/// <param name="options">The options. These are validated immediately.</param>
	/// <param name="logger">An optional logger.</param>
	/// <exception cref="ArgumentNullException">Thrown when <paramref name="options"/> is null.</exception>
	/// <exception cref="ConfigurationException">Thrown when the options are not usable.</exception>
	public MerakiMcpClient(MerakiMcpClientOptions options, ILogger? logger = null)
	{
		_options = options ?? throw new ArgumentNullException(nameof(options));
		_options.Validate();
		_logger = logger ?? NullLogger.Instance;
		_sessionFactory = CreateSdkSessionAsync;
	}

	/// <summary>
	/// Initializes a new instance of the <see cref="MerakiMcpClient"/> class with an injected session
	/// factory. Used by tests to exercise the client without a server or a child process.
	/// </summary>
	internal MerakiMcpClient(
		MerakiMcpClientOptions options,
		ILogger? logger,
		Func<CancellationToken, Task<IMerakiMcpSession>> sessionFactory)
	{
		_options = options ?? throw new ArgumentNullException(nameof(options));
		_options.Validate();
		_logger = logger ?? NullLogger.Instance;
		_sessionFactory = sessionFactory ?? throw new ArgumentNullException(nameof(sessionFactory));
	}

	/// <summary>
	/// Determines whether a capability identifier names a read operation.
	/// </summary>
	/// <param name="capabilityId">The capability identifier, for example "getNetworkClients".</param>
	/// <returns>True when the identifier names a read operation.</returns>
	/// <remarks>
	/// Every Meraki Dashboard GET operation identifier begins with "get".
	/// </remarks>
	public static bool IsReadCapabilityName(string? capabilityId)
		=> !string.IsNullOrWhiteSpace(capabilityId)
			&& capabilityId!.StartsWith("get", StringComparison.OrdinalIgnoreCase);

	/// <summary>
	/// Searches the Meraki Dashboard API capability catalogue with a natural-language query.
	/// </summary>
	/// <param name="query">The natural-language query.</param>
	/// <param name="cancellationToken">A cancellation token.</param>
	/// <returns>The ranked capabilities the server returned.</returns>
	/// <exception cref="ArgumentException">Thrown when <paramref name="query"/> is null or whitespace.</exception>
	/// <exception cref="ObjectDisposedException">Thrown when this client has been disposed.</exception>
	/// <exception cref="MerakiMcpToolNotFoundException">Thrown when the server does not advertise the semantic_search tool.</exception>
	/// <exception cref="MerakiMcpRateLimitException">Thrown when the server was still reporting a rate limit after <see cref="MerakiMcpClientOptions.MaxAttemptCount"/> attempts.</exception>
	/// <exception cref="MerakiMcpProtocolException">Thrown when the server's response cannot be understood.</exception>
	public async Task<IReadOnlyList<MerakiCapability>> SemanticSearchAsync(
		string query,
		CancellationToken cancellationToken = default)
	{
		ThrowIfDisposed();

		if (string.IsNullOrWhiteSpace(query))
		{
			throw new ArgumentException("A natural-language query is required.", nameof(query));
		}

		var arguments = new Dictionary<string, object?>(StringComparer.Ordinal) { ["query"] = query };

		var response = await MerakiMcpRateLimitPolicy.CallWithRetryAsync(
			token => CallToolAsync(SemanticSearchToolName, arguments, token),
			SemanticSearchToolName,
			_options,
			Statistics,
			_logger,
			cancellationToken)
			.ConfigureAwait(false);

		return ParseCapabilities(response);
	}

	/// <summary>
	/// Executes a read-only Meraki Dashboard API capability selected from
	/// <see cref="SemanticSearchAsync"/>.
	/// </summary>
	/// <param name="capabilityId">The capability identifier, for example "getNetworkClients".</param>
	/// <param name="parameters">The capability's parameters, where it takes any.</param>
	/// <param name="cancellationToken">A cancellation token.</param>
	/// <returns>The result the server returned.</returns>
	/// <exception cref="ArgumentException">Thrown when <paramref name="capabilityId"/> is null or whitespace.</exception>
	/// <exception cref="ObjectDisposedException">Thrown when this client has been disposed.</exception>
	/// <exception cref="MerakiMcpReadOnlyViolationException">
	/// Thrown when the capability does not name a read operation. The MCP server is read-only by
	/// design; use <see cref="MerakiClient"/> for mutations.
	/// </exception>
	/// <exception cref="MerakiMcpToolNotFoundException">Thrown when the server does not advertise the execute_api tool.</exception>
	/// <exception cref="MerakiMcpRateLimitException">Thrown when the server was still reporting a rate limit after <see cref="MerakiMcpClientOptions.MaxAttemptCount"/> attempts.</exception>
	/// <exception cref="MerakiMcpProtocolException">Thrown when the server reports an error or its response cannot be understood.</exception>
	public async Task<MerakiMcpResult> ExecuteApiAsync(
		string capabilityId,
		IReadOnlyDictionary<string, object?>? parameters = null,
		CancellationToken cancellationToken = default)
	{
		ThrowIfDisposed();

		if (string.IsNullOrWhiteSpace(capabilityId))
		{
			throw new ArgumentException("A capability identifier is required.", nameof(capabilityId));
		}

		if (_options.EnforceReadOnlyCapabilityNames && !IsReadCapabilityName(capabilityId))
		{
			throw MerakiMcpReadOnlyViolationException.ForCapability(capabilityId);
		}

		var arguments = BuildExecuteApiArguments(capabilityId, parameters);

		var response = await MerakiMcpRateLimitPolicy.CallWithRetryAsync(
			token => CallToolAsync(ExecuteApiToolName, arguments, token),
			ExecuteApiToolName,
			_options,
			Statistics,
			_logger,
			cancellationToken)
			.ConfigureAwait(false);

		return BuildExecuteApiResult(capabilityId, response);
	}

	private static Dictionary<string, object?> BuildExecuteApiArguments(
		string capabilityId,
		IReadOnlyDictionary<string, object?>? parameters)
	{
		var arguments = new Dictionary<string, object?>(StringComparer.Ordinal)
		{
			["capability_id"] = capabilityId
		};

		if (parameters is not null && parameters.Count > 0)
		{
			arguments["parameters"] = parameters.ToDictionary(
				pair => pair.Key,
				pair => pair.Value,
				StringComparer.Ordinal);
		}

		return arguments;
	}

	/// <summary>
	/// Turns a successful tool response into a result, throwing where the server reported a failure
	/// either through the MCP error flag or in the payload itself.
	/// </summary>
	private static MerakiMcpResult BuildExecuteApiResult(string capabilityId, MerakiMcpToolResponse response)
	{
		if (response.IsError)
		{
			throw new MerakiMcpProtocolException(
				$"The Meraki MCP server reported an error executing capability '{capabilityId}': {response.Text ?? "no detail supplied"}");
		}

		var rawJson = response.StructuredJson ?? response.Text ?? string.Empty;

		// The server also reports some failures in the *payload* of an otherwise successful tool
		// result, without setting the MCP error flag. Missing required parameters arrive this way.
		// Surface those as exceptions too, rather than handing an error document back as if it
		// were data.
		return TryReadPayloadError(rawJson, out var payloadError)
			? throw new MerakiMcpProtocolException(
				$"The Meraki MCP server reported an error executing capability '{capabilityId}': {payloadError}")
			: new MerakiMcpResult
			{
				CapabilityId = capabilityId,
				RawJson = rawJson,
				DataJson = TryUnwrapData(rawJson, out var dataJson) ? dataJson : null,
				Text = response.Text
			};
	}

	/// <summary>
	/// Performs a non-destructive connectivity and credential check.
	/// </summary>
	/// <param name="cancellationToken">A cancellation token.</param>
	/// <returns>The status. This never throws for an expected failure; inspect the result instead.</returns>
	/// <exception cref="ObjectDisposedException">Thrown when this client has been disposed.</exception>
	public async Task<MerakiMcpStatus> GetStatusAsync(CancellationToken cancellationToken = default)
	{
		ThrowIfDisposed();

		try
		{
			var toolNames = await GetToolNamesAsync(cancellationToken).ConfigureAwait(false);

			var missing = new[] { SemanticSearchToolName, ExecuteApiToolName }
				.Where(name => !toolNames.Contains(name, StringComparer.Ordinal))
				.ToList();

			return missing.Count > 0
				? MerakiMcpStatus.Disconnected(
					$"Connected, but the server does not advertise the required tool(s): {string.Join(", ", missing)}. Tools advertised: {(toolNames.Count == 0 ? "none" : string.Join(", ", toolNames))}.")
				: MerakiMcpStatus.Connected(toolNames);
		}
		catch (Exception ex) when (ex is not OperationCanceledException)
		{
			// The message is built from exception text only, which never contains the credential.
			return MerakiMcpStatus.Disconnected(ex.Message);
		}
	}
}
