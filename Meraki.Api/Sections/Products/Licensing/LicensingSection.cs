namespace Meraki.Api.Sections.Products.Licensing;

/// <summary>
/// Provides access to licensing API endpoints
/// </summary>
public class LicensingSection
{
	/// <summary>
	/// Gets the subscriptions
	/// </summary>

	public LicensingSubscriptionsSection Subscriptions { get; internal set; } = new();
}
