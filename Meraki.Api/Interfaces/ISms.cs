using Meraki.Api.Data;
using Refit;
using System.Threading.Tasks;

namespace Meraki.Api.Interfaces
{
	/// <summary>
	/// Represents a collection of functions to interact with the API endpoints
	/// </summary>
	public interface ISms
	{
		/// <summary>
		///// checkinNetworkSmDevices
		///// </summary>
		///// <remarks>
		///// Force check-in a set of devices
		///// </remarks>
		///// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		///// <param name="networkId"></param>
		///// <param name="checkinNetworkSmDevices"> (optional)</param>
		///// <returns>Task of Object</returns>
		//[Put("/networks/{networkId}/sm/devices/checkin")]
		//Task<object> CheckinNetworkSmDevices(
		//	[AliasAs("networkId")]string networkId,
		//	[Body]CheckinNetworkSmDevices checkinNetworkSmDevices
		//	);

		/// <summary>
		/// createNetworkSmAppPolaris
		/// </summary>
		/// <remarks>
		/// Create a new Polaris app
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <param name="createNetworkSmAppPolaris"></param>
		/// <returns>Task of Object</returns>
		[Post("/networks/{networkId}/sm/app/polaris")]
		Task<object> CreateNetworkSmAppPolaris(
			[AliasAs("networkId")]string networkId,
			[Body]SmAppPolarisCreationRequest createNetworkSmAppPolaris
			);

		/// <summary>
		/// createNetworkSmBypassActivationLockAttempt
		/// </summary>
		/// <remarks>
		/// Bypass activation lock attempt
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <param name="createNetworkSmBypassActivationLockAttempt"></param>
		/// <returns>Task of Object</returns>
		[Post("/networks/{networkId}/sm/bypassActivationLockAttempts")]
		Task<object> CreateNetworkSmBypassActivationLockAttempt(
			[AliasAs("networkId")]string networkId,
			[Body]SmBypassActivationLockAttemptCreationRequest createNetworkSmBypassActivationLockAttempt
			);

		/// <summary>
		/// deleteNetworkSmAppPolaris
		/// </summary>
		/// <remarks>
		/// Delete a Cisco Polaris app
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <param name="appId"></param>
		/// <returns>Task of Object</returns>
		[Delete("/networks/{networkId}/sm/app/polaris/{appId}")]
		Task<object> DeleteNetworkSmAppPolaris(
			[AliasAs("networkId")]string networkId,
			[AliasAs("appId")]string appId
			);

		/// <summary>
		/// getNetworkSmAppPolaris
		/// </summary>
		/// <remarks>
		/// Get details for a Cisco Polaris app if it exists
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <param name="bundleId">The bundle ID of the app to be found, defaults to com.cisco.ciscosecurity.app (optional)</param>
		/// <returns>Task of Object</returns>
		[Get("/networks/{networkId}/sm/app/polaris")]
		Task<object> GetNetworkSmAppPolaris(
			[AliasAs("networkId")]string networkId,
			[AliasAs("bundleId")]string bundleId = null!
			);

		/// <summary>
		/// getNetworkSmBypassActivationLockAttempt
		/// </summary>
		/// <remarks>
		/// Bypass activation lock attempt status
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <param name="attemptId"></param>
		/// <returns>Task of Object</returns>
		[Get("/networks/{networkId}/sm/bypassActivationLockAttempts/{attemptId}")]
		Task<object> GetNetworkSmBypassActivationLockAttempt(
			[AliasAs("networkId")]string networkId,
			[AliasAs("attemptId")]string attemptId
			);

		/// <summary>
		/// getNetworkSmCellularUsageHistory
		/// </summary>
		/// <remarks>
		/// Return the client&#39;s daily cellular data usage history. Usage data is in kilobytes.
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <param name="deviceId"></param>
		/// <returns>Task of Object</returns>
		[Get("/networks/{networkId}/sm/devices/{deviceId}/cellularUsageHistory")]
		Task<object> GetNetworkSmCellularUsageHistory(
			[AliasAs("networkId")]string networkId,
			[AliasAs("deviceId")]string deviceId
			);

