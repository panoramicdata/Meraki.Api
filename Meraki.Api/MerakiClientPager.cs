using System.Collections.Specialized;

namespace Meraki.Api;

/// <summary>
/// This file contains paging logic
/// </summary>
// Codacy analyses each file on its own, so it cannot see the other parts of this class and reports
// 'partial' as gratuitous (S2333). Both are false positives: the remaining parts are emitted by
// RefitClassSourceGenerator, or live in the sibling MerakiClient files.
#pragma warning disable S2333
public partial class MerakiClient
{
	/// <summary>
	/// Reads the query string of the "rel=next" link in the response headers, or null where there
	/// is no next page to fetch. Throws <see cref="PaginationException"/> where a next page is
	/// advertised but cannot be followed; see <see cref="GetNextPageUri"/>.
	/// </summary>
	private static NameValueCollection? TryGetNextPageQuery(HttpHeaders? headers)
	{
		var nextPageUri = GetNextPageUri(headers);
		return nextPageUri is null
			? null
			: HttpUtility.ParseQueryString(nextPageUri.Query);
	}

	/// <summary>
	/// Advances the pagination cursor to the next page, returning false where there is no next page.
	/// </summary>
	/// <remarks>
	/// endingBefore is only read where the next link carries no startingAfter, so a cursor set on an
	/// earlier page is left in place rather than cleared.
	/// </remarks>
	private static bool TryAdvanceCursor(HttpHeaders? headers, ref string? startingAfter, ref string? endingBefore)
	{
		var query = TryGetNextPageQuery(headers);
		if (query is null)
		{
			return false;
		}

		// try and get the startingAfter value, otherwise the endingBefore value
		startingAfter = query.Get("startingAfter");
		if (startingAfter is null)
		{
			endingBefore = query.Get("endingBefore");
		}

		return true;
	}

	/// <summary>
	/// Advances the pagination cursor to the next page, taking both cursor values from the next link.
	/// </summary>
	private static bool TryAdvanceBothCursors(HttpHeaders? headers, ref string? startingAfter, ref string? endingBefore)
	{
		var query = TryGetNextPageQuery(headers);
		if (query is null)
		{
			return false;
		}

		// try and get the startingAfter and/or endingBefore from the headers
		startingAfter = query.Get("startingAfter");
		endingBefore = query.Get("endingBefore");

		return true;
	}

	/// <summary>
	/// Refit traps exceptions into Error when using ApiResponse, so surface them here.
	/// </summary>
	private static List<T> ReadPage<T>(ApiResponse<List<T>> pageResponse)
		=> pageResponse.Error is not null
			? throw pageResponse.Error
			: pageResponse.Content ?? [];

	/// <summary>
	/// Retrieves all items using pagination with a per-page count parameter
	/// </summary>
	/// <typeparam name="T">The type of items to retrieve</typeparam>
	/// <param name="pageFactoryAsync">The function to call for each page of results</param>
	/// <param name="perPage">The number of items per page</param>
	/// <param name="cancellationToken">The cancellation token</param>
	/// <returns>A list of all items</returns>
	/// <remarks>
	/// Fetches every page before returning and is <b>all-or-nothing</b>: if any page fails, the
	/// exception propagates and the pages already fetched are discarded. An exception therefore means
	/// "no data was returned", never "here is what was fetched so far". In particular, a 404 from a
	/// genuinely empty collection and a 404 on the last of many pages reach the caller identically, so
	/// do not treat an exception as an empty result; retry or fail instead. See
	/// <see href="https://github.com/panoramicdata/Meraki.Api/issues/355">issue 355</see>.
	/// </remarks>
	/// <exception cref="PaginationException">A page advertised a next page that could not be followed.</exception>
	public async Task<List<T>> GetAllAsync<T>(
		Func<int, string?, string?, CancellationToken, Task<List<T>>> pageFactoryAsync,
		int perPage,
		CancellationToken cancellationToken)
	{
		var allEntries = new List<T>();
		string? startingAfter = null;
		string? endingBefore = null;

		while (true)
		{
			var pageResponse = await
				pageFactoryAsync(perPage, startingAfter, endingBefore, cancellationToken).ConfigureAwait(false);

			allEntries.AddRange(pageResponse);

			// There was no Link header so we're finished
			if (!TryAdvanceCursor(LastResponseHeaders, ref startingAfter, ref endingBefore))
			{
				return allEntries;
			}
		}
	}

