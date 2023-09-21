namespace Meraki.Api.Data;

/// <summary>
/// Major Application based VPN exclusion rules. Pass an empty array to clear existing rules.
/// </summary>
[DataContract]
public class TrafficShapingVpnExclusionsMajorApplication
{
	/// <summary>
	/// Application's Meraki ID.
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "id")]
	public string? Id { get; set; }

	/// <summary>
	/// Application's name.
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "name")]
	public string? Name { get; set; }
}
