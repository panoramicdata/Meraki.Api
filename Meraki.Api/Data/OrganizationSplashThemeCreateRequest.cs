namespace Meraki.Api.Data;

/// <summary>
/// Organization Splash Theme Create Request
/// </summary>
[DataContract]
public class OrganizationSplashThemeCreateRequest
{
	/// <summary>
	/// base theme id
	/// </summary>
	[ApiAccess(ApiAccess.ReadCreate)]
	[DataMember(Name = "baseTheme")]
	public string BaseTheme { get; set; } = string.Empty;

	/// <summary>
	/// theme name
	/// </summary>
	[ApiAccess(ApiAccess.ReadCreate)]
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;
}
