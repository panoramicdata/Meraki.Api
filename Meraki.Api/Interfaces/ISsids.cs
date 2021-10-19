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
	public interface ISsids
	{
		/// <summary>
		/// Return the SSID statuses of an access point
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="serial">The serial number</param>
		[Get("/devices/{serial}/wireless/status")]
		Task<WirelessStatus> GetNetworkDeviceWirelessStatusAsync(
			[AliasAs("serial")] string serial,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Return a single MR SSID
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="number">The SSID number</param>
		[Get("/networks/{networkId}/wireless/ssids/{number}")]
		Task<NetworkSsid> GetAsync(
			[AliasAs("networkId")] string networkId,
			[AliasAs("number")] string number,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// List the MR SSIDs in a network
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		[Get("/networks/{networkId}/wireless/ssids")]
		Task<List<NetworkSsid>> GetAllAsync(
			[AliasAs("networkId")] string networkId,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// Update the attributes of an MR SSID
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="number">The SSID number</param>
		/// <param name="updateNetworkSsid"></param>
		[Put("/networks/{networkId}/wireless/ssids/{number}")]
		Task<NetworkSsid> UpdateAsync(
			[AliasAs("networkId")] string networkId,
			[AliasAs("number")] string number,
			[Body] SsidUpdateRequest updateNetworkSsid,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// List all Identity PSKs in a wireless network
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="number">The SSID number</param>
		[Get("/networks/{networkId}/wireless/ssids/{number}/identityPsks")]
		Task<List<IdentityPsks>> GetNetworkWirelessSsidIdentityPsksAsync(
			[AliasAs("networkId")] string networkId,
			[AliasAs("number")] string number,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// List all Identity PSKs in a wireless network
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="number">The SSID number</param>
		/// <param name="createNetworkWirelessSsidIdentityPsk"></param>
		[Post("/networks/{networkId}/wireless/ssids/{number}/identityPsks")]
		Task<IdentityPsks> CreateNetworkWirelessSsidIdentityPskAsync(
			[AliasAs("networkId")] string networkId,
			[AliasAs("number")] string number,
			[Body] IdentityPsks createNetworkWirelessSsidIdentityPsk,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Return an Identity PSK
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="number">The SSID number</param>
		/// <param name="identityPskId">The identity psk id</param>
		[Get("/networks/{networkId}/wireless/ssids/{number}/identityPsks/{identityPskId}")]
		Task<IdentityPsks> GetNetworkWirelessSsidIdentityPskAsync(
			[AliasAs("networkId")] string networkId,
			[AliasAs("number")] string number,
			[AliasAs("identityPskId")] string identityPskId,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Update an Identity PSK
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="number">The SSID number</param>
		/// <param name="identityPskId">The identity psk id</param>
		/// <param name="updateNetworkWirelessSsidIdentityPsk"></param>
		[Put("/networks/{networkId}/wireless/ssids/{number}/identityPsks/{identityPskId}")]
		Task<IdentityPsks> UpdateNetworkWirelessSsidIdentityPskAsync(
			[AliasAs("networkId")] string networkId,
			[AliasAs("number")] string number,
			[AliasAs("identityPskId")] string identityPskId,
			[Body] IdentityPsks updateNetworkWirelessSsidIdentityPsk,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Delete an Identity PSK
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="number">The SSID number</param>
		/// <param name="identityPskId">The identity psk id</param>
		[Delete("/networks/{networkId}/wireless/ssids/{number}/identityPsks/{identityPskId}")]
		Task DeleteNetworkWirelessSsidIdentityPskAsync(
			[AliasAs("networkId")] string networkId,
			[AliasAs("number")] string number,
			[AliasAs("identityPskId")] string identityPskId,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// Modify the splash page settings for the given SSID
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="number">The SSID number</param>
		/// <param name="updateNetworkWirelessSsidSplashSettings"></param>
		[Put("/networks/{networkId}/wireless/ssids/{number}/splash/settings")]
		Task<SsidSplashSettings> UpdateNetworkWirelessSsidSplashSettingsAsync(
			[AliasAs("networkId")] string networkId,
			[AliasAs("number")] string number,
			[Body] SsidSplashSettings updateNetworkWirelessSsidSplashSettings,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Display the splash page settings for the given SSID
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="number">The SSID number</param>
		[Get("/networks/{networkId}/wireless/ssids/{number}/splash/settings")]
		Task<SsidSplashSettings> GetNetworkWirelessSsidSplashSettingsAsync(
			[AliasAs("networkId")] string networkId,
			[AliasAs("number")] string number,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// List the device type group policies for the SSID
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="number">The SSID number</param>
		[Get("/networks/{networkId}/wireless/ssids/{number}/deviceTypeGroupPolicies")]
		Task<DeviceTypeGroupPolicies> GetNetworkWirelessSsidDeviceTypeGroupPoliciesAsync(
			[AliasAs("networkId")] string networkId,
			[AliasAs("number")] string number,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Update the device type group policies for the SSID
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="number">The SSID number</param>
		[Put("/networks/{networkId}/wireless/ssids/{number}/deviceTypeGroupPolicies")]
		Task<DeviceTypeGroupPolicies> UpdateNetworkWirelessSsidDeviceTypeGroupPoliciesAsync(
			[AliasAs("networkId")] string networkId,
			[AliasAs("number")] string number,
			[Body] DeviceTypeGroupPolicies updateNetworkWirelessSsidDeviceTypeGroupPolicies,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// List the Bonjour forwarding setting and rules for the SSID
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="number">The SSID number</param>
		[Get("/networks/{networkId}/wireless/ssids/{number}/bonjourForwarding")]
		Task<BonjourForwarding> GetNetworkWirelessSsidBonjourForwardingAsync(
			[AliasAs("networkId")] string networkId,
			[AliasAs("number")] string number,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Update the bonjour forwarding setting and rules for the SSID
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="number">The SSID number</param>
		/// <param name="updateNetworkWirelessSsidBonjourForwarding"></param>
		[Put("/networks/{networkId}/wireless/ssids/{number}/bonjourForwarding")]
		Task<BonjourForwarding> UpdateNetworkWirelessSsidBonjourForwardingAsync(
			[AliasAs("networkId")] string networkId,
			[AliasAs("number")] string number,
			[Body] BonjourForwarding updateNetworkWirelessSsidBonjourForwarding,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// List the VPN settings for the SSID.
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="number">The SSID number</param>
		[Get("/networks/{networkId}/wireless/ssids/{number}/vpn")]
		Task<VpnSettings> GetNetworkWirelessSsidVpnAsync(
			[AliasAs("networkId")] string networkId,
			[AliasAs("number")] string number,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Update the VPN settings for the SSID
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="number">The SSID number</param>
		/// <param name="updateNetworkWirelessSsidVpn"></param>
		[Put("/networks/{networkId}/wireless/ssids/{number}/vpn")]
		Task<VpnSettings> UpdateNetworkWirelessSsidVpnAsync(
			[AliasAs("networkId")] string networkId,
			[AliasAs("number")] string number,
			[Body] VpnSettings updateNetworkWirelessSsidVpn,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// List the outage schedule for the SSID
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="number">The SSID number</param>
		[Get("/networks/{networkId}/wireless/ssids/{number}/schedules")]
		Task<Schedules> GetNetworkWirelessSsidSchedulesAsync(
			[AliasAs("networkId")] string networkId,
			[AliasAs("number")] string number,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Update the outage schedule for the SSID
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="number">The SSID number</param>
		[Put("/networks/{networkId}/wireless/ssids/{number}/schedules")]
		Task<Schedules> UpdateNetworkWirelessSsidSchedulesAsync(
			[AliasAs("networkId")] string networkId,
			[AliasAs("number")] string number,
			[Body] Schedules updateNetworkWirelessSsidSchedules,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Return the EAP overridden parameters for an SSID
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="number">The SSID number</param>
		[Get("/networks/{networkId}/wireless/ssids/{number}/eapOverride")]
		Task<EapOverride> GetNetworkWirelessSsidEapOverrideAsync(
			[AliasAs("networkId")] string networkId,
			[AliasAs("number")] string number,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Update the EAP overridden parameters for an SSID.
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="number">The SSID number</param>
		[Put("/networks/{networkId}/wireless/ssids/{number}/eapOverride")]
		Task<EapOverride> UpdateNetworkWirelessSsidEapOverrideAsync(
			[AliasAs("networkId")] string networkId,
			[AliasAs("number")] string number,
			[Body] EapOverride eapOverrideUpdateRequest,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Return the Hotspot 2.0 settings for an SSID
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="number">The SSID number</param>
		[Get("/networks/{networkId}/wireless/ssids/{number}/hotspot20")]
		Task<Hotspot20> GetNetworkWirelessSsidHotspot20Async(
			[AliasAs("networkId")] string networkId,
			[AliasAs("number")] string number,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Update the Hotspot 2.0 settings of an SSID
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="number">The SSID number</param>
		/// <param name="hotspot20"></param>
		[Put("/networks/{networkId}/wireless/ssids/{number}/hotspot20")]
		Task<Hotspot20> UpdateNetworkWirelessSsidHotspot20Async(
			[AliasAs("networkId")] string networkId,
			[AliasAs("number")] string number,
			[Body] Hotspot20 hotspot20,
			CancellationToken cancellationToken = default
			);
	}
}
