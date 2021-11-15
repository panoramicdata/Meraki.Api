using Meraki.Api.Attributes;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Meraki.Api.Data;

/// <summary>
/// CreateNetworkSwitchLinkAggregation
/// </summary>
[DataContract]
public class SwitchLinkAggregation
{
	/// <summary>
	/// Id
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "id")]
	public string Id { get; set; } = string.Empty;

	/// <summary>
	/// Array of switch or stack ports for creating aggregation group. Minimum 2 and maximum 8 ports are supported.
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "switchPorts")]
	public List<LinkAggregationSwitchPort> SwitchPorts { get; set; } = null!;

	/// <summary>
	/// Array of switch profile ports for creating aggregation group. Minimum 2 and maximum 8 ports are supported.
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "switchProfilePorts")]
	public List<SwitchProfilePort> SwitchProfilePorts { get; set; } = null!;
}
