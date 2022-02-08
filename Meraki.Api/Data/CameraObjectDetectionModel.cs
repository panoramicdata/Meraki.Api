namespace Meraki.Api.Data;

/// <summary>
/// Camera object detection model
/// </summary>
[DataContract]
public class CameraObjectDetectionModel : IdentifiedItem
{
	/// <summary>
	/// Description
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "description")]
	public string Description { get; set; } = string.Empty;
}
