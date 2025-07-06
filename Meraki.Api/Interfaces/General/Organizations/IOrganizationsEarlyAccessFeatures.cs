namespace Meraki.Api.Interfaces.General.Organizations;

public interface IOrganizationsEarlyAccessFeatures
{
	/// <summary>
	/// List the available early access features for organization
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">The organization id</param>
	[Get("/organizations/{organizationId}/earlyAccess/features")]
	Task<List<EarlyAccessFeature>> GetOrganizationEarlyAccessFeaturesAsync(
		string organizationId
		);

	/// <summary>
	/// List the early access feature opt-ins for an organization
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">The organization id</param>
	/// <param name="cancellation"></param>
	[ApiOperationId("getOrganizationEarlyAccessFeaturesOptIns")]
	[Get("/organizations/{organizationId}/earlyAccess/features/optIns")]
	Task<List<EarlyAccessFeatureOptIn>> GetOrganizationEarlyAccessFeaturesOptInsAsync(
		string organizationId,
		CancellationToken cancellation = default);

	/// <summary>
	/// Create a new early access feature opt-in for an organization
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">The organization id</param>
	/// <param name="earlyAccessFeatureOptInCreateRequest"></param>
	/// <param name="cancellation"></param>
	[ApiOperationId("createOrganizationEarlyAccessFeaturesOptIn")]
	[Post("/organizations/{organizationId}/earlyAccess/features/optIns")]
	Task<EarlyAccessFeatureOptIn> CreateOrganizationEarlyAccessFeaturesOptInAsync(
		string organizationId,
		[Body] EarlyAccessFeatureOptInCreateRequest earlyAccessFeatureOptInCreateRequest,
		CancellationToken cancellation = default);

	/// <summary>
	/// Show an early access feature opt-in for an organization
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">The organization id</param>
	/// <param name="optInId">The opt in id</param>
	/// <param name="cancellation"></param>
	[ApiOperationId("getOrganizationEarlyAccessFeaturesOptIn")]
	[Get("/organizations/{organizationId}/earlyAccess/features/optIns/{optInId}")]
	Task<EarlyAccessFeatureOptIn> GetOrganizationEarlyAccessFeaturesOptInAsync(
		string organizationId,
		string optInId,
		CancellationToken cancellation = default);

	/// <summary>
	/// Update an early access feature opt-in for an organization
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">The organization id</param>
	/// <param name="optInId"></param>
	/// <param name="earlyAccessFeatureOptInUpdateRequest"></param>
	/// <param name="cancellation"></param>
	[ApiOperationId("updateOrganizationEarlyAccessFeaturesOptIn")]
	[Put("/organizations/{organizationId}/earlyAccess/features/optIns/{optInId}")]
	Task<EarlyAccessFeatureOptIn> UpdateOrganizationEarlyAccessFeaturesOptInAsync(
		string organizationId,
		string optInId,
		[Body] EarlyAccessFeatureOptInUpdateRequest earlyAccessFeatureOptInUpdateRequest,
		CancellationToken cancellation = default);

	/// <summary>
	/// Delete an early access feature opt-in
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">The organization id</param>
	/// <param name="optInId">The Opt In Id</param>
	/// <param name="cancellationToken"></param>
	[ApiOperationId("deleteOrganizationEarlyAccessFeaturesOptIn")]
	[Delete("/organizations/{organizationId}/earlyAccess/features/optIns/{optInId}")]
	Task DeleteOrganizationEarlyAccessFeaturesOptInAsync(
		string organizationId,
		string optInId,
		CancellationToken cancellationToken = default
		);
}
