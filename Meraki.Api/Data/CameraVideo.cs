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
	/// RTSP URL
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "rtspUrl")]
	public string? RtspUrl { get; set; }
}
