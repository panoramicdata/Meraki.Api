using System;
using System.Collections.Generic;
using System.Text;

namespace Meraki.Api.Data;
/// <summary>
/// Adaptive policy group
/// </summary>
[DataContract]

public class AdaptivePolicyGroupCreate
{
	/// <summary>
	/// Group id
	/// </summary>
	[DataMember(Name = "groupId")]
	public string GroupId { get; set; } = string.Empty;

	/// <summary>
	/// Name
	/// </summary>
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;

	/// <summary>
	/// SGT
	/// </summary>
	[DataMember(Name = "sgt")]
	public int Sgt { get; set; } = 0;

	/// <summary>
	/// Description
	/// </summary>
	[DataMember(Name = "description")]
	public string Description { get; set; } = string.Empty;

	/// <summary>
	/// Policy objects
	/// </summary>
	[DataMember(Name = "policyObjects")]
	public List<AdaptivePolicyGroupPolicyObjects> PolicyObjects { get; set; } = new();
}
