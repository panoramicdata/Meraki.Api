namespace Meraki.Api.Data;

/// <summary>
/// A role defined between an MT sensor and an MV camera that adds the camera's livestream to the sensor's details page.
/// Snapshots from the camera will also appear in alert notifications that the sensor triggers.
/// </summary>
[DataContract]
public class SensorRelationshipLivestream
{
	///<summary>
	/// An array of the related devices for the role
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "relatedDevices")]
	public List<SensorRelationshipLivestreamRelatedDevice>? RelatedDevices { get; set; }
}