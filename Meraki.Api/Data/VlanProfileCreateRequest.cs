namespace Meraki.Api.Data;

/// <summary>
/// Vlan Profile
/// </summary>
[DataContract]
public class VlanProfileCreateRequest : NamedItem
{
	/// <summary>
	/// IName of the VLAN profile
	/// </summary>
	[DataMember(Name = "iname")]
	public string? IName { get; set; }

	/// <summary>
	/// An array of named VLANs
	/// </summary>
	[DataMember(Name = "vlanGroups")]
	public List<VlanProfileVlanGroup>? VlanGroups { get; set; }

	/// <summary>
	/// An array of named VLANs
	/// </summary>
	[DataMember(Name = "vlanNames")]
	public List<VlanProfileVlanName>? VlanNames { get; set; }
}
