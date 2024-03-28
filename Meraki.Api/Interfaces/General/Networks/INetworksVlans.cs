namespace Meraki.Api.Interfaces.General.Networks;

public interface INetworksVlans
{
	/// <summary>
	/// Returns the enabled status of VLANs for the network
	/// </summary>
	/// <param name="networkId">Network ID</param>
	[ApiOperationId("getNetworkVlansEnabledState")]
	[Get("/networks/{networkId}/vlansEnabledState")]
	Task<NetworkVlansEnabledState> GetNetworkVlansEnabledStateAsync(
		string networkId,
		CancellationToken cancellationToken = default
		);
}
