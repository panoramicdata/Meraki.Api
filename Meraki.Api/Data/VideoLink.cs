namespace Meraki.Api.Data;

/// <summary>
/// Video link
/// </summary>
[DataContract]
public class VideoLink
{
	/// <summary>
	/// Url
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "url")]
	public string Url { get; set; } = string.Empty;

	/// <summary>
	/// Vision Url
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "visionUrl")]
	public string VisionUrl { get; set; } = string.Empty;
}
