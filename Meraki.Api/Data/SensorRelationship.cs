namespace Meraki.Api.Data;

/// <summary>
/// Sensor alerts profile for a network
/// </summary>
[DataContract]
public class SensorRelationship
{
	///<summary>
	/// A role defined between an MT sensor and an MV camera that adds the camera's livestream to the sensor's details page. 
	/// Snapshots from the camera will also appear in alert notifications that the sensor triggers.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "livestream")]
	public SensorRelationshipLivestream? Livestream { get; set; }
}