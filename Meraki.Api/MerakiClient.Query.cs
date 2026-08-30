using Newtonsoft.Json.Linq;
using System.Net.Http.Headers;

namespace Meraki.Api;

/// <summary>
/// Generic, arbitrary-path passthrough to the Meraki Dashboard API v1.
/// </summary>
/// <remarks>
/// This routes through the same core <see cref="HttpClient"/> as every typed endpoint, so it
/// inherits authentication, read-only gating, rate limiting and 429/5xx back-off from
/// the internal authenticated handler automatically. It exists so callers that need endpoints
/// not (yet) surfaced as typed methods - or that must choose the endpoint at runtime - can still
/// benefit from the client's transport behaviour.
/// </remarks>
// Codacy analyses each file on its own, so it cannot see the other parts of this class and reports
// 'partial' as gratuitous (S2333). Both are false positives: the remaining parts are emitted by
// RefitClassSourceGenerator, or live in the sibling MerakiClient files.
#pragma warning disable S2333
public partial class MerakiClient
{
	/// <summary>
	/// Executes an arbitrary Meraki Dashboard API v1 request.
	/// </summary>
	/// <param name="method">The HTTP method. Non-GET methods throw if the client is read-only.</param>
	/// <param name="path">
	/// The path AFTER <c>/api/v1/</c> (e.g. <c>organizations</c> or
	/// <c>organizations/{orgId}/appliance/uplink/statuses</c>), optionally including a query string.
	/// A leading slash is ignored.
	/// </param>
	/// <param name="body">The raw request body to send, or null for none.</param>
	/// <param name="contentType">The Content-Type for the body. Defaults to application/json.</param>
	/// <param name="followPagination">
	/// When true (default), GET requests that return a JSON array and a <c>Link: rel=next</c>
	/// header are followed to completion and all pages are concatenated. Ignored for non-GET
	/// requests and non-array responses.
	/// </param>
	/// <param name="cancellationToken">The cancellation token.</param>
	/// <returns>A <see cref="MerakiQueryResponse"/> describing the (final) response and its parsed JSON.</returns>
	public async Task<MerakiQueryResponse> QueryAsync(
		HttpMethod method,
		string path,
		string? body = null,
		string? contentType = "application/json",
		bool followPagination = true,
		CancellationToken cancellationToken = default)
	{
		ArgumentNullException.ThrowIfNull(method);

		if (string.IsNullOrWhiteSpace(path))
		{
			throw new ArgumentException("The query path must not be null or whitespace.", nameof(path));
		}

		// The BaseAddress is https://api.{domain}/api/v1 with NO trailing slash, and the
		// /api/v1 segment must be preserved. Relative-Uri combination would drop it, so build
		// the absolute URI explicitly.
		var baseAddress = _coreHttpClient.BaseAddress
			?? throw new InvalidOperationException("The Meraki client core HttpClient has no BaseAddress.");
		var requestUri = BuildRequestUri(baseAddress, path);

		JArray? aggregate = null;
		var pageCount = 0;

		while (true)
		{
			using var request = BuildRequest(method, requestUri, body, contentType);

			// Read-only gating, auth, rate limiting and 429/5xx back-off all happen inside the handler.
			using var response = await _coreHttpClient
				.SendAsync(request, cancellationToken)
				.ConfigureAwait(false);

			pageCount++;

			var rawBody = await response.Content
				.ReadAsStringAsync(cancellationToken)
				.ConfigureAwait(false);

			var json = TryParseJson(rawBody);

			var nextUri = followPagination
				? AccumulatePage(response, method, json, ref aggregate)
				: null;
			if (nextUri is not null)
			{
				requestUri = nextUri;
				continue;
			}

			// Terminal page (or non-paginated response): build the result.
			return new MerakiQueryResponse
			{
				StatusCode = response.StatusCode,
				ReasonPhrase = response.ReasonPhrase,
				IsSuccessStatusCode = response.IsSuccessStatusCode,
				Headers = response.Headers,
				Json = aggregate ?? json,
				RawBody = rawBody,
				PageCount = pageCount
			};
		}
	}

	private static HttpRequestMessage BuildRequest(
		HttpMethod method,
		Uri requestUri,
		string? body,
		string? contentType)
	{
		var request = new HttpRequestMessage(method, requestUri);
		if (body is null)
		{
			return request;
		}

		request.Content = new StringContent(body);
		if (!string.IsNullOrWhiteSpace(contentType))
		{
			request.Content.Headers.ContentType = new MediaTypeHeaderValue(contentType);
		}

		return request;
	}

	/// <summary>
	/// Parses the body, returning null where it is empty or is not JSON. The caller can still
	/// inspect the raw body in that case.
	/// </summary>
	private static JToken? TryParseJson(string rawBody)
	{
		if (string.IsNullOrWhiteSpace(rawBody))
		{
			return null;
		}

		try
		{
			return JToken.Parse(rawBody);
		}
		catch (JsonException)
		{
			return null;
		}
	}

	/// <summary>
	/// Where the response is a page of a paginated array, appends it to <paramref name="aggregate"/>
	/// and returns the URI of the next page, or null where there is no next page to fetch.
	/// </summary>
	private static Uri? AccumulatePage(
		HttpResponseMessage response,
		HttpMethod method,
		JToken? json,
		ref JArray? aggregate)
	{
		if (!response.IsSuccessStatusCode || method != HttpMethod.Get || json is not JArray page)
		{
			return null;
		}

		// Accumulate array pages.
		aggregate ??= [];
		foreach (var item in page)
		{
			aggregate.Add(item);
		}

		return GetNextPageUri(response.Headers);
	}

	/// <summary>
	/// Builds the absolute request URI. The core BaseAddress is
	/// <c>https://api.{domain}/api/v1</c> with NO trailing slash, and the <c>/api/v1</c> segment
	/// must be preserved - relative-Uri combining would drop it - so the URI is built explicitly.
	/// </summary>
	internal static Uri BuildRequestUri(Uri baseAddress, string path)
		=> new(baseAddress.AbsoluteUri.TrimEnd('/') + "/" + path.TrimStart('/'));

	/// <summary>
	/// Extracts the absolute "rel=next" URL from a Meraki v1 Link header, or null if there is none.
	/// The next URL already carries the startingAfter / endingBefore cursor, so it can be
	/// requested directly (it stays on the same api domain, so it still flows through the
	/// authenticated, rate-limited handler).
	/// </summary>
	internal static Uri? GetNextPageUri(HttpResponseHeaders headers)
	{
		if (!headers.TryGetValues("Link", out var linkHeaders))
		{
			return null;
		}

		var linkHeader = linkHeaders.FirstOrDefault();
		if (linkHeader is null)
		{
			return null;
		}

		var nextLink = linkHeader
			.Split(',')
			.FirstOrDefault(link => link.Contains("rel=next"));
		if (nextLink is null)
		{
			return null;
		}

		var components = nextLink.Split(';');
		if (components.Length < 2)
		{
			return null;
		}

		var url = components[0].Trim().TrimStart('<').TrimEnd('>');
		return Uri.TryCreate(url, UriKind.Absolute, out var uri)
			? uri
			: null;
	}
}
#pragma warning restore S2333
