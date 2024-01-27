namespace Meraki.Api.Data;
/// <summary>
/// The VLAN Profile
/// </summary>
[DataContract]
public class VlanProfileDeviceAssignmentVlanProfile
{
	/// <summary>
	/// IName of the VLAN Profile
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "iname")]
	public string? IName { get; set; }

	/// <summary>
	/// Name of the VLAN Profile
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "name")]
	public string? Name { get; set; }

	/// <summary>
	/// Is this VLAN profile the default for the network?
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "isDefault")]
	public bool? IsDefault { get; set; }
}