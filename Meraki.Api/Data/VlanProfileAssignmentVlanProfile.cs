namespace Meraki.Api.Data;

/// <summary>
/// Vlan Profile Assignment Vlan Profile
/// </summary>
[DataContract]
public class VlanProfileAssignmentVlanProfile
{
	/// <summary>
	/// IName of the VLAN Profile
	/// </summary>
	[DataMember(Name = "iname")]
	public string Iname { get; set; } = string.Empty;

	/// <summary>
	/// Name of the VLAN Profile
	/// </summary>
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;
}
