namespace Meraki.Api.Interfaces.General.Organizations;

/// <summary>
/// Floor Plans Auto Locate Interface
/// </summary>
public interface IOrganizationsFloorPlansAutoLocate
{
	/// <summary>
	///	List auto locate details for each device in your organization
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">The organization id</param>
	[ApiOperationId("getOrganizationFloorPlansAutoLocateDevices")]
	[Get("/organizations/{organizationId}/floorPlans/autoLocate/devices")]
	Task<FloorPlansAutoLocateDevices> GetOrganizationFloorPlansAutoLocateDevicesAsync(
		string organizationId,
		CancellationToken cancellationToken = default);
}
