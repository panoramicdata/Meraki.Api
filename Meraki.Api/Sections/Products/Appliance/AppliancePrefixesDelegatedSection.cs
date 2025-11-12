namespace Meraki.Api.Sections.Products.Appliance;

/// <summary>
/// Provides access to appliance prefixes delegated API endpoints
/// </summary>
public class AppliancePrefixesDelegatedSection
{
	/// <summary>
	/// List static delegated prefixes for a network
	/// </summary>

	public IAppliancePrefixesDelegatedStatics Statics { get; internal set; } = null!;
}
