namespace Meraki.Api.Data;
/// <summary>
/// Adaptive policy group
/// </summary>
[DataContract]

public class AdaptivePolicyGroup : NamedItem
{
	/// <summary>
	/// Group id
	/// </summary>
	[ApiKey]
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "groupId")]
	public string GroupId { get; set; } = string.Empty;

	/// <summary>
	/// SGT value of the group
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "sgt")]
	public int Sgt { get; set; }

	/// <summary>
	/// Description of the group
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "description")]
	public string Description { get; set; } = string.Empty;

	/// <summary>
	/// The policy objects that belong to this group; traffic from addresses specified by these policy objects will be tagged with this group's SGT value if no other tagging scheme is being used (each requires one unique attribute)
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "policyObjects")]
	public List<AdaptivePolicyGroupPolicyObjects>? PolicyObjects { get; set; }

	/// <summary>
	/// Created at
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "createdAt")]
	public DateTime CreatedAt { get; set; }

	/// <summary>
	/// Updated at
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "updatedAt")]
	public DateTime UpdatedAt { get; set; }
}
