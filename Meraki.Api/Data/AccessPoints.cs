namespace Meraki.Api.Data;

/// <summary>
/// Array of access point serial number and IP assignment. Note: accessPoints IP assignment is not applicable for template networks, in other words, do not put 'accessPoints' in the body when updating template networks. Also, an empty 'accessPoints' array will remove all previous static IP assignments
/// </summary>
[DataContract]
public class AccessPoints
{
	/// <summary>
	/// Serial number of access point to be configured with alternate management IP
	/// </summary>
	[DataMember(Name = "serial")]
	public string Serial { get; set; } = string.Empty;

	/// <summary>
	/// Wireless alternate management interface device IP. Provide an empty string to remove alternate management IP assignment
	/// </summary>
	[DataMember(Name = "alternateManagementIp")]
	public string AlternateManagementIp { get; set; } = string.Empty;

	/// <summary>
	/// Subnet mask must be in IP format
	/// </summary>
	[DataMember(Name = "subnetMask")]
	public string SubnetMask { get; set; } = string.Empty;

	/// <summary>
	/// Gateway must be in IP format
	/// </summary>
	[DataMember(Name = "gateway")]
	public string Gateway { get; set; } = string.Empty;

	/// <summary>
	/// Primary DNS must be in IP format
	/// </summary>
	[DataMember(Name = "dns1")]
	public string Dns1 { get; set; } = string.Empty;

	/// <summary>
	/// Optional secondary DNS must be in IP format
	/// </summary>
	[DataMember(Name = "dns2")]
	public string Dns2 { get; set; } = string.Empty;
}
