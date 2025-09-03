﻿namespace Meraki.Api;

/// <summary>
/// This file contains paging logic
/// </summary>
public partial class MerakiClient
{
	public async Task<List<T>> GetAllAsync<T>(
		Func<int, string?, string?, CancellationToken, Task<List<T>>> pageFactoryAsync,
		int perPage,
		CancellationToken cancellationToken)
	{
		var allEntries = new List<T>();
		var finished = false;
		string? startingAfter = null;
		string? endingBefore = null;
		while (!finished)
		{
			var pageResponse = await
				pageFactoryAsync(perPage, startingAfter, endingBefore, cancellationToken).ConfigureAwait(false);

			allEntries.AddRange(pageResponse);

			// Check the Link response header
			if (LastResponseHeaders is not null && LastResponseHeaders.TryGetValues("Link", out var linkHeaders))
			{
				// We found a Link header
				var linkHeader = linkHeaders.FirstOrDefault();
				if (linkHeader != null)
				{
					var links = linkHeader.Split(',');
					// We need to get the next link, it might have startingAfter or EndingBefore defined
					var nextLink = links.SingleOrDefault(link => link.Contains("rel=next"));
					if (nextLink != null)
					{
						var nextLinkComponents = nextLink.Split(';');
						if (nextLinkComponents.Length == 2)
						{
							// Get the url component and remove the < > wrapper
							var nextLinkUrl = nextLinkComponents[0].Trim().TrimStart('<').TrimEnd('>');
							var myUri = new Uri(nextLinkUrl);
							var nameValueCollection = HttpUtility.ParseQueryString(myUri.Query);
							// try and get the startingAfter value, otherwise the endingBefore value
							startingAfter = nameValueCollection.Get("startingAfter");
							if (startingAfter is null)
							{
								endingBefore = nameValueCollection.Get("endingBefore");
							}

							continue;
						}
					}
				}
			}

			// There was no Link header so we're finished
			finished = true;
		}

		return allEntries;
	}

	public async Task<List<T>> GetAllAsync<T>(
		Func<string?, string?, CancellationToken, Task<List<T>>> pageFactoryAsync,
		CancellationToken cancellationToken)
	{
		var allEntries = new List<T>();
		var finished = false;
		string? startingAfter = null;
		string? endingBefore = null;
		while (!finished)
		{
			var pageResponse = await
				pageFactoryAsync(startingAfter, endingBefore, cancellationToken).ConfigureAwait(false);

			allEntries.AddRange(pageResponse);

			// Check the Link response header
			if (LastResponseHeaders is not null && LastResponseHeaders.TryGetValues("Link", out var linkHeaders))
			{
				// We found a Link header
				var linkHeader = linkHeaders.FirstOrDefault();
				if (linkHeader != null)
				{
					var links = linkHeader.Split(',');
					// We need to get the next link, it might have startingAfter or EndingBefore defined
					var nextLink = links.SingleOrDefault(link => link.Contains("rel=next"));
					if (nextLink != null)
					{
						var nextLinkComponents = nextLink.Split(';');
						if (nextLinkComponents.Length == 2)
						{
							// Get the url component and remove the < > wrapper
							var nextLinkUrl = nextLinkComponents[0].Trim().TrimStart('<').TrimEnd('>');
							var myUri = new Uri(nextLinkUrl);
							var nameValueCollection = HttpUtility.ParseQueryString(myUri.Query);
							// try and get the startingAfter value, otherwise the endingBefore value
							startingAfter = nameValueCollection.Get("startingAfter");
							if (startingAfter is null)
							{
								endingBefore = nameValueCollection.Get("endingBefore");
							}

							continue;
						}
					}
				}
			}

			// There was no Link header so we're finished
			finished = true;
		}

		return allEntries;
	}

