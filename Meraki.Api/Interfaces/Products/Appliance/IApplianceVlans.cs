namespace Meraki.Api.Interfaces.Products.Appliance;

public interface IApplianceVlans
{
	/// <summary>
	/// Add a VLAN
	/// </summary>
	/// <param name="networkId">The network id</param>
	/// <param name="vlanCreationRequest"></param>
	[Post("/networks/{networkId}/appliance/vlans")]
	Task<Vlan> CreateNetworkApplianceVlanAsync(
		[AliasAs("networkId")] string networkId,
		[Body] VlanCreationRequest vlanCreationRequest,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Delete a VLAN from a network
	/// </summary>
	/// <param name="networkId">The network id</param>
	/// <param name="vlanId">The VLAN id</param>
	[Delete("/networks/{networkId}/appliance/vlans/{vlanId}")]
	Task DeleteNetworkApplianceVlanAsync(
		[AliasAs("networkId")] string networkId,
		[AliasAs("vlanId")] string vlanId,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Return a VLAN
	/// </summary>
	/// <param name="networkId">The network id</param>
	/// <param name="vlanId">The VLAN id</param>
	[Get("/networks/{networkId}/appliance/vlans/{vlanId}")]
	Task<Vlan> GetNetworkApplianceVlanAsync(
		[AliasAs("networkId")] string networkId,
		[AliasAs("vlanId")] string vlanId,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// List the VLANs for an MX network
	/// </summary>
	/// <param name="networkId">The network id</param>
	[Get("/networks/{networkId}/appliance/vlans")]
	Task<List<Vlan>> GetNetworkApplianceVlansAsync(
		[AliasAs("networkId")] string networkId,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Update a VLAN
	/// </summary>
	/// <param name="networkId">The network id</param>
	/// <param name="vlanId">The VLAN id</param>
	/// <param name="vlanSpec"></param>
	[Put("/networks/{networkId}/appliance/vlans/{vlanId}")]
	Task<Vlan> UpdateNetworkApplianceVlanAsync(
		[AliasAs("networkId")] string networkId,
		[AliasAs("vlanId")] string vlanId,
		[Body] VlanSpec vlanSpec,
		CancellationToken cancellationToken = default);
}
