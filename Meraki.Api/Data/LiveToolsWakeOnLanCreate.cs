namespace Meraki.Api.Data;

/// <summary>
/// Wake On Lan Create
/// </summary>
[DataContract]

public class LiveToolsWakeOnLanCreate
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
	/// Details for the callback. Please include either an httpServerId OR url and sharedSecret
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "callback")]
	public LiveToolsWakeOnLanCreateCallback Callback { get; set; } = new();
}
