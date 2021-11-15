namespace Meraki.Api.Data;

/// <summary>
/// Quality and resolution for MV21/MV71 camera models.
/// </summary>
[DataContract]
public class Mv21Mv71
{
	/// <summary>
	/// Gets or Sets Quality
	/// </summary>
	[DataMember(Name = "quality")]
	public CameraQuality Quality { get; set; }

	/// <summary>
	/// Resolution of the camera. Can be one of &#39;1280x720&#39;.
	/// </summary>
	/// <value>Resolution of the camera. Can be one of &#39;1280x720&#39;.</value>
	[DataMember(Name = "resolution")]
	public string Resolution { get; set; } = null!;
}
