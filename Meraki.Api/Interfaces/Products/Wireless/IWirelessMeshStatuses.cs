namespace Meraki.Api.Interfaces.Products.Wireless;

/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>
public interface IWirelessMeshStatuses
{
	/// <summary>
	/// Aggregated latency info for this network, grouped by clients
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="perPage">The number of entries per page returned. Acceptable range is 3 - 500. Default is 50.</param>
	/// <param name="startingAfter">A token used by the server to indicate the start of the page. Often this is a timestamp or an ID but it is not limited to those. This parameter should not be defined by client applications. The link for the first, last, prev, or next page in the HTTP Link header should define it.</param>
	/// <param name="endingBefore">A token used by the server to indicate the end of the page. Often this is a timestamp or an ID but it is not limited to those. This parameter should not be defined by client applications. The link for the first, last, prev, or next page in the HTTP Link header should define it.</param>
	[Get("/networks/{networkId}/wireless/meshStatuses")]
	Task<List<LatencyHistory>> GetNetworkWirelessMeshStatusesAsync(
		[AliasAs("networkId")] string networkId,
		[AliasAs("perPage")] int? perPage = 500,
		[AliasAs("startingAfter")] string? startingAfter = null,
		[AliasAs("endingBefore")] string? endingBefore = null,
		CancellationToken cancellationToken = default);
}
