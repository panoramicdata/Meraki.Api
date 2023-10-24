namespace Meraki.Api.Data;

/// <summary>
/// Vlan Profile Device Assignment
/// </summary>
[DataContract]
public class VlanProfileDeviceAssignment
{
	/// <summary>
	/// MAC address of the device
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "mac")]
	public string? Mac { get; set; }

	/// <summary>
	/// Name of the Device
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "name")]
	public string? Name { get; set; }

	/// <summary>
	/// The product type
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "productType")]
	public string? ProductType { get; set; }

	/// <summary>
	/// Serial of the Device
	/// </summary>
	[ApiForeignKey(typeof(Device))]
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "serial")]
	public string? Serial { get; set; }

	/// <summary>
	/// The Switch Stack the device belongs to
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "stack")]
	public VlanProfileDeviceAssignmentStack? Stack { get; set; }

	/// <summary>
	/// The VLAN Profile
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "vlanProfile")]
	public VlanProfileDeviceAssignmentVlanProfile? VlanProfile { get; set; }
}
