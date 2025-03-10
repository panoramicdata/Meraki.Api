namespace Meraki.Api.Interfaces.Products.Camera;

public interface ICameraAnalyticsOverview
{
	/// <summary>
	/// Returns an overview of aggregate analytics data for a timespan
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="serial">The serial number</param>
	/// <param name="t0">The beginning of the timespan for the data. The maximum lookback period is 365 days from today. (optional)</param>
	/// <param name="t1">The end of the timespan for the data. t1 can be a maximum of 7 days after t0. (optional)</param>
	/// <param name="timespan">The timespan for which the information will be fetched. If specifying timespan, do not specify parameters t0 and t1. The value must be in seconds and be less than or equal to 7 days. The default is 1 hour. (optional)</param>
	/// <param name="objectType">[optional] The object type for which analytics will be retrieved. The default object type is person. The available types are [person, vehicle]. (optional)</param>
	[Get("/devices/{serial}/camera/analytics/overview")]
	[Obsolete("This endpoint is deprecated and will be removed in a future update. Please use the new camera/analytics/overview endpoint.", false)]
	Task<List<CameraOverview>> GetDeviceCameraAnalyticsOverviewAsync(
		string serial,
		string t0 = null!,
		string t1 = null!,
		double? timespan = null,
		string objectType = null!,
		CancellationToken cancellationToken = default
		);
}
