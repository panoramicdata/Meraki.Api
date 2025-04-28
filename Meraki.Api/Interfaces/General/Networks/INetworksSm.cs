namespace Meraki.Api.Interfaces.General.Networks;
public interface INetworksSm
{
	/// <summary>
	/// Reboot a set of endpoints
	/// </summary>
	/// <param name="networkId">The Network ID</param>
	/// <param name="smRebootRequest"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[Post("/networks/{networkId}/sm/devices/reboot")]
	Task<SmActionResponse> RebootSmDevicesAsync(string networkId,
		[Body] SmRebootRequest smRebootRequest,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Shutdown a set of endpoints
	/// </summary>
	/// <param name="networkId"></param>
	/// <param name="smShutdownRequest"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[Post("/networks/{networkId}/sm/devices/shutdown")]
	Task<SmActionResponse> ShutdownNetworkSmDevicesAsync(string networkId,
		[Body] SmShutdownRequest smShutdownRequest,
		CancellationToken cancellationToken = default);
}
