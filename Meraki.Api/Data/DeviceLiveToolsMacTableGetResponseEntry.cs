namespace Meraki.Api.Data;

/// <summary>
/// MAC address table entry
/// </summary>
[DataContract]
public class DeviceLiveToolsMacTableGetResponseEntry
{
	/// <summary>
	/// The vlan id of the MAC entry
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "vlanId")]
	public int VlanId { get; set; }

	/// <summary>
	/// The MAC address of the MAC entry
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "mac")]
	public string Mac { get; set; } = string.Empty;

	/// <summary>
	/// The name of the interface of the MAC entry
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "port")]
	public string Port { get; set; } = string.Empty;
}