namespace Meraki.Api.Data;

[DataContract]
public class AdaptivePolicyPolicies
{
	/// <summary>
	/// Adaptive policy id
	/// </summary>
	[ApiKey]
	[DataMember(Name = "adaptivePolicyId")]
	public string AdaptivePolicyId { get; set; } = string.Empty;

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

	/// <summary>
	/// The rule to apply if there is no matching ACL (default: "default")
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "lastEntryRule")]
	public string? LastEntryRule { get; set; }

	/// <summary>
	/// Created at
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "createdAt")]
	public string? CreatedAt { get; set; }

	/// <summary>
	/// Updated at
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "updatedAt")]
	public string? UpdatedAt { get; set; }
}
