using Meraki.Api.Interfaces.General.Administered;

namespace Meraki.Api.Sections.General.Administered;

public class AdministeredLicensingSubscriptionNetworksSection
{
	public IAdministeredLicensingSubscriptionNetworksFeatureTiers FeatureTiers { get; internal set; } = null!;
}