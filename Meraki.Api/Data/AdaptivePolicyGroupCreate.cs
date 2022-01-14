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
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "groupId")]
	public string GroupId { get; set; } = string.Empty;

	/// <summary>
	/// Name
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;

	/// <summary>
	/// SGT
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "sgt")]
	public int Sgt { get; set; } = 0;

	/// <summary>
	/// Description
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "description")]
	public string Description { get; set; } = string.Empty;

	/// <summary>
	/// Policy objects
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "policyObjects")]
	public List<AdaptivePolicyGroupPolicyObjects> PolicyObjects { get; set; } = new();
}
