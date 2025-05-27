namespace Meraki.Api.Data;

/// <summary>
/// Details about the active/failed unit chassis
/// </summary>
[DataContract]
public class OrganizationWirelessControllerDevicesRedundancyFailoverHistoryItemChassis
{
	/// <summary>
	/// The name of the active/failed chassis unit
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;
}
