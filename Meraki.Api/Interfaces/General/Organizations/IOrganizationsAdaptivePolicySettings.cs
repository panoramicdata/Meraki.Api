namespace Meraki.Api.Interfaces.General.Organizations;

/// <summary>
/// I Organizations Adaptive Policy
/// </summary>
public interface IOrganizationsAdaptivePolicySettings
{
	/// <summary>
	/// Returns global adaptive policy settings in an organization
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">The organization id</param>
	/// <param name="cancellationToken"></param>
	[Get("/organizations/{organizationId}/adaptivePolicy/settings")]
	Task<AdaptivePolicySettings> GetOrganizationAdaptivePolicySettingsAsync(
		string organizationId,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Returns global adaptive policy settings in an organization
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">The organization id</param>
	/// <param name="adaptivePolicySettings"></param>
	/// <param name="cancellationToken"></param>
	[Put("/organizations/{organizationId}/adaptivePolicy/settings")]
	Task<AdaptivePolicySettings> UpdateOrganizationAdaptivePolicySettingsAsync(
		string organizationId,
		[Body] AdaptivePolicySettings adaptivePolicySettings,
		CancellationToken cancellationToken = default);
}
