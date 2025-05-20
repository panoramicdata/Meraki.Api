namespace Meraki.Api.Data;

/// <summary>
/// Organizations Wireless Radio Afc Position By Device Item
/// </summary>
[DataContract]
public class OrganizationsWirelessRadioAfcPositionByDeviceItem
{
	/// <summary>
	/// Name of device
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;

	/// <summary>
	/// Serial of device
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "serial")]
	public string Serial { get; set; } = string.Empty;

	/// <summary>
	/// Height attributes
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "elevation")]
	public OrganizationsWirelessRadioAfcPositionByDeviceElevation Elevation { get; set; } = new();

	/// <summary>
	/// GPS attributes
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "gps")]
	public OrganizationsWirelessRadioAfcPositionByDeviceGps Gps { get; set; } = new();

	/// <summary>
	/// Network of device
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "network")]
	public OrganizationsWirelessRadioAfcPositionByDeviceNetwork Network { get; set; } = new();
}