		/// <summary>
		/// getNetworkSmCerts
		/// </summary>
		/// <remarks>
		/// List the certs on a device
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <param name="deviceId"></param>
		/// <returns>Task of Object</returns>
		[Get("/networks/{networkId}/sm/devices/{deviceId}/certs")]
		Task<object> GetNetworkSmCerts(
			[AliasAs("networkId")]string networkId,
			[AliasAs("deviceId")]string deviceId
			);

		/// <summary>
		/// getNetworkSmConnectivity
		/// </summary>
		/// <remarks>
		/// Returns historical connectivity data (whether a device is regularly checking in to Dashboard).
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <param name="id"></param>
		/// <param name="perPage">The number of entries per page returned. Acceptable range is 3 - 1000. Default is 1000. (optional)</param>
		/// <param name="startingAfter">A token used by the server to indicate the start of the page. Often this is a timestamp or an ID but it is not limited to those. This parameter should not be defined by client applications. The link for the first, last, prev, or next page in the HTTP Link header should define it. (optional)</param>
		/// <param name="endingBefore">A token used by the server to indicate the end of the page. Often this is a timestamp or an ID but it is not limited to those. This parameter should not be defined by client applications. The link for the first, last, prev, or next page in the HTTP Link header should define it. (optional)</param>
		/// <returns>Task of Object</returns>
		[Get("/networks/{networkId}/sm/{id}/connectivity")]
		Task<object> GetNetworkSmConnectivity(
			[AliasAs("networkId")]string networkId,
			[AliasAs("id")]string id,
			[AliasAs("perPage")]int? perPage = null,
			[AliasAs("startingAfter")]string startingAfter = null!,
			[AliasAs("endingBefore")]string endingBefore = null!
			);

		/// <summary>
		/// getNetworkSmDesktopLogs
		/// </summary>
		/// <remarks>
		/// Return historical records of various Systems Manager network connection details for desktop devices.
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <param name="id"></param>
		/// <param name="perPage">The number of entries per page returned. Acceptable range is 3 - 1000. Default is 1000. (optional)</param>
		/// <param name="startingAfter">A token used by the server to indicate the start of the page. Often this is a timestamp or an ID but it is not limited to those. This parameter should not be defined by client applications. The link for the first, last, prev, or next page in the HTTP Link header should define it. (optional)</param>
		/// <param name="endingBefore">A token used by the server to indicate the end of the page. Often this is a timestamp or an ID but it is not limited to those. This parameter should not be defined by client applications. The link for the first, last, prev, or next page in the HTTP Link header should define it. (optional)</param>
		/// <returns>Task of Object</returns>
		[Get("/networks/{networkId}/sm/{id}/desktopLogs")]
		Task<object> GetNetworkSmDesktopLogs(
			[AliasAs("networkId")]string networkId,
			[AliasAs("id")]string id,
			[AliasAs("perPage")]int? perPage = null,
			[AliasAs("startingAfter")]string startingAfter = null!,
			[AliasAs("endingBefore")]string endingBefore = null!
			);

		/// <summary>
		/// getNetworkSmDeviceCommandLogs
		/// </summary>
		/// <remarks>
		///     Return historical records of commands sent to Systems Manager devices.     &lt;p&gt;Note that this will include the name of the Dashboard user who initiated the command if it was generated     by a Dashboard admin rather than the automatic behavior of the system; you may wish to filter this out     of any reports.&lt;/p&gt;
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <param name="id"></param>
		/// <param name="perPage">The number of entries per page returned. Acceptable range is 3 - 1000. Default is 1000. (optional)</param>
		/// <param name="startingAfter">A token used by the server to indicate the start of the page. Often this is a timestamp or an ID but it is not limited to those. This parameter should not be defined by client applications. The link for the first, last, prev, or next page in the HTTP Link header should define it. (optional)</param>
		/// <param name="endingBefore">A token used by the server to indicate the end of the page. Often this is a timestamp or an ID but it is not limited to those. This parameter should not be defined by client applications. The link for the first, last, prev, or next page in the HTTP Link header should define it. (optional)</param>
		/// <returns>Task of Object</returns>
		[Get("/networks/{networkId}/sm/{id}/deviceCommandLogs")]
		Task<object> GetNetworkSmDeviceCommandLogs(
			[AliasAs("networkId")]string networkId,
			[AliasAs("id")]string id,
			[AliasAs("perPage")]int? perPage = null,
			[AliasAs("startingAfter")]string startingAfter = null!,
			[AliasAs("endingBefore")]string endingBefore = null!
			);

