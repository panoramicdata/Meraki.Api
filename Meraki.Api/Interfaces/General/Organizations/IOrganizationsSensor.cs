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
}
