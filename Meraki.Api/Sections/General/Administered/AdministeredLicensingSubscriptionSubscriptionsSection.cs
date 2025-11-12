using Meraki.Api.Interfaces.General.Administered;

namespace Meraki.Api.Sections.General.Administered;

/// <summary>
/// Provides access to administered licensing subscription subscriptions API endpoints
/// </summary>
public class AdministeredLicensingSubscriptionSubscriptionsSection
{
	/// <summary>
	/// Get compliance status for requested subscriptions
	/// </summary>

	public IAdministeredLicensingSubscriptionSubscriptionsCompliance Compliance { get; set; } = null!;
}
