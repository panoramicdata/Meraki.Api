namespace Meraki.Api.Interfaces.General.Networks;

public interface INetworksSnmp
{
	/// <summary>
	/// Return the SNMP settings for a network
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	[Get("/networks/{networkId}/snmp")]
	Task<NetworkSnmpSetting> GetSnmpAsync(
		[AliasAs("networkId")] string networkId,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Update the SNMP settings for a network
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="networkSnmpSetting"></param>
	[Put("/networks/{networkId}/snmp")]
	Task<NetworkSnmpSetting> UpdateSnmpAsync(
		[AliasAs("networkId")] string networkId,
		[Body] NetworkSnmpSetting networkSnmpSetting,
		CancellationToken cancellationToken = default
		);
}
