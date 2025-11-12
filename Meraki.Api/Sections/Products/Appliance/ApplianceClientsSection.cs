namespace Meraki.Api.Sections.Products.Appliance;

/// <summary>
/// Provides access to appliance clients API endpoints
/// </summary>
public class ApplianceClientsSection
{
	/// <summary>
	/// List the security events for a client
	/// </summary>

	public IApplianceClientsSecurity Security { get; internal set; } = null!;
}
