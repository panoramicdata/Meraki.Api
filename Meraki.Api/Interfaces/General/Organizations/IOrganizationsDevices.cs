namespace Meraki.Api.Interfaces.General.Organizations;

public interface IOrganizationsDevices
{
	/// <summary>
	/// List the status of every Meraki device in the organization
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">The organization id</param>
	[Get("/organizations/{organizationId}/devices/statuses")]
	Task<List<OrganizationDeviceStatus>> GetDeviceStatusesAsync(
		[AliasAs("organizationId")] string organizationId,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Return the uplink loss and latency for every MX in the organization from at latest 2 minutes ago
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">The organization id</param>
	/// <param name="t0">The beginning of the timespan for the data. The maximum lookback period is 365 days from today. (optional)</param>
	/// <param name="t1">The end of the timespan for the data. t1 can be a maximum of 5 minutes after t0. The latest possible time that t1 can be is 2 minutes into the past. (optional)</param>
	/// <param name="timespan">The timespan for which the information will be fetched. If specifying timespan, do not specify parameters t0 and t1. The value must be in seconds and be less than or equal to 5 minutes. The default is 5 minutes. (optional)</param>
	/// <param name="uplink">Optional filter for a specific WAN uplink. Valid uplinks are wan1, wan2, cellular. Default will return all uplinks. (optional)</param>
	/// <param name="ip">Optional filter for a specific destination IP. Default will return all destination IPs. (optional)</param>
	[Get("/organizations/{organizationId}/devices/uplinksLossAndLatency")]
	Task<List<UplinksLossAndLatencyResponse>> GetUplinksLossAndLatencyAsync(
		[AliasAs("organizationId")] string organizationId,
		[AliasAs("t0")] string t0 = null!,
		[AliasAs("t1")] string t1 = null!,
		[AliasAs("timespan")] double? timespan = null,
		[AliasAs("uplink")] string uplink = null!,
		[AliasAs("ip")] string ip = null!,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// List the devices in an organization
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">The organization id</param>
	/// <param name="perPage">The number of entries per page returned. Acceptable range is 3 - 1000. Default is 1000. (optional)</param>
	/// <param name="startingAfter">A token used by the server to indicate the start of the page. Often this is a timestamp or an ID but it is not limited to those. This parameter should not be defined by client applications. The link for the first, last, prev, or next page in the HTTP Link header should define it. (optional)</param>
	/// <param name="endingBefore">A token used by the server to indicate the end of the page. Often this is a timestamp or an ID but it is not limited to those. This parameter should not be defined by client applications. The link for the first, last, prev, or next page in the HTTP Link header should define it. (optional)</param>
	/// <param name="configurationUpdatedAfter">Filter results by whether or not the device&#39;s configuration has been updated after the given timestamp (optional)</param>
	[Get("/organizations/{organizationId}/devices")]
	Task<List<OrganizationDevice>> GetDevicesPagedAsync(
		[AliasAs("organizationId")] string organizationId,
		[AliasAs("perPage")] int? perPage = 1000,
		[AliasAs("startingAfter")] string startingAfter = null!,
		[AliasAs("endingBefore")] string endingBefore = null!,
		[AliasAs("configurationUpdatedAfter")] string configurationUpdatedAfter = null!,
		CancellationToken cancellationToken = default);
}
