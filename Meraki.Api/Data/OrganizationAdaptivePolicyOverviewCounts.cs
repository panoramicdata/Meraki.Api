using System;
using System.Collections.Generic;
using System.Text;

namespace Meraki.Api.Data;

[DataContract]
public class OrganizationAdaptivePolicyOverviewCounts
{
	/// <summary>
	/// Groups
	/// </summary>
	[DataMember(Name = "groups")]
	public int Groups { get; set; } = 0;

	/// <summary>
	/// Custom ACLs
	/// </summary>
	[DataMember(Name = "customAcls")]
	public int CustomAcls { get; set; } = 0;

	/// <summary>
	/// Policies
	/// </summary>
	[DataMember(Name = "policies")]
	public int Policies { get; set; } = 0;

	/// <summary>
	/// Deny policies
	/// </summary>
	[DataMember(Name = "denyPolicies")]
	public int DenyPolicies { get; set; } = 0;

	/// <summary>
	/// Allow policies
	/// </summary>
	[DataMember(Name = "allowPolicies")]
	public int AllowPolicies { get; set; } = 0;
}
