namespace Meraki.Api.Interfaces.Products.Wireless;

public interface IWirelessSsidsDeviceTypeGroupPolicies
{
	/// <summary>
	/// List the device type group policies for the SSID
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="number">The SSID number</param>
	/// <param name="cancellationToken"></param>
	[Get("/networks/{networkId}/wireless/ssids/{number}/deviceTypeGroupPolicies")]
	Task<DeviceTypeGroupPolicies> GetNetworkWirelessSsidDeviceTypeGroupPoliciesAsync(
		string networkId,
		string number,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Update the device type group policies for the SSID
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="number">The SSID number</param>
	/// <param name="updateNetworkWirelessSsidDeviceTypeGroupPolicies"></param>
	/// <param name="cancellationToken"></param>
	[Put("/networks/{networkId}/wireless/ssids/{number}/deviceTypeGroupPolicies")]
	Task<DeviceTypeGroupPolicies> UpdateNetworkWirelessSsidDeviceTypeGroupPoliciesAsync(
		string networkId,
		string number,
		[Body] DeviceTypeGroupPolicies updateNetworkWirelessSsidDeviceTypeGroupPolicies,
		CancellationToken cancellationToken = default
		);
}