		/// <summary>
		/// getNetworkSmDeviceProfiles
		/// </summary>
		/// <remarks>
		/// Get the profiles associated with a device
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <param name="deviceId"></param>
		/// <returns>Task of Object</returns>
		[Get("/networks/{networkId}/sm/devices/{deviceId}/deviceProfiles")]
		Task<object> GetNetworkSmDeviceProfiles(
			[AliasAs("networkId")]string networkId,
			[AliasAs("deviceId")]string deviceId
			);

		/// <summary>
		/// getNetworkSmDevices
		/// </summary>
		/// <remarks>
		/// List the devices enrolled in an SM network with various specified fields and filters
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <param name="fields">Additional fields that will be displayed for each device. Multiple fields can be passed in as comma separated values.     The default fields are: id, name, tags, ssid, wifiMac, osName, systemModel, uuid, and serialNumber. The additional fields are: ip,     systemType, availableDeviceCapacity, kioskAppName, biosVersion, lastConnected, missingAppsCount, userSuppliedAddress, location, lastUser,     ownerEmail, ownerUsername, publicIp, phoneNumber, diskInfoJson, deviceCapacity, isManaged, hadMdm, isSupervised, meid, imei, iccid,     simCarrierNetwork, cellularDataUsed, isHotspotEnabled, createdAt, batteryEstCharge, quarantined, avName, avRunning, asName, fwName,     isRooted, loginRequired, screenLockEnabled, screenLockDelay, autoLoginDisabled, autoTags, hasMdm, hasDesktopAgent, diskEncryptionEnabled,     hardwareEncryptionCaps, passCodeLock, usesHardwareKeystore, and androidSecurityPatchVersion. (optional)</param>
		/// <param name="wifiMacs">Filter devices by wifi mac(s). Multiple wifi macs can be passed in as comma separated values. (optional)</param>
		/// <param name="serials">Filter devices by serial(s). Multiple serials can be passed in as comma separated values. (optional)</param>
		/// <param name="ids">Filter devices by id(s). Multiple ids can be passed in as comma separated values. (optional)</param>
		/// <param name="scope">Specify a scope (one of all, none, withAny, withAll, withoutAny, or withoutAll) and a set of tags as comma separated values. (optional)</param>
		/// <param name="batchSize">Number of devices to return, 1000 is the default as well as the max. (optional)</param>
		/// <param name="batchToken">If the network has more devices than the batch size, a batch token will be returned     as a part of the device list. To see the remainder of the devices, pass in the batchToken as a parameter in the next request.     Requests made with the batchToken do not require additional parameters as the batchToken includes the parameters passed in     with the original request. Additional parameters passed in with the batchToken will be ignored. (optional)</param>
		/// <returns>Task of Object</returns>
		[Get("/networks/{networkId}/sm/devices")]
		Task<object> GetNetworkSmDevices(
			[AliasAs("networkId")]string networkId,
			[AliasAs("fields")]string fields = null!,
			[AliasAs("wifiMacs")]string wifiMacs = null!,
			[AliasAs("serials")]string serials = null!,
			[AliasAs("ids")]string ids = null!,
			[AliasAs("scope")]string scope = null!,
			[AliasAs("batchSize")]int? batchSize = null,
			[AliasAs("batchToken")]string batchToken = null!
			);

		/// <summary>
		/// getNetworkSmNetworkAdapters
		/// </summary>
		/// <remarks>
		/// List the network adapters of a device
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <param name="deviceId"></param>
		/// <returns>Task of Object</returns>
		[Get("/networks/{networkId}/sm/devices/{deviceId}/networkAdapters")]
		Task<object> GetNetworkSmNetworkAdapters(
			[AliasAs("networkId")]string networkId,
			[AliasAs("deviceId")]string deviceId
			);

