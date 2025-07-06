namespace Meraki.Api.Data;

/// <summary>
/// GPS attributes
/// </summary>
[DataContract]
public class OrganizationsWirelessRadioAfcPositionByDeviceGps
{
	/// <summary>
	/// External antenna attributes
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "antenna")]
	public OrganizationsWirelessRadioAfcPositionByDeviceGpsAntenna Antenna { get; set; } = new();
}
