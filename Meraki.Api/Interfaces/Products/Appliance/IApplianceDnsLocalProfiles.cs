namespace Meraki.Api.Interfaces.Products.Appliance;

public interface IApplianceDnsLocalProfiles
{
	/// <summary>
	/// Create a new local DNS profile
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">The organization id</param>
	/// <param name="dnsLocalProfileCreateRequest">Body for creating a local DNS profile</param>
	/// <param name="cancellationToken">Token to cancel the request.</param>
	[ApiOperationId("createOrganizationApplianceDnsLocalProfile")]
	[Post("/organizations/{organizationId}/appliance/dns/local/profiles")]
	Task<ApplianceDnsLocalProfile> CreateOrganizationApplianceDnsLocalProfileAsync(
		string organizationId,
		[Body] ApplianceDnsLocalProfileCreateUpdateRequest dnsLocalProfileCreateRequest,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Fetch the local DNS profiles used in the organization
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">The organization id</param>
	/// <param name="cancellationToken">Token to cancel the request.</param>
	[ApiOperationId("getOrganizationApplianceDnsLocalProfiles")]
	[Get("/organizations/{organizationId}/appliance/dns/local/profiles")]
	Task<List<ApplianceDnsLocalProfile>> GetOrganizationApplianceDnsLocalProfilesAsync(
		string organizationId,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Update a local DNS profile
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">The organization id</param>
	/// <param name="profileId">The profile id</param>"
	/// <param name="cancellationToken">Token to cancel the request.</param>
	[ApiOperationId("updateOrganizationApplianceDnsLocalProfile")]
	[Put("/organizations/{organizationId}/appliance/dns/local/profiles/{profileId}")]
	Task<ApplianceDnsLocalProfile> UpdateOrganizationApplianceDnsLocalProfileAsync(
		string organizationId,
		string profileId,
		[Body] ApplianceDnsLocalProfileCreateUpdateRequest dnsLocalProfileUpdateRequest,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Deletes a local DNS profile
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">The organization id</param>
	/// <param name="profileId">The profile id</param>"
	/// <param name="cancellationToken">Token to cancel the request.</param>
	[ApiOperationId("deleteOrganizationApplianceDnsLocalProfile")]
	[Delete("/organizations/{organizationId}/appliance/dns/local/profiles/{profileId}")]
	Task DeleteOrganizationApplianceDnsLocalProfileAsync(
		string organizationId,
		string profileId,
		CancellationToken cancellationToken = default
		);
}