		/// <summary>
		/// getNetworkSmPerformanceHistory
		/// </summary>
		/// <remarks>
		/// Return historical records of various Systems Manager client metrics for desktop devices.
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <param name="id"></param>
		/// <param name="perPage">The number of entries per page returned. Acceptable range is 3 - 1000. Default is 1000. (optional)</param>
		/// <param name="startingAfter">A token used by the server to indicate the start of the page. Often this is a timestamp or an ID but it is not limited to those. This parameter should not be defined by client applications. The link for the first, last, prev, or next page in the HTTP Link header should define it. (optional)</param>
		/// <param name="endingBefore">A token used by the server to indicate the end of the page. Often this is a timestamp or an ID but it is not limited to those. This parameter should not be defined by client applications. The link for the first, last, prev, or next page in the HTTP Link header should define it. (optional)</param>
		/// <returns>Task of Object</returns>
		[Get("/networks/{networkId}/sm/{id}/performanceHistory")]
		Task<object> GetNetworkSmPerformanceHistory(
			[AliasAs("networkId")]string networkId,
			[AliasAs("id")]string id,
			[AliasAs("perPage")]int? perPage = null,
			[AliasAs("startingAfter")]string startingAfter = null!,
			[AliasAs("endingBefore")]string endingBefore = null!
			);

		/// <summary>
		/// getNetworkSmProfiles
		/// </summary>
		/// <remarks>
		/// List all the profiles in the network
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <returns>Task of Object</returns>
		[Get("/networks/{networkId}/sm/profiles")]
		Task<object> GetNetworkSmProfiles(
			[AliasAs("networkId")]string networkId
			);

		/// <summary>
		/// getNetworkSmRestrictions
		/// </summary>
		/// <remarks>
		/// List the restrictions on a device
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <param name="deviceId"></param>
		/// <returns>Task of Object</returns>
		[Get("/networks/{networkId}/sm/devices/{deviceId}/restrictions")]
		Task<object> GetNetworkSmRestrictions(
			[AliasAs("networkId")]string networkId,
			[AliasAs("deviceId")]string deviceId
			);

		/// <summary>
		/// getNetworkSmSecurityCenters
		/// </summary>
		/// <remarks>
		/// List the security centers on a device
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <param name="deviceId"></param>
		/// <returns>Task of Object</returns>
		[Get("/networks/{networkId}/sm/devices/{deviceId}/securityCenters")]
		Task<object> GetNetworkSmSecurityCenters(
			[AliasAs("networkId")]string networkId,
			[AliasAs("deviceId")]string deviceId
			);

		/// <summary>
		/// getNetworkSmSoftwares
		/// </summary>
		/// <remarks>
		/// Get a list of softwares associated with a device
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <param name="deviceId"></param>
		/// <returns>Task of Object</returns>
		[Get("/networks/{networkId}/sm/devices/{deviceId}/softwares")]
		Task<object> GetNetworkSmSoftwares(
			[AliasAs("networkId")]string networkId,
			[AliasAs("deviceId")]string deviceId
			);

		/// <summary>
		/// getNetworkSmUserDeviceProfiles
		/// </summary>
		/// <remarks>
		/// Get the profiles associated with a user
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <param name="userId"></param>
		/// <returns>Task of Object</returns>
		[Get("/networks/{networkId}/sm/users/{userId}/deviceProfiles")]
		Task<object> GetNetworkSmUserDeviceProfiles(
			[AliasAs("networkId")]string networkId,
			[AliasAs("userId")]string userId
			);

		/// <summary>
		/// getNetworkSmUserSoftwares
		/// </summary>
		/// <remarks>
		/// Get a list of softwares associated with a user
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <param name="userId"></param>
		/// <returns>Task of Object</returns>
		[Get("/networks/{networkId}/sm/users/{userId}/softwares")]
		Task<object> GetNetworkSmUserSoftwares(
			[AliasAs("networkId")]string networkId,
			[AliasAs("userId")]string userId
			);

