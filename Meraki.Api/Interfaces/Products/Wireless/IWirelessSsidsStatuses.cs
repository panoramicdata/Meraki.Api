namespace Meraki.Api.Interfaces.Products.Wireless;

public interface IWirelessSsidsStatuses
{
	/// <summary>
	/// List status information of all BSSIDs in your organization
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">The network id</param>
	/// <param name="networkIds">Optional parameter to filter the result set by the included set of network IDs</param>
	/// <param name="serials">A list of serial numbers. The returned devices will be filtered to only include these serials.</param>
	/// <param name="bssids">A list of BSSIDs. The returned devices will be filtered to only include these BSSIDs.</param>
	/// <param name="hideDisabled">If true, the returned devices will not include disabled SSIDs. (default: false)</param>
	/// <param name="perPage">The number of entries per page returned. Acceptable range is 3 - 500. Default is 100.</param>
	/// <param name="startingAfter">A token used by the server to indicate the start of the page. Often this is a timestamp or an ID but it is not limited to those. This parameter should not be defined by client applications. The link for the first, last, prev, or next page in the HTTP Link header should define it.</param>
	/// <param name="endingBefore">A token used by the server to indicate the end of the page. Often this is a timestamp or an ID but it is not limited to those. This parameter should not be defined by client applications. The link for the first, last, prev, or next page in the HTTP Link header should define it.</param>
	/// <param name="cancellationToken">The cancellation token</param>
	[ApiOperationId("getOrganizationWirelessSsidsStatusesByDevice")]
	[Get("/organizations/{organizationId}/wireless/ssids/statuses/byDevice")]
	Task<SsidsStatusesByDevice> GetOrganizationWirelessSsidsStatusesByDeviceAsync(
		string organizationId,
		[AliasAs("networkIds[]")] List<string> networkIds,
		[AliasAs("serials[]")] List<string> serials,
		[AliasAs("bssids[]")] List<string> bssids,
		bool hideDisabled,
		int? perPage,
		int? startingAfter,
		int? endingBefore,
		CancellationToken cancellationToken = default
		);
}
