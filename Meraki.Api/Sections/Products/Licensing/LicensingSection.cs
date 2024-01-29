using Meraki.Api.Interfaces.Products.Licensing;

namespace Meraki.Api.Sections.Products.Licensing;

public class LicensingSection
{
	public ILicensingSubscriptions Subscriptions { get; internal set; } = null!;
}
