namespace Meraki.Api.Interfaces.General.Networks;

public interface INetworksPiiSmOwnersForKey
{
	/// <summary>
	/// Given a piece of Personally Identifiable Information (PII), return the Systems Manager owner ID(s) associated with that identifier
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="username">The username of a Systems Manager user (optional)</param>
	/// <param name="email">The email of a network user account or a Systems Manager device (optional)</param>
	/// <param name="mac">The MAC of a network client device or a Systems Manager device (optional)</param>
	/// <param name="serial">The serial of a Systems Manager device (optional)</param>
	/// <param name="imei">The IMEI of a Systems Manager device (optional)</param>
	/// <param name="bluetoothMac">The MAC of a Bluetooth client (optional)</param>
	[ApiOperationId("getNetworkPiiSmOwnersForKey")]
	[Get("/networks/{networkId}/pii/smOwnersForKey")]
	Task<PiiSmKey> GetNetworkPiiSmOwnersForKeyAsync(
		[AliasAs("networkId")] string networkId,
		[AliasAs("username")] string username = null!,
		[AliasAs("email")] string email = null!,
		[AliasAs("mac")] string mac = null!,
		[AliasAs("serial")] string serial = null!,
		[AliasAs("imei")] string imei = null!,
		[AliasAs("bluetoothMac")] string bluetoothMac = null!,
		CancellationToken cancellationToken = default);
}
