namespace Meraki.Api.Sections.Products.Sensor;

/// <summary>
/// Section for sensor alert profile operations.
/// </summary>
public class SensorAlertsSection
{
	/// <summary>
	/// Sensor alert profiles
	/// </summary>
	public IOrganizationSensorAlertsProfiles Profiles { get; internal set; } = null!;
}
