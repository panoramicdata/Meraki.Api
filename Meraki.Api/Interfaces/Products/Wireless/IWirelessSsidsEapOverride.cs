﻿namespace Meraki.Api.Interfaces.Products.Wireless;

public interface IWirelessSsidsEapOverride
{
	/// <summary>
	/// Return the EAP overridden parameters for an SSID
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="number">The SSID number</param>
	/// <param name="cancellationToken"></param>
	[Get("/networks/{networkId}/wireless/ssids/{number}/eapOverride")]
	Task<EapOverride> GetNetworkWirelessSsidEapOverrideAsync(
		string networkId,
		string number,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Update the EAP overridden parameters for an SSID.
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="number">The SSID number</param>
	/// <param name="eapOverrideUpdateRequest"></param>
	/// <param name="cancellationToken"></param>
	[Put("/networks/{networkId}/wireless/ssids/{number}/eapOverride")]
	Task<EapOverride> UpdateNetworkWirelessSsidEapOverrideAsync(
		string networkId,
		string number,
		[Body] EapOverrideUpdateRequest eapOverrideUpdateRequest,
		CancellationToken cancellationToken = default
		);
}
