namespace Meraki.Api.Sections.Products.Appliance;

/// <summary>
/// Provides access to appliance uplink API endpoints
/// </summary>
public class ApplianceUplinkSection
{
	/// <summary>
	/// List the uplink status of every Meraki MX and Z series appliances in the organization
	/// </summary>

	public IApplianceUplinkStatuses Statuses { get; internal set; } = null!;
}
