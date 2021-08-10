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
		/// getNetworkDeviceWirelessStatus
		/// </summary>
		/// <remarks>
		/// Return the SSID statuses of an access point
		/// </remarks>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="serial"></param>
		/// <returns>Task of Object</returns>
		[Get("/devices/{serial}/wireless/status")]
		Task<object> GetNetworkDeviceWirelessStatus(
			[AliasAs("serial")]string serial
			);

		/// <summary>
		/// getNetworkSsid
		/// </summary>
		/// <remarks>
		/// Return a single MR SSID
		/// </remarks>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <param name="number"></param>
		/// <returns>Task of Object</returns>
		[Get("/networks/{networkId}/wireless/ssids/{number}")]
		Task<NetworkSsid> GetAsync(
			[AliasAs("networkId")]string networkId,
			[AliasAs("number")]string number,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// getNetworkSsids
		/// </summary>
		/// <remarks>
		/// List the MR SSIDs in a network
		/// </remarks>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <returns>Task of Object</returns>
		[Get("/networks/{networkId}/wireless/ssids")]
		Task<List<NetworkSsid>> GetAllAsync(
			[AliasAs("networkId")]string networkId,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// updateNetworkSsid
		/// </summary>
		/// <remarks>
		/// Update the attributes of an MR SSID
		/// </remarks>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <param name="number"></param>
		/// <param name="updateNetworkSsid"> (optional)</param>
		/// <returns>Task of Object</returns>
		[Put("/networks/{networkId}/wireless/ssids/{number}")]
		Task<NetworkSsid> UpdateAsync(
			[AliasAs("networkId")]string networkId,
			[AliasAs("number")]string number,
			[Body]SsidUpdateRequest updateNetworkSsid,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// getNetworkWirelessSsidIdentityPsks
		/// </summary>
		/// <remarks>
		/// List all Identity PSKs in a wireless network
		/// </remarks>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <param name="number"></param>
		/// <returns>Task of Object</returns>
		[Get("/networks/{networkId}/wireless/ssids/{number}/identityPsks")]
		Task<List<IdentityPsks>> GetNetworkWirelessSsidIdentityPsks(
			[AliasAs("networkId")] string networkId,
			[AliasAs("number")] string number
			);

		/// <summary>
		/// createNetworkWirelessSsidIdentityPsk
		/// </summary>
		/// <remarks>
		/// List all Identity PSKs in a wireless network
		/// </remarks>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <param name="number"></param>
		/// <param name="createNetworkWirelessSsidIdentityPsk"></param>
		/// <returns>Task of Object</returns>
		[Post("/networks/{networkId}/wireless/ssids/{number}/identityPsks")]
		Task<IdentityPsks> CreateNetworkWirelessSsidIdentityPsk(
			[AliasAs("networkId")] string networkId,
			[AliasAs("number")] string number,
			[Body]IdentityPsks createNetworkWirelessSsidIdentityPsk
			);

		/// <summary>
		/// getNetworkWirelessSsidIdentityPsk
		/// </summary>
		/// <remarks>
		/// Return an Identity PSK
		/// </remarks>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <param name="number"></param>
		/// <param name="identityPskId"></param>
		/// <returns>Task of Object</returns>
		[Get("/networks/{networkId}/wireless/ssids/{number}/identityPsks/{identityPskId}")]
		Task<IdentityPsks> GetNetworkWirelessSsidIdentityPsk(
			[AliasAs("networkId")] string networkId,
			[AliasAs("number")] string number,
			[AliasAs("identityPskId")] string identityPskId
			);

		/// <summary>
		/// updateNetworkWirelessSsidIdentityPsk
		/// </summary>
		/// <remarks>
		/// Update an Identity PSK
		/// </remarks>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <param name="number"></param>
		/// <param name="identityPskId"></param>
		/// <param name="updateNetworkWirelessSsidIdentityPsk"></param>
		/// <returns>Task of Object</returns>
		[Put("/networks/{networkId}/wireless/ssids/{number}/identityPsks/{identityPskId}")]
		Task<IdentityPsks> UpdateNetworkWirelessSsidIdentityPsk(
			[AliasAs("networkId")] string networkId,
			[AliasAs("number")] string number,
			[AliasAs("identityPskId")] string identityPskId,
			[Body]IdentityPsks updateNetworkWirelessSsidIdentityPsk
			);

		/// <summary>
		/// deleteNetworkWirelessSsidIdentityPsk
		/// </summary>
		/// <remarks>
		/// Delete an Identity PSK
		/// </remarks>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <param name="number"></param>
		/// <param name="identityPskId"></param>
		/// <returns>Task of void</returns>
		[Delete("/networks/{networkId}/wireless/ssids/{number}/identityPsks/{identityPskId}")]
		Task DeleteNetworkWirelessSsidIdentityPsk(
			[AliasAs("networkId")] string networkId,
			[AliasAs("number")] string number,
			[AliasAs("identityPskId")] string identityPskId,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// updateNetworkWirelessSsidSplashSettings
		/// </summary>
		/// <remarks>
		/// Modify the splash page settings for the given SSID
		/// </remarks>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <param name="number"></param>
		/// <param name="updateNetworkWirelessSsidSplashSettings"></param>
		/// <returns>Task of Object</returns>
		[Put("/networks/{networkId}/wireless/ssids/{number}/splash/settings")]
		Task<SsidSplashSettings> UpdateNetworkWirelessSsidSplashSettings(
			[AliasAs("networkId")] string networkId,
			[AliasAs("number")] string number,
			[Body]SsidSplashSettings updateNetworkWirelessSsidSplashSettings
			);

		/// <summary>
		/// getNetworkWirelessSsidSplashSettings
		/// </summary>
		/// <remarks>
		/// Display the splash page settings for the given SSID
		/// </remarks>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <param name="number"></param>
		/// <returns>Task of Object</returns>
		[Get("/networks/{networkId}/wireless/ssids/{number}/splash/settings")]
		Task<SsidSplashSettings> GetNetworkWirelessSsidSplashSettings(
			[AliasAs("networkId")] string networkId,
			[AliasAs("number")] string number
			);

		/// <summary>
		/// getNetworkWirelessSsidDeviceTypeGroupPolicies
		/// </summary>
		/// <remarks>
		/// List the device type group policies for the SSID
		/// </remarks>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <param name="number"></param>
		/// <returns>Task of Object</returns>
		[Get("/networks/{networkId}/wireless/ssids/{number}/deviceTypeGroupPolicies")]
		Task<DeviceTypeGroupPolicies> GetNetworkWirelessSsidDeviceTypeGroupPolicies(
			[AliasAs("networkId")] string networkId,
			[AliasAs("number")] string number
			);

		/// <summary>
		/// updateNetworkWirelessSsidDeviceTypeGroupPolicies
		/// </summary>
		/// <remarks>
		/// Update the device type group policies for the SSID
		/// </remarks>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <param name="number"></param>
		/// <returns>Task of Object</returns>
		[Get("/networks/{networkId}/wireless/ssids/{number}/deviceTypeGroupPolicies")]
		Task<DeviceTypeGroupPolicies> UpdateNetworkWirelessSsidDeviceTypeGroupPolicies(
			[AliasAs("networkId")] string networkId,
			[AliasAs("number")] string number,
			[Body]DeviceTypeGroupPolicies updateNetworkWirelessSsidDeviceTypeGroupPolicies
			);

		/// <summary>
		/// getNetworkWirelessSsidBonjourForwarding
		/// </summary>
		/// <remarks>
		/// List the Bonjour forwarding setting and rules for the SSID
		/// </remarks>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <param name="number"></param>
		/// <returns>Task of Object</returns>
		[Get("/networks/{networkId}/wireless/ssids/{number}/bonjourForwarding")]
		Task<BonjourForwarding> GetNetworkWirelessSsidBonjourForwarding(
			[AliasAs("networkId")] string networkId,
			[AliasAs("number")] string number
			);

		/// <summary>
		/// updateNetworkWirelessSsidBonjourForwarding
		/// </summary>
		/// <remarks>
		/// Update the bonjour forwarding setting and rules for the SSID
		/// </remarks>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <param name="number"></param>
		/// <param name="updateNetworkWirelessSsidBonjourForwarding"></param>
		/// <returns>Task of Object</returns>
		[Put("/networks/{networkId}/wireless/ssids/{number}/bonjourForwarding")]
		Task<BonjourForwarding> UpdateNetworkWirelessSsidBonjourForwarding(
			[AliasAs("networkId")] string networkId,
			[AliasAs("number")] string number,
			[Body]BonjourForwarding updateNetworkWirelessSsidBonjourForwarding
			);

		/// <summary>
		/// getNetworkWirelessSsidVpn
		/// </summary>
		/// <remarks>
		/// List the VPN settings for the SSID.
		/// </remarks>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <param name="number"></param>
		/// <returns>Task of Object</returns>
		[Get("/networks/{networkId}/wireless/ssids/{number}/vpn")]
		Task<VpnSettings> GetNetworkWirelessSsidVpn(
			[AliasAs("networkId")] string networkId,
			[AliasAs("number")] string number
			);

		/// <summary>
		/// updateNetworkWirelessSsidVpn
		/// </summary>
		/// <remarks>
		/// Update the VPN settings for the SSID
		/// </remarks>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <param name="number"></param>
		/// <param name="updateNetworkWirelessSsidVpn"></param>
		/// <returns>Task of Object</returns>
		[Put("/networks/{networkId}/wireless/ssids/{number}/vpn")]
		Task<VpnSettings> UpdateNetworkWirelessSsidVpn(
			[AliasAs("networkId")] string networkId,
			[AliasAs("number")] string number,
			[Body]VpnSettings updateNetworkWirelessSsidVpn
			);

		/// <summary>
		/// getNetworkWirelessSsidSchedules
		/// </summary>
		/// <remarks>
		/// List the outage schedule for the SSID
		/// </remarks>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <param name="number"></param>
		/// <returns>Task of Object</returns>
		[Get("/networks/{networkId}/wireless/ssids/{number}/schedules")]
		Task<Schedules> GetNetworkWirelessSsidSchedules(
			[AliasAs("networkId")] string networkId,
			[AliasAs("number")] string number
			);

		/// <summary>
		/// updateNetworkWirelessSsidSchedules
		/// </summary>
		/// <remarks>
		/// Update the outage schedule for the SSID
		/// </remarks>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <param name="number"></param>
		/// <returns>Task of Object</returns>
		[Put("/networks/{networkId}/wireless/ssids/{number}/schedules")]
		Task<Schedules> UpdateNetworkWirelessSsidSchedules(
			[AliasAs("networkId")] string networkId,
			[AliasAs("number")] string number,
			[Body]Schedules updateNetworkWirelessSsidSchedules
			);

		/// <summary>
		/// getNetworkWirelessSsidEapOverride
		/// </summary>
		/// <remarks>
		/// Return the EAP overridden parameters for an SSID
		/// </remarks>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <param name="number"></param>
		/// <returns>Task of Object</returns>
		[Get("/networks/{networkId}/wireless/ssids/{number}/eapOverride")]
		Task<EapOverride> GetNetworkWirelessSsidEapOverride(
			[AliasAs("networkId")] string networkId,
			[AliasAs("number")] string number
			);

		/// <summary>
		/// updateNetworkWirelessSsidEapOverride
		/// </summary>
		/// <remarks>
		/// Update the EAP overridden parameters for an SSID.
		/// </remarks>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <param name="number"></param>
		/// <returns>Task of Object</returns>
		[Put("/networks/{networkId}/wireless/ssids/{number}/eapOverride")]
		Task<EapOverride> UpdateNetworkWirelessSsidEapOverride(
			[AliasAs("networkId")] string networkId,
			[AliasAs("number")] string number,
			[Body]EapOverride EapOverrideUpdateRequest
			);

		/// <summary>
		/// getNetworkWirelessSsidHotspot20
		/// </summary>
		/// <remarks>
		/// Return the Hotspot 2.0 settings for an SSID
		/// </remarks>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <param name="number"></param>
		/// <returns>Task of Object</returns>
		[Get("/networks/{networkId}/wireless/ssids/{number}/hotspot20")]
		Task<Hotspot20> GetNetworkWirelessSsidHotspot20(
			[AliasAs("networkId")] string networkId,
			[AliasAs("number")] string number
			);

		/// <summary>
		/// updateNetworkWirelessSsidHotspot20
		/// </summary>
		/// <remarks>
		/// Update the Hotspot 2.0 settings of an SSID
		/// </remarks>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <param name="number"></param>
		/// <param name="hotspot20"></param>
		/// <returns>Task of Object</returns>
		[Put("/networks/{networkId}/wireless/ssids/{number}/hotspot20")]
		Task<Hotspot20> UpdateNetworkWirelessSsidHotspot20(
			[AliasAs("networkId")] string networkId,
			[AliasAs("number")] string number,
			[Body]Hotspot20 hotspot20
			);
	}
}
