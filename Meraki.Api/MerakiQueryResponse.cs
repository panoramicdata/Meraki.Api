using Newtonsoft.Json.Linq;
using System.Net;
using System.Net.Http.Headers;

namespace Meraki.Api;

/// <summary>
/// The result of a generic <see cref="MerakiClient.QueryAsync(HttpMethod, string, string, string, bool, CancellationToken)"/>
/// call against an arbitrary Meraki Dashboard API v1 endpoint.
/// </summary>
/// <remarks>
/// This deliberately does NOT throw on a non-success HTTP status. It carries the status,
/// reason phrase and headers of the final response so that callers (e.g. the ReportMagic
/// Meraki.Query macro) can surface them and decide how to react - mirroring the shape of a
/// raw HTTP call. Read-only violations and transport failures still throw.
/// </remarks>
public class MerakiQueryResponse
{
	/// <summary>
	/// The HTTP status code of the final response (the last page, for paginated results).
	/// </summary>
	public HttpStatusCode StatusCode { get; set; }

	/// <summary>
	/// The reason phrase of the final response, if any.
	/// </summary>
	public string? ReasonPhrase { get; set; }

	/// <summary>
	/// Whether the final response had a 2xx status code.
	/// </summary>
	public bool IsSuccessStatusCode { get; set; }

	/// <summary>
	/// The response headers of the final response.
	/// </summary>
	public HttpResponseHeaders Headers { get; set; } = null!;

	/// <summary>
	/// The parsed JSON of the response. This is a <see cref="JArray"/> for list endpoints
	/// (concatenated across all pages), a <see cref="JObject"/> for single-object endpoints,
	/// or null if the body could not be parsed as JSON (in which case see <see cref="RawBody"/>).
	/// </summary>
	public JToken? Json { get; set; }

	/// <summary>
	/// The raw response body of the final response (unparsed).
	/// </summary>
	public string RawBody { get; set; } = string.Empty;

	/// <summary>
	/// The number of pages retrieved (1 for a single request; greater than 1 when Link-header
	/// pagination was followed).
	/// </summary>
	public int PageCount { get; set; }
}
