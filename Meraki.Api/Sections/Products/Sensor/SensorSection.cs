namespace Meraki.Api.Sections.Products.Sensor;

/// <summary>
/// Section for sensor-related operations.
/// </summary>
public class SensorSection
{
	/// <summary>
	/// Gets the alerts
	/// </summary>

	public SensorAlertsSection Alerts { get; set; } = new();

	/// <summary>
	/// Gets the gateways
	/// </summary>

	public SensorGatewaysSection Gateways { get; set; } = new();

	/// <summary>
	/// Gets the readings
	/// </summary>

	public SensorReadingsSection Readings { get; set; } = new();

	/// <summary>
	/// List the sensor roles for a given sensor or camera device.
	/// </summary>

	public IOrganizationSensorRelationships Relationships { get; set; } = null!;
}
