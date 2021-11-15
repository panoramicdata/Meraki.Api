namespace Meraki.Api.Interfaces.Products.Sm;

/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>
public interface ISmDevices
{
	/// <summary>
	/// List the devices enrolled in an SM network with various specified fields and filters
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="fields">Additional fields that will be displayed for each device. Multiple fields can be passed in as comma separated values.     The default fields are: id, name, tags, ssid, wifiMac, osName, systemModel, uuid, and serialNumber. The additional fields are: ip,     systemType, availableDeviceCapacity, kioskAppName, biosVersion, lastConnected, missingAppsCount, userSuppliedAddress, location, lastUser,     ownerEmail, ownerUsername, publicIp, phoneNumber, diskInfoJson, deviceCapacity, isManaged, hadMdm, isSupervised, meid, imei, iccid,     simCarrierNetwork, cellularDataUsed, isHotspotEnabled, createdAt, batteryEstCharge, quarantined, avName, avRunning, asName, fwName,     isRooted, loginRequired, screenLockEnabled, screenLockDelay, autoLoginDisabled, autoTags, hasMdm, hasDesktopAgent, diskEncryptionEnabled,     hardwareEncryptionCaps, passCodeLock, usesHardwareKeystore, and androidSecurityPatchVersion. (optional)</param>
	/// <param name="wifiMacs">Filter devices by wifi mac(s). Multiple wifi macs can be passed in as comma separated values. (optional)</param>
	/// <param name="serials">Filter devices by serial(s). Multiple serials can be passed in as comma separated values. (optional)</param>
	/// <param name="ids">Filter devices by id(s). Multiple ids can be passed in as comma separated values. (optional)</param>
	/// <param name="scope">Specify a scope (one of all, none, withAny, withAll, withoutAny, or withoutAll) and a set of tags as comma separated values. (optional)</param>
	/// <param name="batchSize">Number of devices to return, 1000 is the default as well as the max. (optional)</param>
	/// <param name="batchToken">If the network has more devices than the batch size, a batch token will be returned     as a part of the device list. To see the remainder of the devices, pass in the batchToken as a parameter in the next request.     Requests made with the batchToken do not require additional parameters as the batchToken includes the parameters passed in     with the original request. Additional parameters passed in with the batchToken will be ignored. (optional)</param>
	[Get("/networks/{networkId}/sm/devices")]
	Task<SmDevices> GetNetworkSmDevicesAsync(
		[AliasAs("networkId")] string networkId,
		[AliasAs("fields")] string fields = null!,
		[AliasAs("wifiMacs")] string wifiMacs = null!,
		[AliasAs("serials")] string serials = null!,
		[AliasAs("ids")] string ids = null!,
		[AliasAs("scope")] string scope = null!,
		[AliasAs("batchSize")] int? batchSize = null,
		[AliasAs("batchToken")] string batchToken = null!,
		CancellationToken cancellationToken = default
		);

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

	/// <summary>
	/// Move a set of devices to a new network
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="moveNetworkSmDevices">Body for moving devices</param>
	[Post("/networks/{networkId}/sm/devices/move")]
	Task<MoveNetworkSmDevices> MoveNetworkSmDevicesAsync(
		[AliasAs("networkId")] string networkId,
		[Body] MoveNetworkSmDevices moveNetworkSmDevices,
		CancellationToken cancellationToken = default
		);

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
	/// Refresh the details of a device
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="deviceId">The device id</param>
	[Post("/networks/{networkId}/sm/devices/{deviceId}/refreshDetails")]
	Task RefreshNetworkSmDeviceDetailsAsync(
		[AliasAs("networkId")] string networkId,
		[AliasAs("deviceId")] string deviceId,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Unenroll a device
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="deviceId">The device id</param>
	[Post("/networks/{networkId}/sm/devices/{deviceId}/unenroll")]
	Task<UpdateOnboardingStatusResponse> UnenrollNetworkSmDeviceAsync(
		[AliasAs("networkId")] string networkId,
		[AliasAs("deviceId")] string deviceId,
		CancellationToken cancellationToken = default
		);
}