	/// <summary>
	/// Retrieves all items using pagination with startingAfter/endingBefore parameters
	/// </summary>
	/// <typeparam name="T">The type of items to retrieve</typeparam>
	/// <param name="pageFactoryAsync">The function to call for each page of results</param>
	/// <param name="cancellationToken">The cancellation token</param>
	/// <returns>A list of all items</returns>
	/// <remarks>
	/// Fetches every page before returning and is <b>all-or-nothing</b>: if any page fails, the
	/// exception propagates and the pages already fetched are discarded. An exception therefore means
	/// "no data was returned", never "here is what was fetched so far". In particular, a 404 from a
	/// genuinely empty collection and a 404 on the last of many pages reach the caller identically, so
	/// do not treat an exception as an empty result; retry or fail instead. See
	/// <see href="https://github.com/panoramicdata/Meraki.Api/issues/355">issue 355</see>.
	/// </remarks>
	/// <exception cref="PaginationException">A page advertised a next page that could not be followed.</exception>
	public async Task<List<T>> GetAllAsync<T>(
		Func<string?, string?, CancellationToken, Task<List<T>>> pageFactoryAsync,
		CancellationToken cancellationToken)
	{
		var allEntries = new List<T>();
		string? startingAfter = null;
		string? endingBefore = null;

		while (true)
		{
			var pageResponse = await
				pageFactoryAsync(startingAfter, endingBefore, cancellationToken).ConfigureAwait(false);

			allEntries.AddRange(pageResponse);

			// There was no Link header so we're finished
			if (!TryAdvanceCursor(LastResponseHeaders, ref startingAfter, ref endingBefore))
			{
				return allEntries;
			}
		}
	}

	/// <summary>
	/// Retrieves all items using pagination with ApiResponse wrapper
	/// </summary>
	/// <typeparam name="T">The type of items to retrieve</typeparam>
	/// <param name="pageFactoryAsync">The function to call for each page of results</param>
	/// <param name="cancellationToken">The cancellation token</param>
	/// <returns>A list of all items</returns>
	/// <remarks>
	/// Fetches every page before returning and is <b>all-or-nothing</b>: if any page fails, the
	/// exception propagates and the pages already fetched are discarded. An exception therefore means
	/// "no data was returned", never "here is what was fetched so far". In particular, a 404 from a
	/// genuinely empty collection and a 404 on the last of many pages reach the caller identically, so
	/// do not treat an exception as an empty result; retry or fail instead. See
	/// <see href="https://github.com/panoramicdata/Meraki.Api/issues/355">issue 355</see>.
	/// </remarks>
	/// <exception cref="PaginationException">A page advertised a next page that could not be followed.</exception>
	public static async Task<List<T>> GetAllAsync<T>(
#pragma warning disable CS3001 // Argument type is not CLS-compliant
		Func<string?, string?, CancellationToken, Task<ApiResponse<List<T>>>> pageFactoryAsync,
#pragma warning restore CS3001 // Argument type is not CLS-compliant
		CancellationToken cancellationToken)
	{
		var allEntries = new List<T>();
		string? startingAfter = null;
		string? endingBefore = null;

		while (true)
		{
			var pageResponse = await
				pageFactoryAsync(startingAfter, endingBefore, cancellationToken).ConfigureAwait(false);

			allEntries.AddRange(ReadPage(pageResponse));

			// There was no Link header so we're finished
			if (!TryAdvanceCursor(pageResponse.Headers, ref startingAfter, ref endingBefore))
			{
				return allEntries;
			}
		}
	}

	/// <summary>
	/// Retrieves all items using pagination with time-based parameters
	/// </summary>
	/// <typeparam name="T">The type of items to retrieve</typeparam>
	/// <param name="pageFactoryAsync">The function to call for each page of results</param>
	/// <param name="t0">The beginning of the timespan</param>
	/// <param name="t1">The end of the timespan</param>
	/// <param name="timeSpan">The timespan duration</param>
	/// <param name="cancellationToken">The cancellation token</param>
	/// <returns>A list of all items</returns>
	/// <remarks>
	/// Fetches every page before returning and is <b>all-or-nothing</b>: if any page fails, the
	/// exception propagates and the pages already fetched are discarded. An exception therefore means
	/// "no data was returned", never "here is what was fetched so far". In particular, a 404 from a
	/// genuinely empty collection and a 404 on the last of many pages reach the caller identically, so
	/// do not treat an exception as an empty result; retry or fail instead. See
	/// <see href="https://github.com/panoramicdata/Meraki.Api/issues/355">issue 355</see>.
	/// </remarks>
	/// <exception cref="PaginationException">A page advertised a next page that could not be followed.</exception>
	public static async Task<List<T>> GetAllAsync<T>(
#pragma warning disable CS3001 // Argument type is not CLS-compliant
		Func<string?, string?, string?, string?, double?, CancellationToken, Task<ApiResponse<List<T>>>> pageFactoryAsync,
#pragma warning restore CS3001 // Argument type is not CLS-compliant
		string? t0 = null,
		string? t1 = null,
		double? timeSpan = null,
		CancellationToken cancellationToken = default)
	{
		var allEntries = new List<T>();
		string? startingAfter = null;
		string? endingBefore = null;

		while (true)
		{
			var pageResponse = await
				pageFactoryAsync(startingAfter, endingBefore, t0, t1, timeSpan, cancellationToken).ConfigureAwait(false);

			allEntries.AddRange(ReadPage(pageResponse));

			// There was no Link header so we're finished
			if (!TryAdvanceCursor(pageResponse.Headers, ref startingAfter, ref endingBefore))
			{
				return allEntries;
			}
		}
	}

