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
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "quality")]
	public CameraQuality Quality { get; set; }

	/// <summary>
	/// Resolution of the camera. Can be one of '1280x720'.
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "resolution")]
	public string Resolution { get; set; } = null!;
}
