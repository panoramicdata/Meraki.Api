namespace Meraki.Api.Interfaces.Products.Camera;

public interface ICameraSchedules
{
	/// <summary>
	/// Returns a list of all camera recording schedules.
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="cancellationToken"></param>
	[Get("/networks/{networkId}/camera/schedules")]
	Task<List<CameraSchedule>> GetNetworkCameraSchedulesAsync(
		string networkId,
		CancellationToken cancellationToken = default);
}
