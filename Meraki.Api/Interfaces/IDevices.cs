using Meraki.Api.Data;
using Refit;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Meraki.Api.Interfaces
{
	/// <summary>
	/// Represents a collection of functions to interact with the API endpoints
	/// </summary>
	public interface IDevices
	{
		/// <summary>
		/// blinkNetworkDeviceLeds
		/// </summary>
		/// <remarks>
		/// Blink the LEDs on a device
		/// </remarks>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="serial"></param>
		/// <param name="deviceLedsBlinkRequest"> (optional)</param>
		/// <returns>Task of Object</returns>
		[Post("/devices/{serial}/blinkLeds")]
		Task<DeviceLedsBlinkResponse> BlinkLedsAsync(
			[AliasAs("serial")] string serial,
			[Body] DeviceLedsBlinkRequest? deviceLedsBlinkRequest = null,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// claimNetworkDevices
		/// </summary>
		/// <remarks>
		/// Claim devices into a network. (Note: for recently claimed devices, it may take a few minutes for API requsts against that device to succeed)
		/// </remarks>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <param name="claimNetworkDevices"> (optional)</param>
		/// <returns>Task of void</returns>
		[Post("/networks/{networkId}/devices/claim")]
		Task ClaimAsync(
			[AliasAs("networkId")] string networkId,
			[Body] DeviceClaimRequest claimNetworkDevices,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// cycleDeviceSwitchPorts
		/// </summary>
		/// <remarks>
		/// Cycle a set of switch ports
		/// </remarks>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="serial"></param>
		/// <param name="deviceSwitchPortsCycleRequest"></param>
		/// <returns>Task of Object</returns>
		[Post("/devices/{serial}/switch/ports/cycle")]
		Task<object> CycleSwitchPortsAsync(
			[AliasAs("serial")] string serial,
			[Body] DeviceSwitchPortsCycleRequest deviceSwitchPortsCycleRequest,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// getNetworkDevice
		/// </summary>
		/// <remarks>
		/// Return a single device
		/// </remarks>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="serial"></param>
		/// <returns>Task of Object</returns>
		[Get("/devices/{serial}")]
		Task<Device> GetAsync(
			[AliasAs("serial")] string serial,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// getNetworkDeviceLldp_cdp
		/// </summary>
		/// <remarks>
		/// List LLDP and CDP information for a device
		/// </remarks>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="serial"></param>
		/// <param name="timespan">The timespan for which LLDP and CDP information will be fetched. Must be in seconds and less than or equal to a month (2592000 seconds). LLDP and CDP information is sent to the Meraki dashboard every 10 minutes. In instances where this LLDP and CDP information matches an existing entry in the Meraki dashboard, the data is updated once every two hours. Meraki recommends querying LLDP and CDP information at an interval slightly greater than two hours, to ensure that unchanged CDP / LLDP information can be queried consistently. (optional)</param>
		/// <returns>Task of Object</returns>
		[Get("/devices/{serial}/lldpCdp")]
		Task<object> GetLldpCdpAsync(
			[AliasAs("serial")] string serial,
			[AliasAs("timespan")] int? timespan = null,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// getNetworkDeviceLossAndLatencyHistory
		/// </summary>
		/// <remarks>
		/// Get the uplink loss percentage and latency in milliseconds, and goodput in kilobits per second for a wired network device.
		/// </remarks>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="serial"></param>
		/// <param name="ip">The destination IP used to obtain the requested stats. This is required.</param>
		/// <param name="t0">The beginning of the timespan for the data. The maximum lookback period is 365 days from today. (optional)</param>
		/// <param name="t1">The end of the timespan for the data. t1 can be a maximum of 31 days after t0. (optional)</param>
		/// <param name="timespan">The timespan for which the information will be fetched. If specifying timespan, do not specify parameters t0 and t1. The value must be in seconds and be less than or equal to 31 days. The default is 1 day. (optional)</param>
		/// <param name="resolution">The time resolution in seconds for returned data. The valid resolutions are: 60, 600, 3600, 86400. The default is 60. (optional)</param>
		/// <param name="uplink">The WAN uplink used to obtain the requested stats. Valid uplinks are wan1, wan2, cellular. The default is wan1. (optional)</param>
		/// <returns>Task of Object</returns>
		[Get("/devices/{serial}/lossAndLatencyHistory")]
		Task<List<LossAndLatencyHistory>> GetLossAndLatencyHistoryAsync(
			[AliasAs("serial")] string serial,
			[AliasAs("ip")] string ip,
			[AliasAs("t0")] string t0 = null!,
			[AliasAs("t1")] string t1 = null!,
			[AliasAs("timespan")] double? timespan = null,
			[AliasAs("resolution")] int? resolution = null,
			[AliasAs("uplink")] string uplink = null!,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// getNetworkDevicePerformance
		/// </summary>
		/// <remarks>
		/// Return the performance score for a single MX
		/// </remarks>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="serial"></param>
		/// <returns>Task of Object</returns>
		[Get("/devices/{serial}/appliance/performance")]
		Task<object> GetPerformanceAsync(
			[AliasAs("serial")] string serial,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// getNetworkDevices
		/// </summary>
		/// <remarks>
		/// List the devices in a network
		/// </remarks>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <returns>Task of list of Device</returns>
		[Get("/networks/{networkId}/devices")]
		Task<List<Device>> GetAllByNetworkAsync(
			[AliasAs("networkId")] string networkId,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// getOrganizationDevices
		/// </summary>
		/// <remarks>
		/// List the devices in an organization
		/// </remarks>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="organizationId">The Organization id</param>
		/// <param name="perPage">The number of entries per page returned. Acceptable range is 3 - 1000. Default is 1000. (optional)</param>
		/// <param name="startingAfter">A token used by the server to indicate the start of the page. Often this is a timestamp or an ID but it is not limited to those. This parameter should not be defined by client applications. The link for the first, last, prev, or next page in the HTTP Link header should define it. (optional)</param>
		/// <param name="endingBefore">A token used by the server to indicate the end of the page. Often this is a timestamp or an ID but it is not limited to those. This parameter should not be defined by client applications. The link for the first, last, prev, or next page in the HTTP Link header should define it. (optional)</param>
		/// <param name="configurationUpdatedAfter">Filter results by whether or not the device&#39;s configuration has been updated after the given timestamp (optional)</param>
		/// <returns>Task of Object</returns>
		[Get("/organizations/{organizationId}/devices")]
		Task<List<Device>> GetPageByOrganizationAsync(
			[AliasAs("organizationId")] string organizationId,
			[AliasAs("perPage")] int? perPage = null,
			[AliasAs("startingAfter")] string startingAfter = null!,
			[AliasAs("endingBefore")] string endingBefore = null!,
			[AliasAs("configurationUpdatedAfter")] string configurationUpdatedAfter = null!,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// getNetworkDeviceManagementInterfaceSettings
		/// </summary>
		/// <remarks>
		/// Return the management interface settings for a device
		/// </remarks>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="serial"></param>
		/// <returns>Task of list of Device</returns>
		[Get("/devices/{serial}/managementInterfaceSettings")]
		Task<DeviceManagementInterfaceSettings> GetNetworkDeviceManagementInterfaceSettingsAsync(
			[AliasAs("serial")] string serial,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// rebootNetworkDevice
		/// </summary>
		/// <remarks>
		/// Reboot a device
		/// </remarks>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="serial"></param>
		/// <returns>Task of Object</returns>
		[Post("/devices/{serial}/reboot")]
		Task<object> RebootAsync(
			[AliasAs("serial")] string serial,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// removeNetworkDevice
		/// </summary>
		/// <remarks>
		/// Remove a single device
		/// </remarks>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <returns>Task of void</returns>
		[Post("/networks/{networkId}/devices/remove")]
		Task RemoveAsync(
			[AliasAs("networkId")] string networkId,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// updateNetworkDevice
		/// </summary>
		/// <remarks>
		/// Update the attributes of a device
		/// </remarks>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="serial"></param>
		/// <param name="updateNetworkDevice"> (optional)</param>
		/// <returns>Task of Object</returns>
		[Put("/devices/{serial}")]
		Task<Device> UpdateAsync(
			[AliasAs("serial")] string serial,
			[Body] DeviceUpdateRequest updateNetworkDevice,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// cloneOrganizationSwitchDevices
		/// </summary>
		/// <remarks>
		/// Clone port-level and some switch-level configuration settings from a source switch to one or more target switches. Cloned settings include: Aggregation Groups, Power Settings, Multicast Settings, MTU Configuration, STP Bridge priority, Port Mirroring
		/// </remarks>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="organizationId">The Organization id</param>
		/// <param name="cloneOrganizationSwitchDevices"></param>
		/// <returns>Task of Object</returns>
		[Post("/organizations/{organizationId}/switch/devices/clone")]
		Task<CloneOrganizationSwitchDevices> CloneOrganizationSwitchDevices(
			[AliasAs("organizationId")] string organizationId,
			[Body] CloneOrganizationSwitchDevices cloneOrganizationSwitchDevices
			);
	}
}
