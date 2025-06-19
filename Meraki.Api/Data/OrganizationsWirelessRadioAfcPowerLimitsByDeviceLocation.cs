namespace Meraki.Api.Data;

/// <summary>
/// Location attributes of device's AFC information
/// </summary>
[DataContract]
public class OrganizationsWirelessRadioAfcPowerLimitsByDeviceLocation
{
	/// <summary>
	/// Where the location was retrieved from (GPS or geolocation propagation)
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "type")]
	public string Type { get; set; } = string.Empty;

	/// <summary>
	/// Latitude of device sent to AFC.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "lat")]
	public int Latitude { get; set; }

	/// <summary>
	/// Longitude of device sent to AFC.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "lng")]
	public int Longitude { get; set; }

	/// <summary>
	/// Location uncertainty (radius) of device sent to AFC (in meters).
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "uncertainty")]
	public int Uncertainty { get; set; }
}