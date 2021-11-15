namespace Meraki.Api.Data;

/// <summary>
/// AllowedUrl
/// </summary>
[DataContract]
public class AllowedUrl
{
	/// <summary>
	/// The url to whitelist
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "url")]
	public string Url { get; set; } = string.Empty;

	/// <summary>
	/// Comment about the whitelisted entity
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "comment")]
	public string Comment { get; set; } = string.Empty;
}
