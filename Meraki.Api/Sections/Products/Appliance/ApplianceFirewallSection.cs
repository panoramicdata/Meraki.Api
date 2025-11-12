namespace Meraki.Api.Sections.Products.Appliance;

/// <summary>
/// Provides access to appliance firewall API endpoints
/// </summary>
public class ApplianceFirewallSection
{
	/// <summary>
	/// Return the cellular firewall rules for an MX network
	/// </summary>

	public IApplianceFirewallCellularFirewallRules CellularFirewallRules { get; internal set; } = null!;
	/// <summary>
	/// Return the inbound cellular firewall rules for an MX network
	/// </summary>

	public IApplianceFirewallInboundCellularFirewallRules InboundCellularFirewallRules { get; internal set; } = null!;
	/// <summary>
	/// List the appliance services and their accessibility rules
	/// </summary>

	public IApplianceFirewallFirewalledServices FirewalledServices { get; internal set; } = null!;
	/// <summary>
	/// Return the inbound firewall rules for an MX network
	/// </summary>

	public IApplianceFirewallInboundFirewallRules InboundFirewallRules { get; internal set; } = null!;
	/// <summary>
	/// Return the L3 firewall rules for an MX network
	/// </summary>

	public IApplianceFirewallL3FirewallRules L3FirewallRules { get; internal set; } = null!;
	/// <summary>
	/// List the MX L7 firewall rules for an MX network
	/// </summary>

	public IApplianceFirewallL7FirewallRules L7FirewallRules { get; internal set; } = null!;
	/// <summary>
	/// List Static Multicasting forwarding settings for MX networks
	/// </summary>

	public IApplianceFirewallMulticastForwarding MulticastForwarding { get; internal set; } = null!;
	/// <summary>
	/// Return the 1:Many NAT mapping rules for an MX network
	/// </summary>

	public IApplianceFirewallOneToManyNatRules OneToManyNatRules { get; internal set; } = null!;
	/// <summary>
	/// Return the 1:1 NAT mapping rules for an MX network
	/// </summary>

	public IApplianceFirewallOneToOneNatRules OneToOneNatRules { get; internal set; } = null!;
	/// <summary>
	/// Return the port forwarding rules for an MX network
	/// </summary>

	public IApplianceFirewallPortForwardingRules PortForwardingRules { get; internal set; } = null!;
	/// <summary>
	/// Return the firewall settings for this network
	/// </summary>

	public IApplianceFirewallSettings ApplianceFirewallSettings { get; internal set; } = null!;
}
