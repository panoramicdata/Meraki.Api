namespace Meraki.Api.Products;

public class SwitchRouting
{
	public ISwitchRoutingInterfaces Interfaces { get; internal set; } = null!;
	public ISwitchRoutingMulticast Multicast { get; internal set; } = null!;
	public ISwitchRoutingOspf Ospf { get; internal set; } = null!;
	public ISwitchRoutingStaticRoutes StaticRoutes { get; internal set; } = null!;
}
