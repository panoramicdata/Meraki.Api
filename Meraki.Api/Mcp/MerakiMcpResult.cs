namespace Meraki.Api.Mcp;

/// <summary>
/// The result of executing a Meraki Dashboard API capability through the MCP server.
/// </summary>
public class MerakiMcpResult
{
	/// <summary>
	/// The capability identifier that was executed.
	/// </summary>
	public string CapabilityId { get; set; } = string.Empty;

	/// <summary>
	/// The raw JSON the server returned, taken from the tool result's structured content where
	/// present, and otherwise from its text content.
	/// </summary>
	public string RawJson { get; set; } = string.Empty;

	/// <summary>
	/// The unstructured text the server returned, where any was returned.
	/// </summary>
	public string? Text { get; set; }

	/// <summary>
	/// The Meraki Dashboard API payload, unwrapped from the MCP server's response envelope.
	/// </summary>
	/// <remarks>
	/// The server wraps results as
	/// <c>{"result":{"type":"success","capability_id":"...","data": ... }}</c>. This property is the
	/// <c>data</c> element alone, which is the shape the equivalent
	/// <see cref="MerakiClient"/> call returns, and is therefore what you almost always want.
	/// Null when the response carried no recognisable envelope, in which case
	/// <see cref="RawJson"/> is already the payload.
	/// </remarks>
	public string? DataJson { get; set; }

	/// <summary>
	/// The payload to work with: <see cref="DataJson"/> when the envelope was recognised, and
	/// <see cref="RawJson"/> otherwise.
	/// </summary>
	public string Payload => DataJson ?? RawJson;

	/// <summary>
	/// Deserialises <see cref="RawJson"/> into the requested type.
	/// </summary>
	/// <typeparam name="T">The type to deserialise into.</typeparam>
	/// <param name="missingMemberHandling">
	/// How to handle members present in the JSON but absent from <typeparamref name="T"/>.
	/// Defaults to <see cref="JsonMissingMemberHandling.Ignore"/>, because the Meraki MCP server is
	/// in beta and its response shapes may change.
	/// </param>
	/// <returns>The deserialised value, or null when the JSON represents null.</returns>
	/// <exception cref="MerakiMcpProtocolException">Thrown when the JSON cannot be deserialised.</exception>
	public T? Deserialize<T>(JsonMissingMemberHandling missingMemberHandling = JsonMissingMemberHandling.Ignore)
	{
		if (string.IsNullOrWhiteSpace(Payload))
		{
			throw new MerakiMcpProtocolException($"Capability '{CapabilityId}' returned no JSON content to deserialise.");
		}

		try
		{
			return JsonConvert.DeserializeObject<T>(
				Payload,
				new JsonSerializerSettings
				{
					MissingMemberHandling = missingMemberHandling == JsonMissingMemberHandling.ThrowOnError
						? MissingMemberHandling.Error
						: MissingMemberHandling.Ignore
				});
		}
		catch (JsonException ex)
		{
			throw new MerakiMcpProtocolException(
				$"Could not deserialise the response for capability '{CapabilityId}' into {typeof(T).Name}. The Meraki MCP server is in beta and its response shapes may change.",
				ex);
		}
	}

	/// <summary>
	/// Returns a string representation of the result.
	/// </summary>
	/// <returns>The capability identifier and the length of the JSON returned.</returns>
	public override string ToString()
		=> $"{CapabilityId}: {RawJson.Length:N0} JSON characters";
}
