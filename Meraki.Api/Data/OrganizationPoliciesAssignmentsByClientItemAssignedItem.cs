namespace Meraki.Api.Data;

/// <summary>
/// Assigned policies Item
/// </summary>
[DataContract]
public class OrganizationPoliciesAssignmentsByClientItemAssignedItem
{
	/// <summary>
	/// id of policy
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "id")]
	public string Id { get; set; } = string.Empty;

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
	public AssignmentType Type { get; set; }

	/// <summary>
	/// policy limits
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "limitTo")]
	public List<OrganizationPoliciesAssignmentsByClientItemAssignedItemLimitToItem> LimitTo { get; set; } = [];
}
