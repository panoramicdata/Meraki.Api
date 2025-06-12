namespace Meraki.Api.Data;

/// <summary>
/// policy limits item
/// </summary>
[DataContract]
public class OrganizationPoliciesAssignmentsByClientItemAssignedItemLimitToItem
{
	/// <summary>
	/// true if policy is applied to the appliance
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "appliance")]
	public bool Appliance { get; set; }

	/// <summary>
	/// ssids
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "ssids")]
	public List<OrganizationPoliciesAssignmentsByClientItemAssignedItemLimitToItemSsid> Ssids { get; set; } = [];
}
