namespace Meraki.Api.Data;

/// <summary>
/// Device details
/// </summary>
[DataContract]
public class OrganizationsNacSessionDetailsDevice
{
	/// <summary>
	/// Device Model
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "model")]
	public string Model { get; set; } = string.Empty;

	/// <summary>
	/// Device Name
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;

	/// <summary>
	/// Device Tags
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "tags")]
	public string Tags { get; set; } = string.Empty;

	/// <summary>
	/// Device IP Address Details
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "addresses")]
	public List<OrganizationsNacSessionDetailsDeviceAddress> Addresses { get; set; } = [];
}
