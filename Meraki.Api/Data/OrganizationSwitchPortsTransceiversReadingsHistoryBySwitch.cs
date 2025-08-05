namespace Meraki.Api.Data;

/// <summary>
/// Organization Switch Ports Transceivers Readings History By Switch
/// </summary>
[DataContract]
public class OrganizationSwitchPortsTransceiversReadingsHistoryBySwitch
{
	/// <summary>
	/// Other metadata related to this result set.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "meta")]
	public OrganizationSwitchPortsTransceiversReadingsHistoryBySwitchMetadata Meta { get; set; } = new();

	/// <summary>
	/// The top-level propery containing all digital optical monitorting data.
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "items")]
	public List<OrganizationSwitchPortsTransceiversReadingsHistoryBySwitchItem> Items { get; set; } = [];
}
