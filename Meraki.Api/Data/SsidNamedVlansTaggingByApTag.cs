namespace Meraki.Api.Data;

/// <summary>
/// The list of AP tags and VLAN names used for named VLAN tagging. If an AP has a tag matching one in the list, then traffic on this SSID will be directed to use the VLAN name associated to the tag.
/// </summary>
[DataContract]
public class SsidNamedVlansTaggingByApTag
{
	/// <summary>
	/// VLAN name that will be used to tag traffic.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "vlanName")]
	public string? VlanName { get; set; }

	/// <summary>
	/// List of AP tags.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "tags")]
	public List<string>? Tags { get; set; }
}
