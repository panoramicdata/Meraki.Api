namespace Meraki.Api.Sections.Products.Switch;

/// <summary>
/// Provides access to switch routing API endpoints
/// </summary>
public class SwitchRoutingSection
{
	/// <summary>
	/// List layer 3 interfaces for a switch. Those for a stack may be found under switch stack routing.
	/// </summary>

	public ISwitchRoutingInterfaces Interfaces { get; internal set; } = null!;
	/// <summary>
	/// Return multicast settings for a network
	/// </summary>

	public ISwitchRoutingMulticast Multicast { get; internal set; } = null!;
	/// <summary>
	/// Get layer 3 OSPF routing configuration
	/// </summary>

	public ISwitchRoutingOspf Ospf { get; internal set; } = null!;
	/// <summary>
	/// List layer 3 static routes for a switch
	/// </summary>

	public ISwitchRoutingStaticRoutes StaticRoutes { get; internal set; } = null!;
}
