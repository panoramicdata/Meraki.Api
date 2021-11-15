using Meraki.Api.Attributes;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Meraki.Api.Data;

/// <summary>
/// UpdateNetworkOneToManyNatRules
/// </summary>
[DataContract]
public class OneToManyNatRules
{
	/// <summary>
	/// An array of 1:Many nat rules
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "rules")]
	public List<OneToManyNatRule> Rules { get; set; } = new();
}
