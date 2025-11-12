namespace Meraki.Api.Sections.Products.Appliance;

/// <summary>
/// Provides access to appliance prefixes API endpoints
/// </summary>
public class AppliancePrefixesSection
{
	/// <summary>
	/// Gets the delegated
	/// </summary>

	public AppliancePrefixesDelegatedSection Delegated { get; internal set; } = new();
}
