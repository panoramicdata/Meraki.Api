namespace Meraki.Api.Sections.Products.Sensor;

/// <summary>
/// Section for sensor-related operations.
/// </summary>
public class SensorSection
{
	public SensorAlertsSection Alerts { get; set; } = new();

	public SensorGatewaysSection Gateways { get; set; } = new();

	public SensorReadingsSection Readings { get; set; } = new();

	public IOrganizationSensorRelationships Relationships { get; set; } = null!;
}