	public static async Task<List<T>> GetAllAsync<T>(
#pragma warning disable CS3001 // Argument type is not CLS-compliant
		Func<string?, string?, CancellationToken, Task<ApiResponse<List<T>>>> pageFactoryAsync,
#pragma warning restore CS3001 // Argument type is not CLS-compliant
		CancellationToken cancellationToken)
	{
		var allEntries = new List<T>();
		var finished = false;
		string? startingAfter = null;
		string? endingBefore = null;
		while (!finished)
		{
			var pageResponse = await
				pageFactoryAsync(startingAfter, endingBefore, cancellationToken).ConfigureAwait(false);

			// Refit traps exceptions into Error when using ApiResponse
			if (pageResponse.Error is not null)
			{
				throw pageResponse.Error;
			}

			allEntries.AddRange(pageResponse.Content);

			// Check the Link response header
			if (pageResponse.Headers is not null && pageResponse.Headers.TryGetValues("Link", out var linkHeaders))
			{
				// We found a Link header
				var linkHeader = linkHeaders.FirstOrDefault();
				if (linkHeader != null)
				{
					var links = linkHeader.Split(',');
					var nextLink = links.SingleOrDefault(link => link.Contains("rel=next"));
					if (nextLink != null)
					{
						var nextLinkComponents = nextLink.Split(';');
						if (nextLinkComponents.Length == 2)
						{
							// Get the url component and remove the < > wrapper
							var nextLinkUrl = nextLinkComponents[0].Trim().TrimStart('<').TrimEnd('>');
							var myUri = new Uri(nextLinkUrl);
							var nameValueCollection = HttpUtility.ParseQueryString(myUri.Query);
							// try and get the startingAfter value, otherwise the endingBefore value
							startingAfter = nameValueCollection.Get("startingAfter");
							if (startingAfter is null)
							{
								endingBefore = nameValueCollection.Get("endingBefore");
							}

							continue;
						}
					}
				}
			}

			// There was no Link header so we're finished
			finished = true;
		}

		return allEntries;
	}

	public static async Task<List<T>> GetAllAsync<T>(
#pragma warning disable CS3001 // Argument type is not CLS-compliant
		Func<string?, string?, string?, string?, double?, CancellationToken, Task<ApiResponse<List<T>>>> pageFactoryAsync,
#pragma warning restore CS3001 // Argument type is not CLS-compliant
		string? t0 = null,
		string? t1 = null,
		double? timespan = null,
		CancellationToken cancellationToken = default)
	{
		var allEntries = new List<T>();
		var finished = false;
		string? startingAfter = null;
		string? endingBefore = null;
		while (!finished)
		{
			var pageResponse = await
				pageFactoryAsync(startingAfter, endingBefore, t0, t1, timespan, cancellationToken).ConfigureAwait(false);

			// Refit traps exceptions into Error when using ApiResponse
			if (pageResponse.Error is not null)
			{
				throw pageResponse.Error;
			}

			allEntries.AddRange(pageResponse.Content);

			// Check the Link response header
			if (pageResponse.Headers is not null && pageResponse.Headers.TryGetValues("Link", out var linkHeaders))
			{
				// We found a Link header
				var linkHeader = linkHeaders.FirstOrDefault();
				if (linkHeader != null)
				{
					var links = linkHeader.Split(',');
					var nextLink = links.SingleOrDefault(link => link.Contains("rel=next"));
					if (nextLink != null)
					{
						var nextLinkComponents = nextLink.Split(';');
						if (nextLinkComponents.Length == 2)
						{
							// Get the url component and remove the < > wrapper
							var nextLinkUrl = nextLinkComponents[0].Trim().TrimStart('<').TrimEnd('>');
							var myUri = new Uri(nextLinkUrl);
							var nameValueCollection = HttpUtility.ParseQueryString(myUri.Query);
							// try and get the startingAfter value, otherwise the endingBefore value
							startingAfter = nameValueCollection.Get("startingAfter");
							if (startingAfter is null)
							{
								endingBefore = nameValueCollection.Get("endingBefore");
							}

							continue;
						}
					}
				}
			}

			// There was no Link header so we're finished
			finished = true;
		}

		return allEntries;
	}

