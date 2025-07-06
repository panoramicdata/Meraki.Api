namespace Meraki.Api.Data;

/// <summary>
/// A reserved IP range on the VLAN
/// </summary>
[DataContract]
public class OrganizationsApplianceVlanReservedIpRange
{
	/// <summary>
	/// A text comment for the reserved range
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "comment")]
	public string Comment { get; set; } = string.Empty;

	/// <summary>
	/// The last IP in the reserved range
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "end")]
	public string End { get; set; } = string.Empty;

	/// <summary>
	/// The first IP in the reserved range
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "start")]
	public string Start { get; set; } = string.Empty;
}