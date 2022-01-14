using System;
using System.Collections.Generic;
using System.Text;

namespace Meraki.Api.Data;

[DataContract]
public class AdaptivePolicyPolicies
{
	/// <summary>
	/// Adaptive policy id
	/// </summary>
	[DataMember(Name = "adaptivePolicyId")]
	public string AdaptivePolicyId { get; set; } = string.Empty;

	/// <summary>
	/// Source group
	/// </summary>
	[DataMember(Name = "sourceGroup")]
	public AdaptivePolicySourceGroup SourceGroup { get; set; } = new();

	/// <summary>
	/// Destination group
	/// </summary>
	[DataMember(Name = "destinationGroup")]
	public AdaptivePolicySourceGroup DestinationGroup { get; set; } = new();

	/// <summary>
	/// ACLs
	/// </summary>
	[DataMember(Name = "acls")]
	public List<AdaptivePolicyPoliciesAcl> Acls { get; set; } = new();

	/// <summary>
	/// Last entry rule
	/// </summary>
	[DataMember(Name = "lastEntryRule")]
	public string LastEntryRule { get; set; } = string.Empty;

	/// <summary>
	/// Created at
	/// </summary>
	[DataMember(Name = "createdAt")]
	public string CreatedAt { get; set; } = string.Empty;

	/// <summary>
	/// Updated at
	/// </summary>
	[DataMember(Name = "updatedAt")]
	public string UpdatedAt { get; set; } = string.Empty;
}
