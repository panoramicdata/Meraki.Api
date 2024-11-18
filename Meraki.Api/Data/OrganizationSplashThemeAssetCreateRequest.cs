namespace Meraki.Api.Data;

/// <summary>
/// Organization Splash Theme Asset Create Request
/// </summary>
[DataContract]
public class OrganizationSplashThemeAssetCreateRequest
{
	/// <summary>
	/// a file containing the asset content
	/// </summary>
	[ApiAccess(ApiAccess.ReadCreate)]
	[DataMember(Name = "content")]
	public string Content { get; set; } = string.Empty;

	/// <summary>
	/// File name. Will overwrite files with same name.
	/// </summary>
	[ApiAccess(ApiAccess.ReadCreate)]
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;
}
