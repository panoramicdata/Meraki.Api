namespace Meraki.Api.Interfaces.Products.Camera;

public interface ICameraAnalyticsRecent
{
	/// <summary>
	/// Returns most recent record for analytics zones
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="serial">The serial number</param>
	/// <param name="objectType">[optional] The object type for which analytics will be retrieved. The default object type is person. The available types are [person, vehicle]. (optional)</param>
	[Get("/devices/{serial}/camera/analytics/recent")]
	Task<List<CameraOverview>> GetDeviceCameraAnalyticsRecentAsync(
		[AliasAs("serial")] string serial,
		[AliasAs("objectType")] string objectType = null!,
		CancellationToken cancellationToken = default
		);

}
