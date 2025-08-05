namespace Meraki.Api.Data;

/// <summary>
/// External antenna attributes
/// </summary>
[DataContract]
public class OrganizationsWirelessRadioAfcPositionByDeviceGpsAntenna
{
	/// <summary>
	/// Length of the attached cable
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "cableLength")]
	public int CableLength { get; set; }
}