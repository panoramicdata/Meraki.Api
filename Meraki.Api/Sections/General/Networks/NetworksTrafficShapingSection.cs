namespace Meraki.Api.Sections.General.Networks;

public class NetworksTrafficShapingSection
{
	public INetworksTrafficShapingApplicationCategories ApplicationCategories { get; internal set; } = null!;
	public INetworksTrafficShapingDscpTaggingOptions DscpTaggingOptions { get; internal set; } = null!;
}