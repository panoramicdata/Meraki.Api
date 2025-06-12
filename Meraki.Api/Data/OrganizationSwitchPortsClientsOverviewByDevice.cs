namespace Meraki.Api.Data;

/// <summary>
/// Organization Switch Ports Clients Overview By Device
/// </summary>
[DataContract]
public class OrganizationSwitchPortsClientsOverviewByDevice
{
	/// <summary>
	/// Metadata relevant to the paginated dataset
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "meta")]
	public OrganizationSwitchPortsClientsOverviewByDeviceMetadata Meta { get; set; } = new();

	/// <summary>
	/// Switches
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "items")]
	public List<OrganizationSwitchPortsClientsOverviewByDeviceItem> Items { get; set; } = [];
}
