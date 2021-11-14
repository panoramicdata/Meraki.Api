namespace Meraki.Api.Interfaces.Products.Sm;

/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>
public interface ISmDevices
{
	/// <summary>
	/// Wipe a device
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="wipeNetworkSmDevices">Body for wiping a device</param>
	[Post("/networks/{networkId}/sm/devices/wipe")]
	Task<WipeNetworkSmDevice> WipeNetworkSmDevicesAsync(
		[AliasAs("networkId")] string networkId,
		[Body] WipeNetworkSmDevice wipeNetworkSmDevices,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Force check-in a set of devices
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="checkinNetworkSmDevices">Body for check-in of device</param>
	[Post("/networks/{networkId}/sm/devices/checkin")]
	Task<CheckinNetworkSmDevices> CheckinNetworkSmDevicesAsync(
		[AliasAs("networkId")] string networkId,
		[Body] CheckinNetworkSmDevices checkinNetworkSmDevices,
		CancellationToken cancellationToken = default
		);


	/// <summary>
	/// Lock a set of devices
	/// </summary>
	/// <exception cref="Refit.ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId"></param>
	/// <param name="lockNetworkSmDevices">Body for locking a set of devices</param>
	[Post("/networks/{networkId}/sm/devices/lock")]
	Task<CheckinNetworkSmDevices> LockNetworkSmDevicesAsync(
		[AliasAs("networkId")] string networkId,
		[Body] CheckinNetworkSmDevices lockNetworkSmDevices,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Add, delete, or update the tags of a set of devices
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	[Post("/networks/{networkId}/sm/devices/modifyTags")]
	Task<CheckinNetworkSmDevices> ModifyNetworkSmDevicesTagsAsync(
		[AliasAs("networkId")] string networkId,
		[Body] ModifyNetworkDeviceTags modifyNetworkSmDevicesTags,
		CancellationToken cancellationToken = default
		);
}
