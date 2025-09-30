namespace Meraki.Api.Interfaces.General.Organizations;

public interface IOrganizationsCameraDetections
{
	/// <summary>
	/// Returns analytics data for timespans
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId"></param>
	/// <param name="boundaryIds">A list of boundary ids. The returned cameras will be filtered to only include these ids.</param>
	/// <param name="ranges">A list of time ranges with intervals</param>
	/// <param name="duration">The minimum time, in seconds, that the person or car remains in the area to be counted. Defaults to boundary configuration or 60.</param>
	/// <param name="perPage">The number of entries per page returned. Acceptable range is 1 - 1000. Defaults to 1000.</param>
	/// <param name="boundaryTypes">The detection types. Defaults to 'person'. enum = ["person", "vehicle"]</param>
	/// <param name="counterMode">The filtering mode for Advanced People Counter. enum = ["all", "directions", "passages"]</param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("getOrganizationCameraDetectionsHistoryByBoundaryByInterval")]
	[Get("/organizations/{organizationId}/camera/detections/history/byBoundary/byInterval")]
	Task<List<OrganizationCameraDetectionsHistoryByBoundaryByIntervalItem>> GetOrganizationCameraDetectionsHistoryByBoundaryByIntervalAsync(
		string organizationId,
		[AliasAs("boundaryIds[]")] List<string>? boundaryIds,
		[AliasAs("ranges[]")] List<OrganizationCameraDetectionsHistoryRange>? ranges,
		int? duration = null,
		int? perPage = 1000,
		[AliasAs("boundaryTypes[]")] List<string>? boundaryTypes = null,
		string? counterMode = null,
		CancellationToken cancellationToken = default
	);
}
