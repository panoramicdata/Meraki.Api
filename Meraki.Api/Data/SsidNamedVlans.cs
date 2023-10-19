namespace Meraki.Api.Data;

/// <summary>
/// Named VLAN settings.
/// </summary>
[DataContract]
public class SsidNamedVlans
{
	/// <summary>
	/// RADIUS settings. This param is only valid when authMode is 'open-with-radius' and ipAssignmentMode is not 'NAT mode'.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "radius")]
	public SsidNamedVlansRadius? Radius { get; set; }

	/// <summary>
	/// VLAN tagging settings. This param is only valid when ipAssignmentMode is 'Bridge mode' or 'Layer 3 roaming'.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "tagging")]
	public SsidNamedVlansTagging? Tagging { get; set; }
}
