namespace Meraki.Api.Data;

/// <summary>
/// Object of Associated Networks
/// </summary>
[DataContract]
public class NetworksSwitchPortsProfileNetworks
{
	/// <summary>
	/// List of Associated Networks
	/// </summary>
	[DataMember(Name = "values")]
	[ApiAccess(ApiAccess.Create)]
	public List<NetworksSwitchPortsProfileValue>? Values { get; set; }

	/// <summary>
	/// Determines whether network is included or excluded in smart port profile based on isOrganizationWide Flag.
	/// </summary>
	[DataMember(Name = "type")]
	[ApiAccess(ApiAccess.Create)]
	public string? Type { get; set; }
}
