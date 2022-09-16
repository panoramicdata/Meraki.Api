namespace Meraki.Api.Data;

/// <summary>
/// AllowedUrl
/// </summary>
[DataContract]
public class AllowedUrl
{
	/// <summary>
	/// The url to allow
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "url")]
	public string Url { get; set; } = string.Empty;

	/// <summary>
	/// Comment about the allowed URL
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "comment")]
	public string Comment { get; set; } = string.Empty;
}
