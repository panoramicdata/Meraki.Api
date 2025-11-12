namespace Meraki.Api.Extensions;

/// <summary>
/// Extension methods for IOrganization Devices
/// </summary>

public static class IOrganizationDevicesExtensions
{
	/// <summary>
	/// Returns a historical log of all commands.
	/// </summary>
	/// <param name="organizationDevices"></param>
	/// <param name="organizationId">Organization ID.</param>
	/// <param name="t0">The beginning of the timespan for the data. The maximum lookback period is 30 days from today.</param>
	/// <param name="t1">The end of the timespan for the data. t1 can be a maximum of 30 days after t0.</param>
	/// <param name="timespan">The timespan for which the information will be fetched. If specifying timespan, do not specify parameters t0 and t1. The value must be in seconds and be less than or equal to 30 days. The default is 1 day.</param>
	/// <param name="serials">Optional parameter to filter by serial numbers.</param>
	/// <param name="productTypes">Optional parameter to filter by product types.</param>
	/// <param name="networkIds">Optional parameter to filter by network IDs.</param>
	/// <param name="statuses">Optional parameter to filter by device statuses.</param>
	/// <param name="cancellationToken">Cancellation token.</param>
	/// <returns>A list of <see cref="SensorCommand"/>.</returns>
	public static Task<List<OrganizationDevicesAvailabilitiesChangeEvent>> GetOrganizationDevicesAvailabilitiesChangeHistoryAllAsync(
		this OrganizationsDeviceSection organizationDevices,
		string organizationId,
		string? t0 = null,
		string? t1 = null,
		int? timespan = null,
		List<string>? serials = null,
		List<string>? productTypes = null,
		List<string>? networkIds = null,
		List<string>? statuses = null,
		CancellationToken cancellationToken = default)
		=> MerakiClient.GetAllAsync(
				(startingAfter, endingBefore, cancellationToken)
				=> organizationDevices.Devices.GetOrganizationDevicesAvailabilitiesChangeHistoryApiResponseAsync(
					organizationId,
					1000,
					t0,
					t1,
					timespan,
					startingAfter,
					endingBefore,
					serials,
					productTypes,
					networkIds,
					statuses,
					cancellationToken
				),
				cancellationToken
			);
}
