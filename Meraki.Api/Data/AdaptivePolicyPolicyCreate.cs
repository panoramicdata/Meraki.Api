﻿namespace Meraki.Api.Data;

[DataContract]
public class AdaptivePolicyPolicyCreateUpdateRequest
{
	/// <summary>
	/// The rule to apply if there is no matching ACL (default: "default")
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "lastEntryRule")]
	public string? LastEntryRule { get; set; }

	/// <summary>
	/// The source adaptive policy group (requires one unique attribute)
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "sourceGroup")]
	public AdaptivePolicyPoliciesGroup? SourceGroup { get; set; }

	/// <summary>
	/// The destination adaptive policy group (requires one unique attribute)
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "destinationGroup")]
	public AdaptivePolicyPoliciesGroup? DestinationGroup { get; set; }

	/// <summary>
	/// An ordered array of adaptive policy ACLs (each requires one unique attribute) that apply to this policy (default: [])
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "acls")]
	public List<AdaptivePolicyPoliciesAcl>? Acls { get; set; }
}
