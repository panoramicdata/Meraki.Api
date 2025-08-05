namespace Meraki.Api.Interfaces.Products.Wireless;

public interface IWirelessSsidsIdentityPsks
{
	/// <summary>
	/// List all Identity PSKs in a wireless network
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="number">The SSID number</param>
	/// <param name="cancellationToken"></param>
	[Get("/networks/{networkId}/wireless/ssids/{number}/identityPsks")]
	Task<List<IdentityPsk>> GetNetworkWirelessSsidIdentityPsksAsync(
		string networkId,
		string number,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// List all Identity PSKs in a wireless network
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="number">The SSID number</param>
	/// <param name="createNetworkWirelessSsidIdentityPsk"></param>
	/// <param name="cancellationToken"></param>
	[Post("/networks/{networkId}/wireless/ssids/{number}/identityPsks")]
	Task<IdentityPsk> CreateNetworkWirelessSsidIdentityPskAsync(
		string networkId,
		string number,
		[Body] IdentityPsk createNetworkWirelessSsidIdentityPsk,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Return an Identity PSK
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="number">The SSID number</param>
	/// <param name="identityPskId">The identity psk id</param>
	/// <param name="cancellationToken"></param>
	[Get("/networks/{networkId}/wireless/ssids/{number}/identityPsks/{identityPskId}")]
	Task<IdentityPsk> GetNetworkWirelessSsidIdentityPskAsync(
		string networkId,
		string number,
		string identityPskId,
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
	/// <param name="cancellationToken"></param>
	[Put("/networks/{networkId}/wireless/ssids/{number}/identityPsks/{identityPskId}")]
	Task<IdentityPsk> UpdateNetworkWirelessSsidIdentityPskAsync(
		string networkId,
		string number,
		string identityPskId,
		[Body] IdentityPsk updateNetworkWirelessSsidIdentityPsk,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Delete an Identity PSK
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="number">The SSID number</param>
	/// <param name="identityPskId">The identity psk id</param>
	/// <param name="cancellationToken"></param>
	[Delete("/networks/{networkId}/wireless/ssids/{number}/identityPsks/{identityPskId}")]
	Task DeleteNetworkWirelessSsidIdentityPskAsync(
		string networkId,
		string number,
		string identityPskId,
		CancellationToken cancellationToken = default);
}
