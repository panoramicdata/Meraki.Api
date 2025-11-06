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
	/// <param name="perPage">The number of entries per page returned. Acceptable range is 3 - 1000. Default is 1000.</param>
	/// <param name="startingAfter">A token used by the server to indicate the start of the page. Often this is a timestamp or an ID but it is not limited to those. This parameter should not be defined by client applications. The link for the first, last, prev, or next page in the HTTP Link header should define it.</param>
	/// <param name="endingBefore">A token used by the server to indicate the end of the page. Often this is a timestamp or an ID but it is not limited to those. This parameter should not be defined by client applications. The link for the first, last, prev, or next page in the HTTP Link header should define it.</param>
	/// <param name="cancellationToken"></param>
	[Get("/networks/{networkId}/sm/devices")]
	Task<List<SmDevice>> GetNetworkSmDevicesAsync(
		string networkId,
		[AliasAs("fields[]")] List<string> fields = null!,
		[AliasAs("wifiMacs[]")] List<string> wifiMacs = null!,
		[AliasAs("serials[]")] List<string> serials = null!,
		[AliasAs("ids[]")] List<string> ids = null!,
		[AliasAs("scope[]")] List<string> scope = null!,
		int? perPage = 1000,
		string? startingAfter = null,
		string? endingBefore = null,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Force check-in a set of devices
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="checkinNetworkSmDevices">Body for check-in of device</param>
	/// <param name="cancellationToken"></param>
	[Post("/networks/{networkId}/sm/devices/checkin")]
	Task<SmDevicesCheckinRequest> CheckinNetworkSmDevicesAsync(
		string networkId,
		[Body] SmDevicesCheckinRequest checkinNetworkSmDevices,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Lock a set of devices
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId"></param>
	/// <param name="lockNetworkSmDevices">Body for locking a set of devices</param>
	/// <param name="cancellationToken"></param>
	[Post("/networks/{networkId}/sm/devices/lock")]
	Task<SmDevicesCheckinRequest> LockNetworkSmDevicesAsync(
		string networkId,
		[Body] SmDevicesCheckinRequest lockNetworkSmDevices,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Add, delete, or update the tags of a set of devices
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="modifyNetworkSmDevicesTags"></param>
	/// <param name="cancellationToken"></param>
	[Post("/networks/{networkId}/sm/devices/modifyTags")]
	Task<List<SmDevicesCheckinRequest>> ModifyNetworkSmDevicesTagsAsync(
		string networkId,
		[Body] ModifyNetworkDeviceTags modifyNetworkSmDevicesTags,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Move a set of devices to a new network
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="moveNetworkSmDevices">Body for moving devices</param>
	/// <param name="cancellationToken"></param>
	[Post("/networks/{networkId}/sm/devices/move")]
	Task<MoveNetworkSmDevicesRequest> MoveNetworkSmDevicesAsync(
		string networkId,
		[Body] MoveNetworkSmDevicesRequest moveNetworkSmDevices,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Wipe a device
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="wipeNetworkSmDevices">Body for wiping a device</param>
	/// <param name="cancellationToken"></param>
	[Post("/networks/{networkId}/sm/devices/wipe")]
	Task<WipeNetworkSmDeviceRequest> WipeNetworkSmDevicesAsync(
		string networkId,
		[Body] WipeNetworkSmDeviceRequest wipeNetworkSmDevices,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Refresh the details of a device
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="deviceId">The device id</param>
	/// <param name="cancellationToken"></param>
	[Post("/networks/{networkId}/sm/devices/{deviceId}/refreshDetails")]
	Task RefreshNetworkSmDeviceDetailsAsync(
		string networkId,
		string deviceId,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Unenroll a device
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="deviceId">The device id</param>
	/// <param name="cancellationToken"></param>
	[Post("/networks/{networkId}/sm/devices/{deviceId}/unenroll")]
	Task<ActionResponse> UnenrollNetworkSmDeviceAsync(
		string networkId,
		string deviceId,
		CancellationToken cancellationToken = default
		);
}
