namespace Meraki.Api.Data;

/// <summary>
/// Organization Splash Theme
/// </summary>
[DataContract]
public class OrganizationSplashTheme : NamedIdentifiedItem
{
	/// <summary>
	/// list of theme assets
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "themeAssets")]
	public List<OrganizationSplashThemeThemeAsset> ThemeAssets { get; set; } = [];
}
