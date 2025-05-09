namespace Meraki.Api.Data;

/// <summary>
/// Location attributes of device's AFC information
/// </summary>
[DataContract]
public class DevicesWirelessRadioAfcLocation
{
	/// <summary>
	/// Latitude of device sent to AFC
	/// </summary>
	[DataMember(Name = "lat")]
	public float Latitude { get; set; }

	/// <summary>
	/// Longitude of device sent to AFC
	/// </summary>
	[DataMember(Name = "lng")]
	public float Longitude { get; set; }

	/// <summary>
	/// Location uncertainty (radius) of device sent to AFC (in meters).
	/// </summary>
	[DataMember(Name = "uncertainty")]
	public int Uncertainty { get; set; }

	/// <summary>
	/// Where the location was retrieved from (GPS or geolocation propagation)
	/// </summary>
	[DataMember(Name = "type")]
	public string Type { get; set; } = string.Empty;
}