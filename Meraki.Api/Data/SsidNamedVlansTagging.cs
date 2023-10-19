namespace Meraki.Api.Data;

/// <summary>
/// VLAN tagging settings. This param is only valid when ipAssignmentMode is 'Bridge mode' or 'Layer 3 roaming'.
/// </summary>
[DataContract]
public class SsidNamedVlansTagging
{
	/// <summary>
	/// The default VLAN name used to tag traffic in the absence of a matching AP tag.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "defaultVlanName")]
	public string? DefaultVlanName { get; set; }

	/// <summary>
	/// Whether or not traffic should be directed to use specific VLAN names.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "enabled")]
	public bool? Enabled { get; set; }

	/// <summary>
	/// The list of AP tags and VLAN names used for named VLAN tagging. If an AP has a tag matching one in the list, then traffic on this SSID will be directed to use the VLAN name associated to the tag.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "byApTags")]
	public List<SsidNamedVlansTaggingByApTag>? ByApTags { get; set; }
}
