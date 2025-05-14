namespace Meraki.Api.Interfaces.General.Networks;

public interface INetworksSnmp
{
	/// <summary>
	/// Return the SNMP settings for a network
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="cancellationToken">The Cancellation Token</param>
	[Get("/networks/{networkId}/snmp")]
	Task<NetworkSnmpSetting> GetNetworkSnmpAsync(
		string networkId,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Update the SNMP settings for a network
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="networkSnmpSetting"></param>
	/// <param name="cancellationToken">The Cancellation Token</param>
	[Put("/networks/{networkId}/snmp")]
	Task<NetworkSnmpSetting> UpdateNetworkSnmpAsync(
		string networkId,
		[Body] NetworkSnmpSetting networkSnmpSetting,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Update the SNMP trap configuration for the specified network
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="networkSnmpTrap"></param>
	/// <param name="cancellationToken">The Cancellation Token</param>
	/// <returns></returns>
	[Put("/networks/{networkId}/snmp/traps")]
	Task<NetworkSnmpTrapResponse> UpdateNetworkSnmpTrapsAsync(
		string networkId,
		[Body] NetworkSnmpTrapUpdateRequest networkSnmpTrap,
		CancellationToken cancellationToken = default
		);
}
