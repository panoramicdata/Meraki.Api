namespace Meraki.Api.Data;

/// <summary>
/// Vlan Profile Reassignment Request Vlan Peofile
/// </summary>
[DataContract]
public class VlanProfileReassignmentRequestVlanProfile
{
	/// <summary>
	/// IName of the VLAN Profile
	/// </summary>
	[DataMember(Name = "iname")]
	public string? IName { get; set; }
}
