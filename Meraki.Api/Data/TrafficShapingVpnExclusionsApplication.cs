namespace Meraki.Api.Data;

/// <summary>
/// Application based VPN exclusion rules.
/// </summary>
[DataContract]
public class TrafficShapingVpnExclusionsApplication
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
