using Meraki.Api.Interfaces.Products.Licensing;

namespace Meraki.Api.Sections.Products.Licensing;

/// <summary>
/// Provides access to licensing API endpoints
/// </summary>
public class LicensingSection
{
	/// <summary>
	/// Claim a subscription into an organization.
	/// </summary>

	public ILicensingSubscriptions Subscriptions { get; internal set; } = null!;
}
