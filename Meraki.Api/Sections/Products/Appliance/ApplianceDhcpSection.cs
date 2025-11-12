namespace Meraki.Api.Sections.Products.Appliance;

/// <summary>
/// Provides access to appliance dhcp API endpoints
/// </summary>
public class ApplianceDhcpSection
{
	/// <summary>
	/// Return the DHCP subnet information for an appliance
	/// </summary>

	public IApplianceDhcpSubnets Subnets { get; internal set; } = null!;
}
