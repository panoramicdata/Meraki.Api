namespace Meraki.Api.Sections.Products.Appliance;

/// <summary>
/// Provides access to content filtering operations and categories for an MX network.
/// </summary>
/// <remarks>This section exposes APIs for managing and retrieving information related to content filtering on
/// Meraki MX networks. Use the <see cref="Categories"/> property to list available filtering categories. Additional
/// content filtering operations may be available through other members of this class.</remarks>
public partial class ApplianceContentFilteringSection
{
	[RefitPromoteCalls]
	internal IApplianceContentFiltering ContentFiltering { get; set; } = null!;
	/// <summary>
	/// List all available content filtering categories for an MX network
	/// </summary>
	public IApplianceContentFilteringCategories Categories { get; internal set; } = null!;
}
