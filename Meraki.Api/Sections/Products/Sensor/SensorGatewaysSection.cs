namespace Meraki.Api.Sections.Products.Sensor;

/// <summary>
/// Provides access to all sensor gateway-related API endpoints
/// </summary>
public class SensorGatewaysSection
{
	/// <summary>
	/// Latest Connections
	/// </summary>
	public IOrganizationSensorGatewaysConnectionsLatest ConnectionsLatest { get; internal set; } = null!;
}
