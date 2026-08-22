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
public sealed class MerakiMcpClient : IDisposable, IAsyncDisposable
{
	/// <summary>
	/// The name of the semantic search tool.
	/// </summary>
	public const string SemanticSearchToolName = "semantic_search";

	/// <summary>
	/// The name of the API execution tool.
	/// </summary>
	public const string ExecuteApiToolName = "execute_api";

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

		var response = await CallToolWithRateLimitRetryAsync(
			SemanticSearchToolName,
			new Dictionary<string, object?>(StringComparer.Ordinal) { ["query"] = query },
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

		var response = await CallToolWithRateLimitRetryAsync(ExecuteApiToolName, arguments, cancellationToken)
			.ConfigureAwait(false);

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

	/// <summary>
	/// Calls a tool, transparently retrying while the server reports that the Meraki Dashboard rate
	/// limit has been reached.
	/// </summary>
	/// <remarks>
	/// <para>
	/// The server reports rate limiting <b>inside an otherwise successful tool response</b>, as a
	/// payload error, and answers the HTTP request with 200. So
	/// <see cref="MerakiMcpBackingOffHttpMessageHandler"/> - which can only see status codes - never
	/// sees a 429 and its retry and back-off never engage. Without this, the first rate-limited call
	/// fails outright, however generous <see cref="MerakiMcpClientOptions.MaxAttemptCount"/> is.
	/// </para>
	/// <para>
	/// Rate limiting is an expected condition rather than an exceptional one: an agentic
	/// investigation is several capability calls in quick succession, sharing the documented
	/// 10-requests-per-second-per-organization budget with every other consumer of the same key.
	/// Callers should not have to reimplement retry logic this library already performs for HTTP
	/// 429s, and callers that hand these operations to a language model cannot retry reliably at
	/// all - whether the model retries sensibly is not a decision to delegate.
	/// </para>
	/// <para>
	/// Only rate-limit errors are retried. A missing required parameter is also reported as a
	/// payload error, and retrying that would waste the very budget being protected, so it is left
	/// to fail immediately. See issue #389.
	/// </para>
	/// </remarks>
	private async Task<MerakiMcpToolResponse> CallToolWithRateLimitRetryAsync(
		string toolName,
		IReadOnlyDictionary<string, object?> arguments,
		CancellationToken cancellationToken)
	{
		var attemptCount = 0;

		while (true)
		{
			cancellationToken.ThrowIfCancellationRequested();
			attemptCount++;

			var response = await CallToolAsync(toolName, arguments, cancellationToken)
				.ConfigureAwait(false);

			if (!TryGetRateLimitMessage(response, out var rateLimitMessage))
			{
				return response;
			}

			if (attemptCount >= _options.MaxAttemptCount)
			{
				throw new MerakiMcpRateLimitException(attemptCount);
			}

			var delay = AuthenticatedBackingOffHttpClientHandler.CalculateBackoffDelay(
				attemptCount,
				retryAfterSeconds: 1,
				_options.BackOffDelayFactor,
				_options.MaxBackOffDelaySeconds);

#pragma warning disable CA1873 // Avoid potentially expensive logging
			_logger.LogDebug(
				"Meraki MCP tool {ToolName} reported a rate limit on attempt {AttemptCount}/{MaxAttemptCount} ({RateLimitMessage}). Waiting {TotalSeconds:N1}s.",
				toolName,
				attemptCount,
				_options.MaxAttemptCount,
				rateLimitMessage,
				delay.TotalSeconds);
#pragma warning restore CA1873 // Avoid potentially expensive logging

			Statistics.RecordRetry(delay);

			await Task.Delay(delay, cancellationToken).ConfigureAwait(false);
		}
	}

	/// <summary>
	/// Determines whether a tool response reports that the Meraki Dashboard rate limit was reached.
	/// </summary>
	/// <remarks>
	/// Checks both the MCP error flag and the payload error envelope, because the server has been
	/// observed using the latter for rate limiting.
	/// </remarks>
	internal static bool TryGetRateLimitMessage(MerakiMcpToolResponse response, out string message)
	{
		message = string.Empty;

		if (response.IsError)
		{
			if (!IsRateLimitMessage(response.Text))
			{
				return false;
			}

			message = response.Text!;
			return true;
		}

		var json = response.StructuredJson ?? response.Text;

		if (!TryReadPayloadError(json, out var payloadError) || !IsRateLimitMessage(payloadError))
		{
			return false;
		}

		message = payloadError;
		return true;
	}

	/// <summary>
	/// Determines whether an error message describes Meraki Dashboard rate limiting.
	/// </summary>
	/// <remarks>
	/// Matched on text because the server supplies no machine-readable code for this, which is
	/// itself worth raising with Cisco. Deliberately tolerant of wording changes during the beta:
	/// several phrasings are accepted, and matching is case-insensitive.
	/// </remarks>
	internal static bool IsRateLimitMessage(string? message)
	{
		if (string.IsNullOrWhiteSpace(message))
		{
			return false;
		}

		string[] fragments = ["rate limit", "ratelimit", "rate-limit", "too many requests", "429"];

		foreach (var fragment in fragments)
		{
			if (message!.Contains(fragment, StringComparison.OrdinalIgnoreCase))
			{
				return true;
			}
		}

		return false;
	}

	private async Task<MerakiMcpToolResponse> CallToolAsync(
		string toolName,
		IReadOnlyDictionary<string, object?> arguments,
		CancellationToken cancellationToken)
	{
		var toolNames = await GetToolNamesAsync(cancellationToken).ConfigureAwait(false);

		if (!toolNames.Contains(toolName, StringComparer.Ordinal))
		{
			throw new MerakiMcpToolNotFoundException(toolName, toolNames);
		}

		var session = await GetSessionAsync(cancellationToken).ConfigureAwait(false);

		Statistics.RecordToolCall();

		try
		{
			return await session
				.CallToolAsync(toolName, arguments, cancellationToken)
				.ConfigureAwait(false);
		}
		catch (Exception ex)
		{
			throw Translate(ex, $"calling tool '{toolName}'");
		}
	}

	private async Task<IReadOnlyList<string>> GetToolNamesAsync(CancellationToken cancellationToken)
	{
		if (_toolNames is not null)
		{
			return _toolNames;
		}

		var session = await GetSessionAsync(cancellationToken).ConfigureAwait(false);

		try
		{
			_toolNames = await session.ListToolNamesAsync(cancellationToken).ConfigureAwait(false);
		}
		catch (Exception ex)
		{
			throw Translate(ex, "listing the server's tools");
		}

		return _toolNames;
	}

	private async Task<IMerakiMcpSession> GetSessionAsync(CancellationToken cancellationToken)
	{
		if (_session is not null)
		{
			return _session;
		}

		await _sessionLock.WaitAsync(cancellationToken).ConfigureAwait(false);
		try
		{
			ThrowIfDisposed();

			if (_session is null)
			{
				try
				{
					_session = await _sessionFactory(cancellationToken).ConfigureAwait(false);
				}
				catch (Exception ex)
				{
					throw Translate(ex, "establishing a session");
				}
			}

			return _session;
		}
		finally
		{
			_ = _sessionLock.Release();
		}
	}

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

		foreach (var argument in _options.Arguments)
		{
			(transportOptions.Arguments ??= []).Add(argument);
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

	/// <summary>
	/// Unwraps the Meraki Dashboard payload from the MCP server's response envelope.
	/// </summary>
	/// <remarks>
	/// The server returns <c>{"result":{"type":"success","capability_id":"...","data": ... }}</c>.
	/// Callers want the <c>data</c> element, because that is the shape the equivalent REST call
	/// returns. Returns false when no envelope is recognised, in which case the raw JSON is already
	/// the payload.
	/// </remarks>
	internal static bool TryUnwrapData(string? json, out string dataJson)
	{
		dataJson = string.Empty;

		if (string.IsNullOrWhiteSpace(json))
		{
			return false;
		}

		JToken token;
		try
		{
			token = JToken.Parse(json!);
		}
		catch (JsonException)
		{
			return false;
		}

		if (token is not JObject root || root["result"] is not JObject result)
		{
			return false;
		}

		var data = result["data"];

		if (data is null || data.Type == JTokenType.Null)
		{
			return false;
		}

		dataJson = data.ToString(Formatting.None);
		return true;
	}

	/// <summary>
	/// Detects an error reported in the payload of an otherwise successful tool result.
	/// </summary>
	/// <remarks>
	/// The hosted server returns some failures, notably missing required parameters, as a normal tool
	/// result whose content is an error envelope, without setting the MCP error flag. Both the
	/// documented envelope and a bare top-level error object are recognised.
	/// </remarks>
	internal static bool TryReadPayloadError(string? json, out string message)
	{
		message = string.Empty;

		if (string.IsNullOrWhiteSpace(json))
		{
			return false;
		}

		JToken token;
		try
		{
			token = JToken.Parse(json!);
		}
		catch (JsonException)
		{
			// Not JSON at all, so not a recognisable error envelope. Leave it to the caller.
			return false;
		}

		if (token is not JObject root)
		{
			return false;
		}

		var errorObject = root["result"] as JObject ?? root;

		if (!string.Equals(errorObject["type"]?.Value<string>(), "error", StringComparison.OrdinalIgnoreCase))
		{
			return false;
		}

		var error = errorObject["error"]?.Value<string>() ?? "no detail supplied";
		var recovery = errorObject["recovery_suggestion"]?.Value<string>()
			?? errorObject["recoverySuggestion"]?.Value<string>();

		message = string.IsNullOrWhiteSpace(recovery)
			? error
			: $"{error}. {recovery}";

		return true;
	}

	internal static IReadOnlyList<MerakiCapability> ParseCapabilities(MerakiMcpToolResponse response)
	{
		if (response.IsError)
		{
			throw new MerakiMcpProtocolException(
				$"The Meraki MCP server reported an error searching for capabilities: {response.Text ?? "no detail supplied"}");
		}

		var json = response.StructuredJson ?? response.Text;

		if (string.IsNullOrWhiteSpace(json))
		{
			throw new MerakiMcpProtocolException("The Meraki MCP server returned no content for semantic_search.");
		}

		if (TryReadPayloadError(json, out var payloadError))
		{
			throw new MerakiMcpProtocolException(
				$"The Meraki MCP server reported an error searching for capabilities: {payloadError}");
		}

		JToken token;
		try
		{
			token = JToken.Parse(json!);
		}
		catch (JsonException ex)
		{
			throw new MerakiMcpProtocolException(
				"Could not parse the semantic_search response as JSON. The Meraki MCP server is in beta and its response shapes may change.",
				ex);
		}

		var array = FindCapabilityArray(token)
			?? throw new MerakiMcpProtocolException(
				"Could not locate a capability array in the semantic_search response. The Meraki MCP server is in beta and its response shapes may change.");

		var capabilities = new List<MerakiCapability>();

		foreach (var item in array.OfType<JObject>())
		{
			var capabilityId = ReadString(item, "capability_id", "capabilityId", "capability", "id", "operationId");

			if (string.IsNullOrWhiteSpace(capabilityId))
			{
				continue;
			}

			capabilities.Add(new MerakiCapability
			{
				CapabilityId = capabilityId!,
				Score = ReadDouble(item, "score", "relevance", "relevanceScore", "relevance_score"),
				Description = ReadString(item, "description", "summary", "title"),
				ParameterSchemaJson = ReadRawJson(item, "parameters", "inputSchema", "input_schema", "schema", "parameterSchema")
			});
		}

		return capabilities.Count == 0
			? throw new MerakiMcpProtocolException(
				"The semantic_search response contained no recognisable capabilities. The Meraki MCP server is in beta and its response shapes may change.")
			: capabilities;
	}

	private static JArray? FindCapabilityArray(JToken token)
	{
		if (token is JArray rootArray)
		{
			return rootArray;
		}

		if (token is not JObject rootObject)
		{
			return null;
		}

		foreach (var name in new[] { "capabilities", "results", "data", "items", "matches" })
		{
			if (rootObject[name] is JArray namedArray)
			{
				return namedArray;
			}
		}

		// Fall back to the first array-valued property, so a renamed wrapper does not break parsing.
		return rootObject
			.Properties()
			.Select(property => property.Value)
			.OfType<JArray>()
			.FirstOrDefault();
	}

	private static string? ReadString(JObject item, params string[] names)
	{
		foreach (var name in names)
		{
			if (item[name] is JValue { Type: JTokenType.String } value)
			{
				return value.Value<string>();
			}
		}

		return null;
	}

	private static double? ReadDouble(JObject item, params string[] names)
	{
		foreach (var name in names)
		{
			if (item[name] is JValue { Type: JTokenType.Float or JTokenType.Integer } value)
			{
				return value.Value<double>();
			}
		}

		return null;
	}

	private static string? ReadRawJson(JObject item, params string[] names)
	{
		foreach (var name in names)
		{
			var token = item[name];

			if (token is not null && token.Type != JTokenType.Null)
			{
				return token.ToString(Formatting.None);
			}
		}

		return null;
	}

	private void ThrowIfDisposed() => ObjectDisposedException.ThrowIf(_isDisposed, this);

	/// <summary>
	/// Disposes the client, closing any session and terminating any child process.
	/// </summary>
	public void Dispose()
	{
		if (_isDisposed)
		{
			return;
		}

		_isDisposed = true;

		var session = _session;
		_session = null;

		// Block only as long as necessary; the SDK's disposal is asynchronous.
		session?.DisposeAsync().AsTask().GetAwaiter().GetResult();

		_sessionLock.Dispose();
	}

	/// <summary>
	/// Asynchronously disposes the client, closing any session and terminating any child process.
	/// </summary>
	/// <returns>A task that completes when disposal is complete.</returns>
	public async ValueTask DisposeAsync()
	{
		if (_isDisposed)
		{
			return;
		}

		_isDisposed = true;

		var session = _session;
		_session = null;

		if (session is not null)
		{
			await session.DisposeAsync().ConfigureAwait(false);
		}

		_sessionLock.Dispose();
	}
}
