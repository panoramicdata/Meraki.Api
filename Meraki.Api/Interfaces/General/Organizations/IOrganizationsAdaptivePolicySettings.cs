namespace Meraki.Api.Interfaces.General.Organizations;

public interface IOrganizationsAdaptivePolicySettings
{
	/// <summary>
	/// Returns global adaptive policy settings in an organization
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">The organization id</param>
	[Get("/organizations/{organizationId}/adaptivePolicy/settings")]
	Task<AdaptivePolicySettings> GetOrganizationAdaptivePolicySettingsAsync(
		[AliasAs("organizationId")] string organizationId,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Returns global adaptive policy settings in an organization
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">The organization id</param>
	[Put("/organizations/{organizationId}/adaptivePolicy/settings")]
	Task<AdaptivePolicySettings> UpdateOrganizationAdaptivePolicySettingsAsync(
		[AliasAs("organizationId")] string organizationId,
		[Body] AdaptivePolicySettings adaptivePolicySettings,
		CancellationToken cancellationToken = default);
}