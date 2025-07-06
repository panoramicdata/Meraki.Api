namespace Meraki.Api.Data;

/// <summary>
/// An assigned policy
/// </summary>
[DataContract]
public class NetworkPolicyByClientAssignedItem
{
	/// <summary>
	/// id of policy
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "groupPolicyId")]
	public string GroupPolicyId { get; set; } = string.Empty;

	/// <summary>
	/// name of policy
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;

	/// <summary>
	/// type of policy
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "type")]
	public string Type { get; set; } = string.Empty;

	/// <summary>
	/// ssid
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "ssid")]
	public List<NetworkPolicyByClientAssignedItemSsid> Ssid { get; set; } = [];
}
