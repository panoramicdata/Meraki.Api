using System.Runtime.Serialization;

namespace Meraki.Api.Data;

/// <summary>
/// Camera object detection model
/// </summary>
[DataContract]
public class CameraObjectDetectionModel
{
	/// <summary>
	/// Id
	/// </summary>
	[DataMember(Name = "id")]
	public string Id { get; set; } = string.Empty;

	/// <summary>
	/// Description
	/// </summary>
	[DataMember(Name = "description")]
	public string Description { get; set; } = string.Empty;
}