	public static async Task<List<T>> GetAllAsync<T>(
#pragma warning disable CS3001 // Argument type is not CLS-compliant
	Func<int?, string?, string?, CancellationToken, Task<ApiResponse<List<T>>>> pageFactoryAsync,
#pragma warning restore CS3001 // Argument type is not CLS-compliant
	int perPage,
	CancellationToken cancellationToken)
	{
		var allEntries = new List<T>();
		var finished = false;
		string? startingAfter = null;
		string? endingBefore = null;
		while (!finished)
		{
			var pageResponse = await
				pageFactoryAsync(perPage, startingAfter, endingBefore, cancellationToken).ConfigureAwait(false);

			// Refit traps exceptions into Error when using ApiResponse
			if (pageResponse.Error is not null)
			{
				throw pageResponse.Error;
			}

			allEntries.AddRange(pageResponse.Content);

			// Check the Link response header
			if (pageResponse.Headers is not null && pageResponse.Headers.TryGetValues("Link", out var linkHeaders))
			{
				// We found a Link header
				var linkHeader = linkHeaders.FirstOrDefault();
				if (linkHeader != null)
				{
					var links = linkHeader.Split(',');
					var nextLink = links.SingleOrDefault(link => link.Contains("rel=next"));
					if (nextLink != null)
					{
						var nextLinkComponents = nextLink.Split(';');
						if (nextLinkComponents.Length == 2)
						{
							// Get the url component and remove the < > wrapper
							var nextLinkUrl = nextLinkComponents[0].Trim().TrimStart('<').TrimEnd('>');
							var myUri = new Uri(nextLinkUrl);
							var nameValueCollection = HttpUtility.ParseQueryString(myUri.Query);
							// try and get the startingAfter value, otherwise the endingBefore value
							startingAfter = nameValueCollection.Get("startingAfter");
							if (startingAfter is null)
							{
								endingBefore = nameValueCollection.Get("endingBefore");
							}

							continue;
						}
					}
				}
			}

			// There was no Link header so we're finished
			finished = true;
		}

		return allEntries;
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
	public static async Task<List<TModel>> GetAllFromResponsePropertyAsync<TResponse, TModel>(
#pragma warning disable CS3001 // Argument type is not CLS-compliant
	Func<string?, string?, CancellationToken, Task<ApiResponse<TResponse>>> pageFactoryAsync,
	Func<ApiResponse<TResponse>, List<TModel>> propertyFunction,
#pragma warning restore CS3001 // Argument type is not CLS-compliant
	CancellationToken cancellationToken)
	{
		var allEntries = new List<TModel>();
		var finished = false;
		string? startingAfter = null;
		string? endingBefore = null;
		while (!finished)
		{
			var pageResponse = await
			pageFactoryAsync(startingAfter, endingBefore, cancellationToken).ConfigureAwait(false);

			var entries = propertyFunction(pageResponse);

			allEntries.AddRange(entries);

			// Check the Link response header
			if (pageResponse.Headers is not null && pageResponse.Headers.TryGetValues("Link", out var linkHeaders))
			{
				// We found a Link header
				var linkHeader = linkHeaders.FirstOrDefault();
				if (linkHeader != null)
				{
					var links = linkHeader.Split(',');
					var nextLink = links.SingleOrDefault(link => link.Contains("rel=next"));
					if (nextLink != null)
					{
						var nextLinkComponents = nextLink.Split(';');
						if (nextLinkComponents.Length == 2)
						{
							// Get the url component and remove the < > wrapper
							var nextLinkUrl = nextLinkComponents[0].Trim().TrimStart('<').TrimEnd('>');
							var myUri = new Uri(nextLinkUrl);
							var nameValueCollection = HttpUtility.ParseQueryString(myUri.Query);

							// try and get the startingAfter and/or endingBefore from the headers
							startingAfter = nameValueCollection.Get("startingAfter");
							endingBefore = nameValueCollection.Get("endingBefore");

							continue;
						}
					}
				}
			}

			// There was no Link header so we're finished
			finished = true;
		}

		return allEntries;
	}
}
