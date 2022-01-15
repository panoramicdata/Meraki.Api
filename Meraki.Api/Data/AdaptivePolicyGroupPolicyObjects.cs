using System;
using System.Collections.Generic;
using System.Text;

namespace Meraki.Api.Data;
/// <summary>
/// Policy objects
/// </summary>
[DataContract]
public class AdaptivePolicyGroupPolicyObjects
{
	/// <summary>
	/// The ID of the policy object
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "id")]
	public string Id { get; set; } = string.Empty;

	/// <summary>
	/// The name of the policy object
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;
}
