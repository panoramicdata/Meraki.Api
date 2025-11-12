namespace Meraki.Api.Sections.Products.Appliance;

public partial class ApplianceVlansSection
{
	[RefitPromoteCalls]
	internal IApplianceVlans Vlans { get; set; } = null!;
	/// <summary>
	/// Returns the enabled status of VLANs for the network
	/// </summary>

	public IApplianceVlansSettings Settings { get; internal set; } = null!;
}
