namespace Meraki.Api.Sections.General.Devices;

/// <summary>
/// Provides access to devices appliance API endpoints
/// </summary>
public class DevicesApplianceSection
{
	/// <summary>
	/// Return current delegated IPv6 prefixes on an appliance.
	/// </summary>

	public IDevicesAppliancePrefixes Prefixes { get; internal set; } = null!;
}
