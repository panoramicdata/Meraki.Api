namespace Meraki.Api.Interfaces.Products.Camera;

public interface ICameraVideoLink
{
	/// <summary>
	/// Returns video link to the specified camera
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="serial">The serial number</param>
	/// <param name="timestamp">[optional] The video link will start at this timestamp. The timestamp is in UNIX Epoch time (milliseconds). If no timestamp is specified, we will assume current time. (optional)</param>
	[Get("/devices/{serial}/camera/videoLink")]
	Task<VideoLink> GetDeviceCameraVideoLinkAsync(
		[AliasAs("serial")] string serial,
		[AliasAs("timestamp")] string timestamp = null!,
		CancellationToken cancellationToken = default);
}
