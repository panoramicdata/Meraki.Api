namespace Meraki.Api.Interfaces.General.Organizations;

public interface IOrganizationsCameraDetections
{
	/// <summary>
	/// Returns analytics data for timespans
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("getOrganizationCameraDetectionsHistoryByBoundaryByInterval")]
	[Get("/organizations/{organizationId}/camera/detections/history/byBoundary/byInterval")]
	Task<List<OrganizationCameraDetectionsHistoryByBoundaryByIntervalItem>> GetOrganizationCameraDetectionsHistoryByBoundaryByIntervalAsync(
		string organizationId,
		CancellationToken cancellationToken = default
	);
}
