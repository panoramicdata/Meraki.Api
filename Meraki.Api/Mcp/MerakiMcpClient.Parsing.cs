using ModelContextProtocol.Client;
using Newtonsoft.Json.Linq;
namespace Meraki.Api.Mcp;

/// <summary>
/// Reads the Meraki MCP server's JSON: the response envelopes, the capability projection, and the
/// tolerant field lookups the beta server's shifting shapes require.
/// </summary>
/// <remarks>
/// Separated from the client itself, which was otherwise past the file size limit, and because
/// parsing is the part worth reading on its own when a response shape changes.
/// </remarks>
// Codacy analyses each file on its own, so it cannot see the other part of this class and reports
// 'partial' as gratuitous (S2333). The other part is MerakiMcpClient.cs.
#pragma warning disable S2333
public sealed partial class MerakiMcpClient
{
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

		// Anything that is not a JSON object is not a recognisable error envelope, so leave it to the caller.
		if (TryParseJson(json!) is not JObject root)
		{
			return false;
		}

		// Both the documented envelope and a bare top-level error object are recognised.
		var errorObject = root["result"] as JObject ?? root;

		if (!string.Equals(errorObject["type"]?.Value<string>(), "error", StringComparison.OrdinalIgnoreCase))
		{
			return false;
		}

		message = BuildPayloadErrorMessage(errorObject);

		return true;
	}

	/// <summary>
	/// Joins the error to its recovery suggestion, which the server names in either casing.
	/// </summary>
	private static string BuildPayloadErrorMessage(JObject errorObject)
	{
		var error = errorObject["error"]?.Value<string>() ?? "no detail supplied";
		var recovery = errorObject["recovery_suggestion"]?.Value<string>()
			?? errorObject["recoverySuggestion"]?.Value<string>();

		return string.IsNullOrWhiteSpace(recovery)
			? error
			: $"{error}. {recovery}";
	}

	internal static IReadOnlyList<MerakiCapability> ParseCapabilities(MerakiMcpToolResponse response)
	{
		var array = FindCapabilityArray(ParseSearchResponse(ReadSearchResponseJson(response)))
			?? throw new MerakiMcpProtocolException(
				"Could not locate a capability array in the semantic_search response. The Meraki MCP server is in beta and its response shapes may change.");

		var capabilities = array
			.OfType<JObject>()
			.Select(ReadCapability)
			.OfType<MerakiCapability>()
			.ToList();

		return capabilities.Count == 0
			? throw new MerakiMcpProtocolException(
				"The semantic_search response contained no recognisable capabilities. The Meraki MCP server is in beta and its response shapes may change.")
			: capabilities;
	}

	/// <summary>
	/// Reads the semantic_search payload, throwing where the server reported a failure or sent nothing.
	/// </summary>
	private static string ReadSearchResponseJson(MerakiMcpToolResponse response)
	{
		if (response.IsError)
		{
			throw new MerakiMcpProtocolException(
				$"The Meraki MCP server reported an error searching for capabilities: {response.Text ?? "no detail supplied"}");
		}

		var json = response.StructuredJson ?? response.Text;

		return string.IsNullOrWhiteSpace(json)
			? throw new MerakiMcpProtocolException("The Meraki MCP server returned no content for semantic_search.")
			: TryReadPayloadError(json, out var payloadError)
			? throw new MerakiMcpProtocolException(
				$"The Meraki MCP server reported an error searching for capabilities: {payloadError}")
			: json!;
	}

	private static JToken ParseSearchResponse(string json)
	{
		try
		{
			return JToken.Parse(json);
		}
		catch (JsonException ex)
		{
			throw new MerakiMcpProtocolException(
				"Could not parse the semantic_search response as JSON. The Meraki MCP server is in beta and its response shapes may change.",
				ex);
		}
	}

	/// <summary>
	/// Projects one capability object, returning null where it carries no usable identifier.
	/// </summary>
	private static MerakiCapability? ReadCapability(JObject item)
	{
		var capabilityId = ReadString(item, "capability_id", "capabilityId", "capability", "id", "operationId");

		return string.IsNullOrWhiteSpace(capabilityId)
			? null
			: new MerakiCapability
			{
				CapabilityId = capabilityId!,
				Score = ReadDouble(item, "score", "relevance", "relevanceScore", "relevance_score"),
				Description = ReadString(item, "description", "summary", "title"),
				ParameterSchemaJson = ReadRawJson(item, "parameters", "inputSchema", "input_schema", "schema", "parameterSchema")
			};
	}

	/// <summary>
	/// Parses JSON, returning null where the text is not JSON at all.
	/// </summary>
	private static JToken? TryParseJson(string json)
	{
		try
		{
			return JToken.Parse(json);
		}
		catch (JsonException)
		{
			return null;
		}
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
#pragma warning restore S2333
