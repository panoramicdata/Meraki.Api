namespace Meraki.Api.Data;

/// <summary>
/// Ssid
/// </summary>
[DataContract]
public class OrganizationPoliciesAssignmentsByClientItemAssignedItemLimitToItemSsid
{
	/// <summary>
	/// Ssid number 
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "number")]
	public int Number { get; set; }
}