using Meraki.Api.Interfaces.General.Administered;

namespace Meraki.Api.Sections.General.Administered;

public class AdministeredLicensingSubscriptionSubscriptionsSection
{
	public IAdministeredLicensingSubscriptionSubscriptionsCompliance Compliance { get; set; } = null!;
}