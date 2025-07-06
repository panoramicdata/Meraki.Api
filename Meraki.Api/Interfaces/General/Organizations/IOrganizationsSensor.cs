namespace Meraki.Api.Interfaces.General.Organizations;
public interface IOrganizationsSensor
{
	/// <summary>
	/// Return a list of sensor alert events
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("getOrganizationSensorAlerts")]
	[Get("/organizations/{organizationId}/sensor/alerts")]
	Task<List<OrganizationsSensorAlert>> GetOrganizationSensorAlertsAsync(
		string organizationId,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Return all reported readings from sensors in a given timespan, summarized as a series of intervals, sorted by interval start time in descending order
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("getOrganizationSensorReadingsHistoryByInterval")]
	[Get("/organizations/{organizationId}/sensor/readings/history/byInterval")]
	Task<List<OrganizationSensorReadingsHistoryByIntervalItem>> GetOrganizationSensorReadingsHistoryByIntervalAsync(string organizationId, CancellationToken cancellationToken = default);
}
