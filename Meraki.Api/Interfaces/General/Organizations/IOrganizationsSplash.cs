namespace Meraki.Api.Interfaces.General.Organizations;

public interface IOrganizationsSplash
{
	/// <summary>
	/// Get a Splash Theme Asset
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">The organization id</param>
	/// <param name="id">ID</param>
	[ApiOperationId("getOrganizationSplashAsset")]
	[Get("/organizations/{organizationId}/splash/assets/{id}")]
	Task<OrganizationSplashAsset> GetOrganizationSplashAssetAsync(
		string organizationId,
		string id,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Delete a Splash Theme Asset
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">The organization id</param>
	/// <param name="id">ID</param>
	[ApiOperationId("deleteOrganizationSplashAsset")]
	[Delete("/organizations/{organizationId}/splash/assets/{id}")]
	Task DeleteOrganizationSplashAssetAsync(
		string organizationId,
		string id,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// List Splash Themes
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">The organization id</param>
	[ApiOperationId("getOrganizationSplashThemes")]
	[Get("/organizations/{organizationId}/splash/themes")]
	Task<List<OrganizationSplashTheme>> GetOrganizationSplashThemesAsync(
		string organizationId,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Create a Splash Theme
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">The organization id</param>
	/// <param name="splashThemeCreateRequest">The splash theme create request body</param>
	/// <param name="cancellationToken">The cancellation token</param>
	[ApiOperationId("createOrganizationSplashTheme")]
	[Post("/organizations/{organizationId}/splash/themes")]
	Task<OrganizationSplashTheme> CreateOrganizationSplashThemeAsync(
		string organizationId,
		[Body] OrganizationSplashThemeCreateRequest splashThemeCreateRequest,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Delete a Splash Theme
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">The organization id</param>
	/// <param name="id">ID</param>
	/// <param name="cancellationToken">The cancellation token</param>
	[ApiOperationId("deleteOrganizationSplashTheme")]
	[Delete("/organizations/{organizationId}/splash/themes/{id}")]
	Task DeleteOrganizationSplashThemeAsync(
		string organizationId,
		string id,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Create a Splash Theme Asset
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">The organization id</param>
	/// <param name="themeIdentifier">The splash theme id</param>"
	/// <param name="splashThemeCreateRequest">The splash theme create request body</param>
	/// <param name="cancellationToken">The cancellation token</param>
	[ApiOperationId("createOrganizationSplashThemeAsset")]
	[Post("/organizations/{organizationId}/splash/themes/{themeIdentifier}/assets")]
	Task<OrganizationSplashAsset> CreateOrganizationSplashThemeAssetAsync(
		string organizationId,
		string themeIdentifier,
		[Body] OrganizationSplashThemeAssetCreateRequest splashThemeCreateRequest,
		CancellationToken cancellationToken = default
		);
}
