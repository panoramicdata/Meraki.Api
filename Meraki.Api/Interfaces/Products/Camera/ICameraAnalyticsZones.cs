namespace Meraki.Api.Interfaces.Products.Camera;

/// <summary>
/// I Camera Analytics Zones
/// </summary>
public interface ICameraAnalyticsZones
{
	/// <summary>
	/// Return historical records for analytic zones
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="serial">The serial number</param>
	/// <param name="zoneId">The zone id</param>
	/// <param name="t0">The beginning of the timespan for the data. The maximum lookback period is 365 days from today. (optional)</param>
	/// <param name="t1">The end of the timespan for the data. t1 can be a maximum of 14 hours after t0. (optional)</param>
	/// <param name="timespan">The timespan for which the information will be fetched. If specifying timespan, do not specify parameters t0 and t1. The value must be in seconds and be less than or equal to 14 hours. The default is 1 hour. (optional)</param>
	/// <param name="resolution">The time resolution in seconds for returned data. The valid resolutions are: 60. The default is 60. (optional)</param>
	/// <param name="objectType">[optional] The object type for which analytics will be retrieved. The default object type is person. The available types are [person, vehicle]. (optional)</param>
	/// <param name="cancellationToken"></param>
	[Get("/devices/{serial}/camera/analytics/zones/{zoneId}/history")]
	Task<List<CameraZoneHistory>> GetDeviceCameraAnalyticsZoneHistoryAsync(
		string serial,
		string zoneId,
		string t0 = null!,
		string t1 = null!,
		double? timespan = null,
		int? resolution = null,
		string objectType = null!,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Returns all configured analytic zones for this camera
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="serial">The serial number</param>
	/// <param name="cancellationToken"></param>
	[Get("/devices/{serial}/camera/analytics/zones")]
	Task<List<CameraZone>> GetDeviceCameraAnalyticsZonesAsync(
		string serial,
		CancellationToken cancellationToken = default
		);
}
