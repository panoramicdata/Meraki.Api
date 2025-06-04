namespace Meraki.Api.Data;

/// <summary>
/// Network Policy By Client.
/// </summary>
[DataContract]
public class NetworkPolicyByClient
{
	/// <summary>
	/// ID of client
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "clientId")]
	public string ClientId { get; set; } = string.Empty;

	/// <summary>
	/// Name of client
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;

	/// <summary>
	/// Assigned policies
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "assigned")]
	public List<NetworkPolicyByClientAssignedItem> Assigned { get; set; } = [];
}