	/// <summary>
	/// Retrieves all items using pagination with per-page count and ApiResponse wrapper
	/// </summary>
	/// <typeparam name="T">The type of items to retrieve</typeparam>
	/// <param name="pageFactoryAsync">The function to call for each page of results</param>
	/// <param name="perPage">The number of items per page</param>
	/// <param name="cancellationToken">The cancellation token</param>
	/// <returns>A list of all items</returns>
	/// <remarks>
	/// Fetches every page before returning and is <b>all-or-nothing</b>: if any page fails, the
	/// exception propagates and the pages already fetched are discarded. An exception therefore means
	/// "no data was returned", never "here is what was fetched so far". In particular, a 404 from a
	/// genuinely empty collection and a 404 on the last of many pages reach the caller identically, so
	/// do not treat an exception as an empty result; retry or fail instead. See
	/// <see href="https://github.com/panoramicdata/Meraki.Api/issues/355">issue 355</see>.
	/// </remarks>
	/// <exception cref="PaginationException">A page advertised a next page that could not be followed.</exception>
	public static async Task<List<T>> GetAllAsync<T>(
#pragma warning disable CS3001 // Argument type is not CLS-compliant
		Func<int?, string?, string?, CancellationToken, Task<ApiResponse<List<T>>>> pageFactoryAsync,
#pragma warning restore CS3001 // Argument type is not CLS-compliant
		int perPage,
		CancellationToken cancellationToken)
	{
		var allEntries = new List<T>();
		string? startingAfter = null;
		string? endingBefore = null;

		while (true)
		{
			var pageResponse = await
				pageFactoryAsync(perPage, startingAfter, endingBefore, cancellationToken).ConfigureAwait(false);

			allEntries.AddRange(ReadPage(pageResponse));

			// There was no Link header so we're finished
			if (!TryAdvanceCursor(pageResponse.Headers, ref startingAfter, ref endingBefore))
			{
				return allEntries;
			}
		}
	}

	/// <summary>
	/// Retrieves all items from a paginated API response where the data is accessed via a custom accessor function.
	/// </summary>
	/// <typeparam name="TResponse">The type of the API response object.</typeparam>
	/// <typeparam name="TModel">The type of the model to return in the list.</typeparam>
	/// <param name="pageFactoryAsync">A function that asynchronously retrieves a page of data, given pagination parameters and a cancellation token.</param>
	/// <param name="propertyFunction">A function that extracts a list of models from the API response.</param>
	/// <param name="cancellationToken">A cancellation token to observe while waiting for the task to complete.</param>
	/// <returns>A task that represents the asynchronous operation. The task result contains a list of all models retrieved from all pages.</returns>
	/// <remarks>
	/// Fetches every page before returning and is <b>all-or-nothing</b>: if any page fails, the
	/// exception propagates and the pages already fetched are discarded. An exception therefore means
	/// "no data was returned", never "here is what was fetched so far". In particular, a 404 from a
	/// genuinely empty collection and a 404 on the last of many pages reach the caller identically, so
	/// do not treat an exception as an empty result; retry or fail instead. See
	/// <see href="https://github.com/panoramicdata/Meraki.Api/issues/355">issue 355</see>.
	/// </remarks>
	/// <exception cref="PaginationException">A page advertised a next page that could not be followed.</exception>
	public static async Task<List<TModel>> GetAllFromResponsePropertyAsync<TResponse, TModel>(
#pragma warning disable CS3001 // Argument type is not CLS-compliant
		Func<string?, string?, CancellationToken, Task<ApiResponse<TResponse>>> pageFactoryAsync,
		Func<ApiResponse<TResponse>, List<TModel>> propertyFunction,
#pragma warning restore CS3001 // Argument type is not CLS-compliant
		CancellationToken cancellationToken)
	{
		var allEntries = new List<TModel>();
		string? startingAfter = null;
		string? endingBefore = null;

		while (true)
		{
			var pageResponse = await
				pageFactoryAsync(startingAfter, endingBefore, cancellationToken).ConfigureAwait(false);

			allEntries.AddRange(propertyFunction(pageResponse));

			// There was no Link header so we're finished
			if (!TryAdvanceBothCursors(pageResponse.Headers, ref startingAfter, ref endingBefore))
			{
				return allEntries;
			}
		}
	}
}
#pragma warning restore S2333
