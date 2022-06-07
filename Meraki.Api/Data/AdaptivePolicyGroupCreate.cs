﻿namespace Meraki.Api.Data;
/// <summary>
/// Adaptive policy group
/// </summary>
[DataContract]

public class AdaptivePolicyGroupCreateUpdate
{
	/// <summary>
	/// Name of the group
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "name")]
	public string? Name { get; set; }

	/// <summary>
	/// SGT value of the group
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "sgt")]
	public int? Sgt { get; set; }

	/// <summary>
	/// Description of the group
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "description")]
	public string? Description { get; set; }

	/// <summary>
	/// The policy objects that belong to this group; traffic from addresses specified by these policy objects will be tagged with this group's SGT value if no other tagging scheme is being used (each requires one unique attribute)
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "policyObjects")]
	public List<AdaptivePolicyGroupPolicyObjects>? PolicyObjects { get; set; }
}
