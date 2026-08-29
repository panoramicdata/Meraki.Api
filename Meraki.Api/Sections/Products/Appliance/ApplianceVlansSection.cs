namespace Meraki.Api.Sections.Products.Appliance;

/// <summary>
/// Provides access to appliance vlans API endpoints
/// </summary>

// Codacy analyses each file on its own, so it cannot see the other parts of this class and reports
// 'partial' as gratuitous (S2333). Both are false positives: the remaining parts are emitted by
// RefitClassSourceGenerator, or live in the sibling MerakiClient files.
#pragma warning disable S2333
public partial class ApplianceVlansSection
{
	[RefitPromoteCalls]
	internal IApplianceVlans Vlans { get; set; } = null!;
	/// <summary>
	/// Returns the enabled status of VLANs for the network
	/// </summary>

	public IApplianceVlansSettings Settings { get; internal set; } = null!;
}
#pragma warning restore S2333
