namespace Meraki.Api.Interfaces.General.Networks;

public interface INetworksPiiPiiKeys
{
	/// <summary>
	/// List the keys required to access Personally Identifiable Information (PII) for a given identifier
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="username">The username of a Systems Manager user (optional)</param>
	/// <param name="email">The email of a network user account or a Systems Manager device (optional)</param>
	/// <param name="mac">The MAC of a network client device or a Systems Manager device (optional)</param>
	/// <param name="serial">The serial of a Systems Manager device (optional)</param>
	/// <param name="imei">The IMEI of a Systems Manager device (optional)</param>
	/// <param name="bluetoothMac">The MAC of a Bluetooth client (optional)</param>
	[ApiOperationId("getNetworkPiiPiiKeys")]
	[Get("/networks/{networkId}/pii/piiKeys")]
	Task<PiiKeys> GetNetworkPiiPiiKeysAsync(
		string networkId,
		string username = null!,
		string email = null!,
		string mac = null!,
		string serial = null!,
		string imei = null!,
		string bluetoothMac = null!,
		CancellationToken cancellationToken = default
		);
}
