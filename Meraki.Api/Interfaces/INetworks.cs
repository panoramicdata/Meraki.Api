using Meraki.Api.Data;
using Refit;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Meraki.Api.Interfaces
{
	/// <summary>
	/// Networks interface
	/// </summary>
	public interface INetworks
	{
		/// <summary>
		/// Return a network
		/// </summary>
		/// <param name="networkId">The network Id</param>
		[Get("/networks/{networkId}")]
		Task<Network> GetAsync(
			[AliasAs("networkId")] string networkId,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// Return a network's SSIDs
		/// </summary>
		/// <param name="networkId">The network Id</param>
		[Get("/networks/{networkId}/ssids")]
		Task<List<NetworkSsid>> GetAllSsidsAsync(
			[AliasAs("networkId")] string networkId,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// Return a network's device
		/// </summary>
		/// <param name="networkId">The network Id</param>
		/// <param name="serial">The device's serial number</param>
		[Get("/networks/{networkId}/devices/{serial}")]
		Task<Device> GetDeviceAsync(
			[AliasAs("networkId")] string networkId,
			[AliasAs("serial")] string serial,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// Blinks the LEDs on a device
		/// </summary>
		/// <param name="networkId">The network Id</param>
		/// <param name="serial">The device's serial number</param>
		[Post("/networks/{networkId}/devices/{serial}/blinkLeds")]
		Task BlinkDeviceLedsAsync(
			[AliasAs("networkId")] string networkId,
			[AliasAs("serial")] string serial,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// Reboots a device
		/// </summary>
		/// <param name="networkId">The network Id</param>
		/// <param name="serial">The device's serial number</param>
		[Post("/networks/{networkId}/devices/{serial}/reboot")]
		Task RebootDeviceAsync(
			[AliasAs("networkId")] string networkId,
			[AliasAs("serial")] string serial,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// Claims a device
		/// </summary>
		/// <param name="networkId">The network Id</param>
		/// <param name="serial">The device's serial number</param>
		/// <param name="autoBind">Whether to autobind to a config template.  NB not documented in MEraki API documentation.</param>
		[Post("/networks/{networkId}/devices/claim")]
		Task ClaimDeviceAsync(
			[AliasAs("networkId")] string networkId,
			[AliasAs("serial")] string serial,
			[AliasAs("autoBind")] bool? autoBind = false,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// Remove a single device
		/// </summary>
		/// <param name="networkId">The network Id</param>
		[Post("/networks/{networkId}/devices/{serial}/remove")]
		Task RemoveDeviceAsync(
			[AliasAs("networkId")] string networkId,
			[AliasAs("serial")] string serial,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// Bind a network to a template.
		/// </summary>
		/// <param name="networkId">The network Id</param>
		/// <param name="	Id">The ID of the template to which the network should be bound.</param>
		/// <param name="autoBind">Optional boolean indicating whether the network's switches should automatically bind to profiles of the same model. Defaults to false if left unspecified. This option only affects switch networks and switch templates. Auto-bind is not valid unless the switch template has at least one profile and has at most one profile per switch model.</param>
		[Post("/networks/{networkId}/bind")]
		Task BindTemplateAsync(
			[AliasAs("networkId")] string networkId,
			[AliasAs("configTemplateId")] string configTemplateId,
			[AliasAs("autoBind")] bool autoBind = false,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// Unbind a network from a template.
		/// </summary>
		/// <param name="networkId">The network Id</param>
		[Post("/networks/{networkId}/unbind")]
		Task UnbindTemplateAsync(
			[AliasAs("networkId")] string networkId,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// Return a network's devices
		/// </summary>
		/// <param name="networkId">The network Id</param>
		[Get("/networks/{networkId}/devices")]
		Task<List<Device>> GetDevicesAsync(
			[AliasAs("networkId")] string networkId,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// Delete a network
		/// </summary>
		/// <param name="networkId">The network Id</param>
		[Delete("/networks/{networkId}")]
		Task<Network> DeleteNetworkAsync(
			[AliasAs("networkId")] string networkId,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// List the VLANs for an MX network
		/// </summary>
		/// <param name="networkId">The network Id</param>
		[Get("/networks/{networkId}/vlans")]
		Task<List<Vlan>> GetAllVlansAsync(
			[AliasAs("networkId")] string networkId,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// Add a VLAN
		/// </summary>
		/// <param name="networkId">The network Id</param>
		/// <param name="id">The VLAN ID of the new VLAN (must be between 1 and 4094)</param>
		/// <param name="name">The name of the new VLAN</param>
		/// <param name="subnet">The subnet of the VLAN</param>
		/// <param name="applianceIp">The local IP of the appliance on the VLAN</param>
		[Post("/networks/{networkId}/vlans")]
		Task AddVlanAsync(
			[AliasAs("networkId")] string networkId,
			[AliasAs("id")] string id,
			[AliasAs("name")] string name,
			[AliasAs("subnet")] string subnet,
			[AliasAs("applianceIp")] string applianceIp,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// Returns the enabled status of VLANs for the network
		/// </summary>
		/// <param name="networkId">The network Id</param>
		[Get("/networks/{networkId}/vlansEnabledState")]
		Task<NetworkVlanEnabledStatus> GetVlansEnabledStateAsync(
			[AliasAs("networkId")] string networkId,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// Enable/Disable VLANs for the given network
		/// </summary>
		/// <param name="networkId">The network Id</param>
		/// <param name="enabled">Boolean indicating whether to enable (true) or disable (false) VLANs for the network</param>
		[Put("/networks/{networkId}/vlansEnabledState")]
		Task<NetworkVlanEnabledStatus> SetVlansEnabledStateAsync(
			[AliasAs("networkId")] string networkId,
			[AliasAs("enabled")] bool enabled,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// Enable/Disable VLANs for the given network
		/// </summary>
		/// <param name="networkId">The network Id</param>
		/// <param name="vlanId">The VLAN Id</param>
		/// <param name="vlanSpec">The VLAN specification</param>
		[Put("/networks/{networkId}/vlans/{vlanId}")]
		Task<Vlan> UpdateVlanAsync(
			[AliasAs("networkId")] string networkId,
			[AliasAs("vlanId")] string vlanId,
			[Body] VlanSpec vlanSpec,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// Updates
		/// </summary>
		/// <param name="networkId">The network Id</param>
		/// <param name="serial">The device serial</param>
		/// <param name="name">The name of a device</param>
		/// <param name="tags">The tags of a device</param>
		/// <param name="lat">The latitude of a device</param>
		/// <param name="lng">The longitude of a device</param>
		/// <param name="address">The address of a device</param>
		/// <param name="notes">The notes for the device. String. Limited to 255 characters.</param>
		/// <param name="moveMapMarker">Whether or not to set the latitude and longitude of a device based on the new address. Only applies when lat and lng are not specified.</param>
		/// <param name="switchProfileId">The ID of a switch profile to bind to the device (for available switch profiles, see the 'Switch Profiles' endpoint). Use null to unbind the switch device from the current profile. For a device to be bindable to a switch profile, it must (1) be a switch, and (2) belong to a network that is bound to a configuration template.</param>
		/// <param name="floorPlanId">The floor plan to associate to this device. null disassociates the device from the floorplan.</param>
		[Put("/networks/{networkId}/devices/{serial}")]
		Task<Device> UpdateDeviceAsync(
			[AliasAs("networkId")] string networkId,
			[AliasAs("serial")] string serial,
			[AliasAs("name")] string name = null!,
			[AliasAs("tags")] string tags = null!,
			[AliasAs("lat")] double? lat = null,
			[AliasAs("lng")] double? lng = null,
			[AliasAs("address")] string address = null!,
			[AliasAs("notes")] string notes = null!,
			[AliasAs("moveMapMarker")] bool? moveMapMarker = null,
			[AliasAs("switchProfileId")] string switchProfileId = null!,
			[AliasAs("floorPlanId")] string floorPlanId = null!,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// Update the management interface settings for a device
		/// </summary>
		/// <param name="networkId">The network Id</param>
		/// <param name="serial">The device serial</param>
		/// <param name="wanSpecs">See https://api.meraki.com/api_docs#update-the-management-interface-settings-for-a-device</param>
		[Put("/networks/{networkId}/devices/{serial}/managementInterfaceSettings")]
		Task<WanSpecs> UpdateDeviceManagementInterfaceSettingsAsync(
			[AliasAs("networkId")] string networkId,
			[AliasAs("serial")] string serial,
			[Body] WanSpecs wanSpecs,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// Return the management interface settings for a device
		/// </summary>
		/// <param name="networkId">The network Id</param>
		/// <param name="serial">The device serial</param>
		[Get("/networks/{networkId}/devices/{serial}/managementInterfaceSettings")]
		Task<WanSpecs> GetDeviceManagementInterfaceSettingsAsync(
			[AliasAs("networkId")] string networkId,
			[AliasAs("serial")] string serial,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// Returns video link to the specified camera. If a timestamp is supplied, it links to that timestamp.
		/// </summary>
		/// <param name="networkId">The network Id</param>
		/// <param name="serial">The camera serial</param>
		/// <param name="timestampMs">The video link will start at this timestamp. The timestamp is in UNIX Epoch time (milliseconds). If no timestamp is specified, we will assume current time.</param>
		[Get("/networks/{networkId}/cameras/{serial}/videoLink")]
		Task<UrlObject> GetCameraVideoLinkAsync(
			[AliasAs("networkId")] string networkId,
			[AliasAs("serial")] string serial,
			[Query("timestamp")] string timestampMs = default!,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// Returns a list of all camera recording schedules.
		/// </summary>
		/// <param name="networkId">The network Id</param>
		[Get("/networks/{networkId}/camera/schedules")]
		Task<List<CameraSchedule>> GetCameraRecordingSchedulesAsync(
			[AliasAs("networkId")] string networkId,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// Generate a snapshot of what the camera sees at the specified time and return a link to that image.
		/// </summary>
		/// <param name="networkId">The network Id</param>
		/// <param name="serial">The camera serial</param>
		/// <param name="timestampMs">The snapshot will be taken from this time on the camera. The timestamp is expected to be in ISO 8601 format. If no timestamp is specified, we will assume current time.</param>
		/// <param name="fullframe">If set to "true" the snapshot will be taken at full sensor resolution. This will error if used with timestamp.</param>
		[Post("/networks/{networkId}/cameras/{serial}/snapshot")]
		Task<CameraSnapshot> GetCameraSnapshotAsync(
			[AliasAs("networkId")] string networkId,
			[AliasAs("serial")] string serial,
			[Query("timestamp")] string timestampMs = default!,
			[Query("fullframe")] bool fullFrame = false,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// List the clients that have used this network in the timespan
		/// </summary>
		/// <param name="networkId">The network Id</param>
		/// <param name="t0">The start date/time</param>
		/// <param name="timeSpan">The timespan</param>
		/// <param name="perPage">The number of items per page</param>
		/// <param name="startingAfter">Starting after</param>
		/// <param name="endingBefore">Ending before</param>
		[Get("/networks/{networkId}/clients")]
		Task<List<ClientAccess>> GetClientsAsync(
			[AliasAs("networkId")] string networkId,
			[AliasAs("t0")] DateTimeOffset? t0 = default,
			[AliasAs("timeSpan")] int? timeSpan = default,
			[AliasAs("perPage")] int? perPage = default,
			[AliasAs("startingAfter")] string startingAfter = default!,
			[AliasAs("endingBefore")] string endingBefore = default!,
			 CancellationToken cancellationToken = default);

		/// <summary>
		/// List the Bluetooth clients seen by APs in this network
		/// </summary>
		/// <param name="networkId">The network Id</param>
		/// <param name="t0">The beginning of the timespan for the data. The maximum lookback period is 7 days from today.</param>
		/// <param name="timeSpan">The timespan for which the information will be fetched. If specifying timespan, do not specify parameter t0. The value must be in seconds and be less than or equal to 7 days. The default is 1 day.</param>
		/// <param name="perPage">The number of entries per page returned. Acceptable range is 5 - 1000. Default is 10.</param>
		/// <param name="startingAfter">A token used by the server to indicate the start of the page. Often this is a timestamp or an ID but it is not limited to those. This parameter should not be defined by client applications. The link for the first, last, prev, or next page in the HTTP Link header should define it.</param>
		/// <param name="endingBefore">A token used by the server to indicate the start of the page. Often this is a timestamp or an ID but it is not limited to those. This parameter should not be defined by client applications. The link for the first, last, prev, or next page in the HTTP Link header should define it.</param>
		/// <param name="cancellationToken">The optional cancellationTokn</param>
		[Get("/networks/{networkId}/bluetoothClients")]
		Task<List<BluetoothClient>> GetBluetoothClientsAsync(
			[AliasAs("networkId")] string networkId,
			[AliasAs("t0")] DateTimeOffset? t0 = default,
			[AliasAs("timeSpan")] int? timeSpan = default,
			[AliasAs("perPage")] int? perPage = default,
			[AliasAs("startingAfter")] string startingAfter = default!,
			[AliasAs("endingBefore")] string endingBefore = default!,
			 CancellationToken cancellationToken = default);

		/// <summary>
		/// Return a bluetooth client. Bluetooth clients can be identified by their ID or their MAC.
		/// </summary>
		/// <param name="networkId">The network Id</param>
		/// <param name="bluetoothClientId">The bluetooth client Id</param>
		/// <param name="includeConnectivityHistory">Whether to include the connectivity history for this client</param>
		/// <param name="connectivityHistoryTimespan">The timespan, in seconds, for the connectivityHistory data. By default 1 day, 86400, will be used.</param>
		/// <param name="cancellationToken">The optional cancellationTokn</param>
		[Get("/networks/{networkId}/bluetoothClients/{bluetoothClientId}")]
		Task<BluetoothClient> GetBluetoothClientsAsync(
			[AliasAs("networkId")] string networkId,
			[AliasAs("bluetoothClientId")] string bluetoothClientId,
			[AliasAs("includeConnectivityHistory")] bool includeConnectivityHistory = false,
			[AliasAs("connectivityHistoryTimespan")] int? connectivityHistoryTimespan = null,
			 CancellationToken cancellationToken = default);

		/// <summary>
		/// Return the wireless settings for a network
		/// </summary>
		/// <param name="networkId">The network Id</param>
		/// <param name="wirelessSettings">The wireless settings</param>
		/// <param name="cancellationToken">The optional cancellationTokn</param>
		[Get("/networks/{networkId}/wireless/settings")]
		Task<WirelessSettings> GetWirelessSettingsAsync(
			[AliasAs("networkId")] string networkId,
			 CancellationToken cancellationToken = default);

		/// <summary>
		/// Update the wireless settings for a network
		/// </summary>
		/// <param name="networkId">The network Id</param>
		/// <param name="wirelessSettings">The wireless settings</param>
		/// <param name="cancellationToken">The optional cancellationTokn</param>
		[Put("/networks/{networkId}/wireless/settings")]
		Task<WirelessSettings> SetWirelessSettingsAsync(
			[AliasAs("networkId")] string networkId,
			[Body] WirelessSettings wirelessSettings,
			 CancellationToken cancellationToken = default);
	}
}
