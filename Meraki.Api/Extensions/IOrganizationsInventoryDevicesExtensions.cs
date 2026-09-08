namespace Meraki.Api.Extensions;

/// <summary>
/// Extension methods for IOrganizations Inventory Devices
/// </summary>

public static class IOrganizationsInventoryDevicesExtensions
{
	/// <summary>
	/// Get all networks that the user has privileges on in an organization
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationInventoryDevices"></param>
	/// <param name="organizationId">The organization id</param>
	/// <param name="usedState">Filter results by used or unused inventory. Accepted values are "used" or "unused".</param>
	/// <param name="search">Search for devices in inventory based on serial number, mac address, or model.</param>
	/// <param name="macs"></param>
	/// <param name="networkIds"></param>
	/// <param name="serials"></param>
	/// <param name="models"></param>
	/// <param name="orderNumbers"></param>
	/// <param name="tags"></param>
	/// <param name="tagsFilterType"></param>
	/// <param name="productTypes"></param>
	/// <param name="cancellationToken"></param>
	/// <remarks>
	/// Fetches every page before returning and is <b>all-or-nothing</b>: if any page fails, the
	/// exception propagates and the pages already fetched are discarded. An exception therefore means
	/// "no data was returned", never "here is what was fetched so far". In particular, a 404 from a
	/// genuinely empty collection and a 404 on the last of many pages reach the caller identically, so
	/// do not treat an exception as an empty result; retry or fail instead. See
	/// <see href="https://github.com/panoramicdata/Meraki.Api/issues/355">issue 355</see>.
	/// </remarks>
	public static Task<List<InventoryDevice>> GetOrganizationInventoryDevicesAllAsync(
		this IOrganizationsInventoryDevices organizationInventoryDevices,
		string organizationId,
		string? usedState = null,
		string? search = null,
		List<string>? macs = null,
		List<string>? networkIds = null,
		List<string>? serials = null,
		List<string>? models = null,
		List<string>? orderNumbers = null,
		List<string>? tags = null,
		TagsFilterType? tagsFilterType = null,
		List<ProductType>? productTypes = null,
		CancellationToken cancellationToken = default)
		=> MerakiClient.GetAllAsync(
				(startingAfter, endingBefore, cancellationToken)
				=> organizationInventoryDevices.GetOrganizationInventoryDevicesApiResponseAsync(
						organizationId,
						startingAfter,
						endingBefore,
						usedState,
						search,
						macs,
						networkIds,
						serials,
						models,
						orderNumbers,
						tags,
						tagsFilterType,
						productTypes,
						cancellationToken
					),
					cancellationToken
			);
}
