namespace Meraki.Api.Interfaces.Products.Wireless;

public interface IWirelessSsidsIdentityPsks
{
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

}
