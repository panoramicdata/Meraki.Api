namespace Meraki.Api.Data;

/// <summary>
/// Wake On Lan Request
/// </summary>
[DataContract]

public class LiveToolsWakeOnLanRequest
{
	/// <summary>
	/// The target's VLAN (1 to 4094)
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "vlanId")]
	public int VlanId { get; set; }

	/// <summary>
	/// The target's MAC address
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "mac")]
	public string Mac { get; set; } = string.Empty;

	/// <summary>
	/// Device serial number
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "serial")]
	public string Serial { get; set; } = string.Empty;
}
