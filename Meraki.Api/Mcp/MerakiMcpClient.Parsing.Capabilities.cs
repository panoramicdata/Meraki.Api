using ModelContextProtocol.Client;
using Newtonsoft.Json.Linq;
namespace Meraki.Api.Mcp;

public sealed partial class MerakiMcpClient
{
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
}
