namespace Meraki.Api.Data;

/// <summary>
/// Organization Policies Assignments By Client Item
/// </summary>
[DataContract]
public class OrganizationPoliciesAssignmentsByClientItem
{
	/// <summary>
	/// ID of client
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "clientId")]
	public string ClientId { get; set; } = string.Empty;

	/// <summary>
	/// MAC address of client
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "mac")]
	public string Mac { get; set; } = string.Empty;

	/// <summary>
	/// Name of client
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;

	/// <summary>
	/// NetworkID
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "networkId")]
	public string NetworkId { get; set; } = string.Empty;

	/// <summary>
	/// Assigned policies
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "assigned")]
	public List<OrganizationPoliciesAssignmentsByClientItemAssignedItem> Assigned { get; set; } = [];
}
