namespace Meraki.Api.Data;

/// <summary>
/// The longitude and latitude for a location of a floorplan
/// </summary>
[DataContract]
public class GeoLocation
{
	/// <summary>
	/// Latitude
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "lat")]

	public double Latitude { get; set; }

	/// <summary>
	/// Longitude
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "lng")]
	public double Longitude { get; set; }
}
