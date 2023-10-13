namespace Meraki.Api.Data;

/// <summary>
/// Vlan Profile Reassignment Response
/// </summary>
[DataContract]
public class VlanProfileAssignment
{
	/// <summary>
	/// Array of Device Serials
	/// </summary>
	[DataMember(Name = "serials")]
	public List<string> Serials { get; set; } = new();

	/// <summary>
	/// Array of Switch Stack IDs
	/// </summary>
	[DataMember(Name = "stackIds")]
	public List<string> StackIds { get; set; } = new();

	/// <summary>
	/// The VLAN Profile
	/// </summary>
	[DataMember(Name = "vlanProfile")]
	public VlanProfileAssignmentVlanProfile? VlanProfile { get; set; }
}
