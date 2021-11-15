using Meraki.Api.Attributes;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Meraki.Api.Data;

/// <summary>
/// Gets or sets the branding policy IDs of an organization in priority order. IDs are ordered in ascending order of priority (IDs later in the array have higher priority).
/// </summary>
[DataContract]
public class BrandingPoliciesPriorities
{
	/// <summary>
	/// A list of branding policy IDs arranged in ascending priority order (IDs later in the array have higher priority).
	/// </summary>
	/// <value>A list of branding policy IDs arranged in ascending priority order (IDs later in the array have higher priority).</value>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "brandingPolicyIds")]
	public List<string> BrandingPolicyIds { get; set; } = new();
}
