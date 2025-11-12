namespace Meraki.Api.Interfaces.Products.Appliance;

/// <summary>
/// I Appliance Security Events
/// </summary>
public interface IApplianceSecurityEvents
{
	/// <summary>
	/// List the security events for a network
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="t0">The beginning of the timespan for the data. The maximum lookback period is 365 days from today. (optional)</param>
	/// <param name="t1">The end of the timespan for the data. t1 can be a maximum of 365 days after t0. (optional)</param>
	/// <param name="timespan">The timespan for which the information will be fetched. If specifying timespan, do not specify parameters t0 and t1. The value must be in seconds and be less than or equal to 365 days. The default is 31 days. (optional)</param>
	/// <param name="perPage">The number of entries per page returned. Acceptable range is 3 - 1000. Default is 100. (optional)</param>
	/// <param name="startingAfter">A token used by the server to indicate the start of the page. Often this is a timestamp or an ID but it is not limited to those. This parameter should not be defined by client applications. The link for the first, last, prev, or next page in the HTTP Link header should define it. (optional)</param>
	/// <param name="endingBefore">A token used by the server to indicate the end of the page. Often this is a timestamp or an ID but it is not limited to those. This parameter should not be defined by client applications. The link for the first, last, prev, or next page in the HTTP Link header should define it. (optional)</param>
	/// <param name="cancellationToken"></param>
	[Get("/networks/{networkId}/appliance/security/events")]
	Task<List<SecurityEvent>> GetNetworkApplianceSecurityEventsAsync(
		string networkId,
		string t0 = null!,
		string t1 = null!,
		double? timespan = null,
		int? perPage = 1000,
		string startingAfter = null!,
		string endingBefore = null!,
		CancellationToken cancellationToken = default
		);
}
