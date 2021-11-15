namespace Meraki.Api.Interfaces.Products.Wireless;

public interface IWirelessSsidsEapOverride
{
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
}
