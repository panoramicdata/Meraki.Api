namespace Meraki.Api.Sections.General.Administered;

/// <summary>
/// Provides access to administered licensing API endpoints
/// </summary>
public class AdministeredLicensingSection
{
	/// <summary>
	/// Gets the subscription
	/// </summary>

	public AdministeredLicensingSubscriptionSection Subscription { get; set; } = new();
}
