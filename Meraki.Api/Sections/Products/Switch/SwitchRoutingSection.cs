namespace Meraki.Api.Sections.Products.Switch;

public class SwitchRoutingSection
{
	public ISwitchRoutingInterfaces Interfaces { get; internal set; } = null!;
	public ISwitchRoutingMulticast Multicast { get; internal set; } = null!;
	public ISwitchRoutingOspf Ospf { get; internal set; } = null!;
	public ISwitchRoutingStaticRoutes StaticRoutes { get; internal set; } = null!;
}
