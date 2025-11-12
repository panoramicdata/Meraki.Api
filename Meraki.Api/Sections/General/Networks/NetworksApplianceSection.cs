namespace Meraki.Api.Sections.General.Networks;

/// <summary>
/// Provides access to networks appliance API endpoints
/// </summary>
public class NetworksApplianceSection
{
	/// <summary>
	/// Connect to Cisco Umbrella account to this network
	/// </summary>

	public INetworksApplianceUmbrella Umbrella { get; internal set; } = null!;
}
