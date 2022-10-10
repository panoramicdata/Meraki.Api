using Meraki.Api.Interfaces.Products.Appliances;

namespace Meraki.Api.Sections.Products.Appliance;

public class AppliancePrefixesDelegatedSection
{
	public IAppliancePrefixesDelegatedStatics Statics { get; internal set; } = null!;
}