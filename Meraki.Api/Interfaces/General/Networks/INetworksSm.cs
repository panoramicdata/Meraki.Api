namespace Meraki.Api.Interfaces.General.Networks;
/// <summary>
/// I Networks Sm
/// </summary>
public interface INetworksSm
{
	/// <summary>
	/// Install applications on a device
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The Network ID</param>
	/// <param name="deviceId">The Device ID</param>
	/// <param name="smInstallAppsRequest"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("installNetworkSmDeviceApps")]
	[Post("/networks/{networkId}/sm/devices/{deviceId}/installApps")]
	Task InstallNetworkSmDeviceAppsAsync(string networkId,
		string deviceId,
		[Body] SmInstallAppsRequest smInstallAppsRequest,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Uninstall applications on a device
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The Network ID</param>
	/// <param name="deviceId">The Device ID</param>
	/// <param name="smInstallAppsRequest"></param>
	/// <param name="cancellationToken"></param>
	[ApiOperationId("uninstallNetworkSmDeviceApps")]
	[Post("/networks/{networkId}/sm/devices/{deviceId}/uninstallApps")]
	Task UninstallNetworkSmDeviceAppsAsync(string networkId,
		string deviceId,
		[Body] SmUninstallAppsRequest smInstallAppsRequest,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Reboot a set of endpoints
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The Network ID</param>
	/// <param name="smRebootRequest"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("rebootNetworkSmDevices")]
	[Post("/networks/{networkId}/sm/devices/reboot")]
	Task<SmActionResponse> RebootNetworkSmDevicesAsync(string networkId,
		[Body] SmRebootRequest smRebootRequest,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Shutdown a set of endpoints
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The Network ID</param>
	/// <param name="smShutdownRequest"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("shutdownNetworkSmDevices")]
	[Post("/networks/{networkId}/sm/devices/shutdown")]
	Task<SmActionResponse> ShutdownNetworkSmDevicesAsync(string networkId,
		[Body] SmShutdownRequest smShutdownRequest,
		CancellationToken cancellationToken = default);
}
