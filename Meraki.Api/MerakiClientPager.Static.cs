using System.Collections.Specialized;

namespace Meraki.Api;

// Codacy analyses each file on its own, so it reports 'partial' as gratuitous (S2333) and the static-only parts as S1118. The other parts live in sibling files.
#pragma warning disable S2333, S1118
public partial class MerakiClient
{
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
