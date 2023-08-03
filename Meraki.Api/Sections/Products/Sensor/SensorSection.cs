namespace Meraki.Api.Sections.Products.Sensor;
public class SensorSection
{
	public SensorAlertsSection Alerts { get; set; } = new();

	public SensorReadingsSection Readings { get; set; } = new();

	public IOrganizationSensorRelationships Relationships { get; set; } = null!;
}
