namespace Meraki.Api.Data;

/// <summary>
/// ApTagsAndVlanId
/// </summary>
[DataContract]
public class ApTagsAndVlanId
{
	/// <summary>
	/// Comma-separated list of AP tags
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "tags")]
	public List<string> Tags { get; set; } = new();

	/// <summary>
	/// Numerical identifier that is assigned to the VLAN
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "vlanId")]
	public int? VlanId { get; set; }
}
