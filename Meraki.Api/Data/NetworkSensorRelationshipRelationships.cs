namespace Meraki.Api.Data;

/// <summary>
/// An object describing the relationships defined between the device and other devices
/// </summary>
[DataContract]
public class NetworkSensorRelationshipRelationships
{
	/// <summary>
	/// A role defined between an MT sensor and an MV camera that adds the camera's livestream to the sensor's details page. 
	/// Snapshots from the camera will also appear in alert notifications that the sensor triggers.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "livestream")]
	public SensorRelationshipLivestream? Livestream { get; set; }
}