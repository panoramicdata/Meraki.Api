namespace Meraki.Api.Interfaces.Products.Appliance;

/// <summary>
/// I Appliance Vlans
/// </summary>
public interface IApplianceVlans
{
	/// <summary>
	/// Add a VLAN
	/// </summary>
	/// <param name="networkId">The network id</param>
	/// <param name="vlanCreationRequest"></param>
	/// <param name="cancellationToken"></param>
	[Post("/networks/{networkId}/appliance/vlans")]
	Task<Vlan> CreateNetworkApplianceVlanAsync(
		string networkId,
		[Body] VlanCreationRequest vlanCreationRequest,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Delete a VLAN from a network
	/// </summary>
	/// <param name="networkId">The network id</param>
	/// <param name="vlanId">The VLAN id</param>
	/// <param name="cancellationToken"></param>
	[Delete("/networks/{networkId}/appliance/vlans/{vlanId}")]
	Task DeleteNetworkApplianceVlanAsync(
		string networkId,
		string vlanId,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Return a VLAN
	/// </summary>
	/// <param name="networkId">The network id</param>
	/// <param name="vlanId">The VLAN id</param>
	/// <param name="cancellationToken"></param>
	[Get("/networks/{networkId}/appliance/vlans/{vlanId}")]
	Task<Vlan> GetNetworkApplianceVlanAsync(
		string networkId,
		string vlanId,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// List the VLANs for an MX network
	/// </summary>
	/// <param name="networkId">The network id</param>
	/// <param name="cancellationToken"></param>
	[Get("/networks/{networkId}/appliance/vlans")]
	Task<List<Vlan>> GetNetworkApplianceVlansAsync(
		string networkId,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Update a VLAN
	/// </summary>
	/// <param name="networkId">The network id</param>
	/// <param name="vlanId">The VLAN id</param>
	/// <param name="vlanSpec"></param>
	/// <param name="cancellationToken"></param>
	[Put("/networks/{networkId}/appliance/vlans/{vlanId}")]
	Task<Vlan> UpdateNetworkApplianceVlanAsync(
		string networkId,
		string vlanId,
		[Body] VlanSpec vlanSpec,
		CancellationToken cancellationToken = default);
}
