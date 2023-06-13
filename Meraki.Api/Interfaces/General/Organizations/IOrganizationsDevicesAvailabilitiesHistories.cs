namespace Meraki.Api.Interfaces.General.Organizations;

public interface IOrganizationsDevicesAvailabilitiesHistories
{
	/// <summary>
	/// List the availability history information for devices in an organization.
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">Organization ID</param>
	/// <param name="t0">The beginning of the timespan for the data. The maximum lookback period is 14 days from today.</param>
	/// <param name="t1">The end of the timespan for the data. t1 can be a maximum of 14 days after t0.</param>
	/// <param name="timespan">The timespan for which the information will be fetched. If specifying timespan, do not specify parameters t0 and t1. The value must be in seconds and be less than or equal to 14 days. The default is 1 day.</param>
	/// <param name="serials">Optional parameter to filter device availabilities history by device serial numbers</param>
	/// <param name="productTypes">Optional parameter to filter device availabilities history by device product types</param>
	/// <param name="networkIds">Optional parameter to filter device availabilities history by network IDs</param>
	[ApiOperationId("getOrganizationDevicesAvailabilitiesHistory")]
	[Get("/organizations/{organizationId}/devices/availabilities/history")]
	Task<List<DeviceAvailabilityHistory>> GetOrganizationDevicesAvailabilitiesHistory(
		string organizationId,
		string? t0 = null,
		string? t1 = null,
		double? timespan = null,
		[AliasAs("serials[]")] List<string>? serials = null,
		[AliasAs("productTypes[]")] List<string>? productTypes = null,
		[AliasAs("networkIds[]")] List<string>? networkIds = null,
		CancellationToken cancellationToken = default);
}
