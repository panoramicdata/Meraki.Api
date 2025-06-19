namespace Meraki.Api.Data;

/// <summary>
/// The top-level propery containing all digital optical monitorting data.
/// </summary>
[DataContract]
public class OrganizationSwitchPortsTransceiversReadingsHistoryBySwitchItem
{
	/// <summary>
	/// Unique serial number for switch
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "serial")]
	public string Serial { get; set; } = string.Empty;

	/// <summary>
	/// Information regarding the network the switch belongs to
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "network")]
	public OrganizationSwitchPortsTransceiversReadingsHistoryBySwitchItemNetwork Network { get; set; } = new();

	/// <summary>
	/// The ports associated with the given switch
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "ports")]
	public List<OrganizationSwitchPortsTransceiversReadingsHistoryBySwitchItemPort> Ports { get; set; } = [];
}
