namespace Meraki.Api.Data;

/// <summary>
/// Height attributes
/// </summary>
[DataContract]
public class OrganizationsWirelessRadioAfcPositionByDeviceElevation
{
	/// <summary>
	/// The accuracy of this device's elevation in meters (+/-).
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "uncertainty")]
	public int Uncertainty { get; set; }

	/// <summary>
	/// Height from ground in meters
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "height")]
	public int Height { get; set; }
}