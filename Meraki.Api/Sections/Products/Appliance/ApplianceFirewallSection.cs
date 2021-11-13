namespace Meraki.Api.Sections.Products.Appliance
{
	public class ApplianceFirewallSection
	{
		public IApplianceFirewallCellularFirewallRules CellularFirewallRules { get; internal set; } = null!;
		public IApplianceFirewallFirewalledServices FirewalledServices { get; internal set; } = null!;
		public IApplianceFirewallInboundFirewallRules InboundFirewallRules { get; internal set; } = null!;
		public IApplianceFirewallL3FirewallRules L3FirewallRules { get; internal set; } = null!;
		public IApplianceFirewallL7FirewallRules L7FirewallRules { get; internal set; } = null!;
		public IApplianceFirewallOneToManyNatRules OneToManyNatRules { get; internal set; } = null!;
		public IApplianceFirewallOneToOneNatRules OneToOneNatRules { get; internal set; } = null!;
		public IApplianceFirewallPortForwardingRules PortForwardingRules { get; internal set; } = null!;
	}
}
