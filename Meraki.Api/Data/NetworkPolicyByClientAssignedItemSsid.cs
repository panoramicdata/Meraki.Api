namespace Meraki.Api.Data;

/// <summary>
/// ssid
/// </summary>
[DataContract]
public class NetworkPolicyByClientAssignedItemSsid
{
	/// <summary>
	/// number of ssid
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "ssidNumber")]
	public int SsidNumber { get; set; }
}