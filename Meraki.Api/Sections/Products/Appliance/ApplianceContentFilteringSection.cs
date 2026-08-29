namespace Meraki.Api.Sections.Products.Appliance;

/// <summary>
/// Provides access to content filtering operations and categories for an MX network.
/// </summary>
/// <remarks>This section exposes APIs for managing and retrieving information related to content filtering on
/// Meraki MX networks. Use the <see cref="Categories"/> property to list available filtering categories. Additional
/// content filtering operations may be available through other members of this class.</remarks>
// Codacy analyses each file on its own, so it cannot see the other parts of this class and reports
// 'partial' as gratuitous (S2333). Both are false positives: the remaining parts are emitted by
// RefitClassSourceGenerator, or live in the sibling MerakiClient files.
#pragma warning disable S2333
public partial class ApplianceContentFilteringSection
{
	[RefitPromoteCalls]
	internal IApplianceContentFiltering ContentFiltering { get; set; } = null!;
	/// <summary>
	/// List all available content filtering categories for an MX network
	/// </summary>
	public IApplianceContentFilteringCategories Categories { get; internal set; } = null!;
}
#pragma warning restore S2333
