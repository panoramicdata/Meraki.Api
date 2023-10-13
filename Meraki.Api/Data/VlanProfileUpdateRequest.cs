namespace Meraki.Api.Data;

/// <summary>
/// Vlan Profile
/// </summary>
[DataContract]
public class VlanProfileUpdateRequest : NamedItem
{
	/// <summary>
	/// IName of the VLAN profile
	/// </summary>
	[DataMember(Name = "iname")]
	public string? Iname { get; set; }

	/// <summary>
	/// An array of named VLANs
	/// </summary>
	[DataMember(Name = "vlanGroups")]
	public List<VlanProfileVlanGroup> VlanGroups { get; set; } = new();

	/// <summary>
	/// An array of named VLANs
	/// </summary>
	[DataMember(Name = "vlanNames")]
	public List<VlanProfileVlanName> VlanNames { get; set; } = new();
}
