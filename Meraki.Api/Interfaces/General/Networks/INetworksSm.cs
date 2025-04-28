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
	Task<SmRebootResponse> RebootSmDevicesAsync(string networkId,
		[Body] SmRebootRequest smRebootRequest,
		CancellationToken cancellationToken = default);
}