		/// <summary>
		/// getNetworkSmUsers
		/// </summary>
		/// <remarks>
		/// List the owners in an SM network with various specified fields and filters
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <param name="ids">Filter users by id(s). Multiple ids can be passed in as comma separated values. (optional)</param>
		/// <param name="usernames">Filter users by username(s). Multiple usernames can be passed in as comma separated values. (optional)</param>
		/// <param name="emails">Filter users by email(s). Multiple emails can be passed in as comma separated values. (optional)</param>
		/// <param name="scope">Specifiy a scope (one of all, none, withAny, withAll, withoutAny, withoutAll) and a set of tags as comma separated values. (optional)</param>
		/// <returns>Task of Object</returns>
		[Get("/networks/{networkId}/sm/users")]
		Task<object> GetNetworkSmUsers(
			[AliasAs("networkId")]string networkId,
			[AliasAs("ids")]string ids = null!,
			[AliasAs("usernames")]string usernames = null!,
			[AliasAs("emails")]string emails = null!,
			[AliasAs("scope")]string scope = null!
			);

		/// <summary>
		/// getNetworkSmWlanLists
		/// </summary>
		/// <remarks>
		/// List the saved SSID names on a device
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <param name="deviceId"></param>
		/// <returns>Task of Object</returns>
		[Get("/networks/{networkId}/sm/devices/{deviceId}/wlanLists")]
		Task<object> GetNetworkSmWlanLists(
			[AliasAs("networkId")]string networkId,
			[AliasAs("deviceId")]string deviceId
			);

		/// <summary>
		/// moveNetworkSmDevices
		/// </summary>
		/// <remarks>
		/// Move a set of devices to a new network
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <param name="moveNetworkSmDevices"></param>
		/// <returns>Task of Object</returns>
		[Put("/networks/{networkId}/sm/devices/move")]
		Task<object> MoveNetworkSmDevices(
			[AliasAs("networkId")]string networkId,
			[Body]MoveNetworkSmDevices moveNetworkSmDevices
			);

		/// <summary>
		/// refreshNetworkSmDeviceDetails
		/// </summary>
		/// <remarks>
		/// Refresh the details of a device
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <param name="deviceId"></param>
		/// <returns>Task of void</returns>
		[Post("/networks/{networkId}/sm/devices/{deviceId}/refreshDetails")]
		Task RefreshNetworkSmDeviceDetails(
			[AliasAs("networkId")]string networkId,
			[AliasAs("deviceId")]string deviceId
			);

		/// <summary>
		/// unenrollNetworkSmDevice
		/// </summary>
		/// <remarks>
		/// Unenroll a device
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <param name="deviceId"></param>
		/// <returns>Task of Object</returns>
		[Post("/networks/{networkId}/sm/devices/{deviceId}/unenroll")]
		Task<object> UnenrollNetworkSmDevice(
			[AliasAs("networkId")]string networkId,
			[AliasAs("deviceId")]string deviceId
			);

		/// <summary>
		/// updateNetworkSmAppPolaris
		/// </summary>
		/// <remarks>
		/// Update an existing Polaris app
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <param name="appId"></param>
		/// <param name="updateNetworkSmAppPolaris"> (optional)</param>
		/// <returns>Task of Object</returns>
		[Put("/networks/{networkId}/sm/app/polaris/{appId}")]
		Task<object> UpdateNetworkSmAppPolaris(
			[AliasAs("networkId")]string networkId,
			[AliasAs("appId")]string appId,
			[Body]SmAppPolarisUpdateRequest updateNetworkSmAppPolaris
			);

		/// <summary>
		/// updateNetworkSmDeviceFields
		/// </summary>
		/// <remarks>
		/// Modify the fields of a device
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <param name="updateNetworkSmDeviceFields"></param>
		/// <returns>Task of Object</returns>
		[Put("/networks/{networkId}/sm/devices/fields")]
		Task<object> UpdateNetworkSmDeviceFields(
			[AliasAs("networkId")]string networkId,
			[Body]SmDeviceFieldsUpdateRequest updateNetworkSmDeviceFields
			);
	}
}
