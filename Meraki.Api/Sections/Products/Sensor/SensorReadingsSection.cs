namespace Meraki.Api.Sections.Products.Sensor;

public class SensorReadingsSection
{
	public IOrganizationSensorReadingsLatest Latest { get; internal set; } = null!;

	public IOrganizationSensorReadingsHistory History { get; internal set; } = null!;
}
