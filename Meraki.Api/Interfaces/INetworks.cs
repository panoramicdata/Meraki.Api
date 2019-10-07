using Meraki.Api.Data;
using Refit;
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
		[Post("/networks/{networkId}/devices/claim")]
		Task ClaimDeviceAsync(
			[AliasAs("networkId")] string networkId,
			[AliasAs("serial")] string serial,
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
		/// <param name="configTemplateId">The ID of the template to which the network should be bound.</param>
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
		/// <param name="name">The name of the VLAN</param>
		/// <param name="subnet">The subnet of the VLAN</param>
		/// <param name="applianceIp">The local IP of the appliance on the VLAN</param>
		/// <param name="vpnNatSubnet">The translated VPN subnet if VPN and VPN subnet translation are enabled on the VLAN</param>
		/// <param name="dhcpHandling">The appliance's handling of DHCP requests on this VLAN. One of: 'Run a DHCP server', 'Relay DHCP to another server' or 'Do not respond to DHCP requests'</param>
		/// <param name="dhcpRelayServerIps">The IPs of the DHCP servers that DHCP requests should be relayed to</param>
		/// <param name="dhcpLeaseTime">The term of DHCP leases if the appliance is running a DHCP server on this VLAN. One of: '30 minutes', '1 hour', '4 hours', '12 hours', '1 day' or '1 week'</param>
		/// <param name="dhcpBootOptionsEnabled">Use DHCP boot options specified in other properties</param>
		/// <param name="dhcpBootNextServer">DHCP boot option to direct boot clients to the server to load the boot file from</param>
		/// <param name="dhcpBootFilename">DHCP boot option for boot filename</param>
		/// <param name="fixedIpAssignments">The DHCP fixed IP assignments on the VLAN. This should be an object that contains mappings from MAC addresses to objects that themselves each contain "ip" and "name" string fields. See the sample request/response for more details.</param>
		/// <param name="reservedIpRanges">The DHCP reserved IP ranges on the VLAN</param>
		/// <param name="dnsNameservers">The DNS nameservers used for DHCP responses, either "upstream_dns", "google_dns", "opendns", or a newline seperated string of IP addresses or domain names</param>
		/// <param name="dhcpOptions">The list of DHCP options that will be included in DHCP responses. Each object in the list should have "code", "type", and "value" properties.</param>
		[Put("/networks/{networkId}/vlans/{vlanId}")]
		Task<Vlan> UpdateVlanAsync(
			[AliasAs("networkId")] string networkId,
			[AliasAs("vlanId")] string vlanId,
			[AliasAs("name")] string name = null!,
			[AliasAs("subnet")] string subnet = null!,
			[AliasAs("applianceIp")] string applianceIp = null!,
			[AliasAs("vpnNatSubnet")] string vpnNatSubnet = null!,
			[AliasAs("dhcpHandling")] string dhcpHandling = null!,
			[AliasAs("dhcpRelayServerIps")] string dhcpRelayServerIps = null!,
			[AliasAs("dhcpLeaseTime")] string dhcpLeaseTime = null!,
			[AliasAs("dhcpBootOptionsEnabled")] string dhcpBootOptionsEnabled = null!,
			[AliasAs("dhcpBootNextServer")] string dhcpBootNextServer = null!,
			[AliasAs("dhcpBootFilename")] string dhcpBootFilename = null!,
			[AliasAs("fixedIpAssignments")] string fixedIpAssignments = null!,
			[AliasAs("reservedIpRanges")] List<ReservedIpRange> reservedIpRanges = null!,
			[AliasAs("dnsNameservers")] string dnsNameservers = null!,
			[AliasAs("dhcpOptions")] string dhcpOptions = null!,
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
	}
}
