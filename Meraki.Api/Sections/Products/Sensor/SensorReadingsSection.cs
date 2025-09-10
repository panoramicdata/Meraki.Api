namespace Meraki.Api.Sections.Products.Sensor;

/// <summary>
/// Provides access to all sensor reading-related API endpoints
/// </summary>
public class SensorReadingsSection
{
	/// <summary>
	/// Latest results
	/// </summary>
	public IOrganizationSensorReadingsLatest Latest { get; internal set; } = null!;

	/// <summary>
	/// Historical results
	/// </summary>
	public IOrganizationSensorReadingsHistory History { get; internal set; } = null!;
}
