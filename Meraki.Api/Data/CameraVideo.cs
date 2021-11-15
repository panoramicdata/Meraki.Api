namespace Meraki.Api.Data;

/// <summary>
/// The video settings for a camera
/// </summary>
[DataContract]
public class CameraVideo
{
	/// <summary>
	/// Boolean indicating if external rtsp stream is exposed
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "externalRtspEnabled")]
	public bool ExternalRtspEnabled { get; set; }

	/// <summary>
	/// Rtsp Url
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	public string? RtspUrl { get; set; }
}
