using Meraki.Api.Interfaces.General.Administered;

namespace Meraki.Api.Sections.General.Administered;

public class AdministeredLicensingSubscriptionSection
{
	public IAdministeredLicensingSubscriptionEntitlements Entitlements { get; internal set; } = null!;
}