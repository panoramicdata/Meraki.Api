using HtmlAgilityPack;
using System.Globalization;
using System.Net;

namespace Meraki.Api;

/// <summary>
/// A Meraki Dashboard API client!
/// </summary>
public partial class MerakiClient
{
	/// <summary>
	/// List all secure connect sites in this organization.
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call.</exception>
	/// <param name="organizationId">The organization id.</param>
	/// <param name="cancellationToken">Cancellation token to cancel the request.</param>
	public async Task<List<SecureConnectSite>> GetOrganizationSecureConnectSitesAllAsync(
			  string organizationId,
			  CancellationToken cancellationToken = default)
	{
		string ? startingAfter = null;
		string? endingBefore = null;
		const int pageSize = 1000;

		var items = new List<SecureConnectSite>();
		
		while (true)
		{
			var result = await Organizations.SecureConnect.Sites.GetOrganizationSecureConnectSitesAsync(
				organizationId,
				pageSize,
				startingAfter,
				endingBefore,
				cancellationToken
			);

			var page = result.Content?.Data;

			if (page is null || page.Count == 0)
			{
				break; // No more items
			}

			items.AddRange(page);
			
			// If we received less than the page size, we are done
			if (page.Count < pageSize)
			{
				break; // No more pages
			}

			// Set startingAfter to the ID of the last item in the current page
			startingAfter = page.Last().Id;
		}

		return items;
	}
		
}
