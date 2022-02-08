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
}
