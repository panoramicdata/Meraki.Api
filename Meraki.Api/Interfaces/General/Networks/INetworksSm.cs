namespace Meraki.Api.Interfaces.General.Networks;
public interface INetworksSm
{
	/// <summary>
	/// Install applications on a device
	/// </summary>
	/// <param name="networkId">The Network ID</param>
	/// <param name="deviceId">The Device ID</param>
	/// <param name="smInstallAppsRequest"></param>
	/// <param name="cancellationToken"></param>
	/// <returns>HTTP status code with an empty object </returns>
	[Post("/networks/{networkId}/sm/devices/{deviceId}/installApps")]
	Task<object> InstallNetworkSmDeviceAppsAsync(string networkId,
		string deviceId,
		[Body] SmInstallAppsRequest smInstallAppsRequest,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Uninstall applications on a device
	/// </summary>
	/// <param name="networkId">The Network ID</param>
	/// <param name="deviceId">The Device ID</param>
	/// <param name="smInstallAppsRequest"></param>
	/// <param name="cancellationToken"></param>
	/// <returns>HTTP status code with an empty object </returns>
	[Post("/networks/{networkId}/sm/devices/{deviceId}/uninstallApps")]
	Task<object> UninstallNetworkSmDeviceAppsAsync(string networkId,
		string deviceId,
		[Body] SmUninstallAppsRequest smInstallAppsRequest,
		CancellationToken cancellationToken = default);

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
