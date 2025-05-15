namespace Meraki.Api.Interfaces.General.Organizations;
public interface IOrganizationsApplianceDnsSplitProfiles
{
	/// <summary>
	/// Fetch the split DNS profiles used in the organization
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("getOrganizationApplianceDnsSplitProfiles")]
	[Get("/organizations/{organizationId}/appliance/dns/split/profiles")]
	Task<List<OrganizationApplianceDnsSplitProfile>> GetOrganizationApplianceDnsSplitProfilesAsync(
		string organizationId,
		CancellationToken cancellationToken = default
	);

	/// <summary>
	/// Create a new split DNS profile
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId"></param>
	/// <param name="request"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("createOrganizationApplianceDnsSplitProfile")]
	[Post("/organizations/{organizationId}/appliance/dns/split/profiles")]
	Task<OrganizationApplianceDnsSplitProfile> CreateOrganizationApplianceDnsSplitProfileAsync(
		string organizationId,
		[Body] OrganizationApplianceDnsSplitProfileCreateRequest request,
		CancellationToken cancellationToken = default
	);

	/// <summary>
	/// Update a split DNS profile
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId"></param>
	/// <param name="profileId"></param>
	/// <param name="request"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("updateOrganizationApplianceDnsSplitProfile")]
	[Put("/organizations/{organizationId}/appliance/dns/split/profiles/{profileId}")]
	Task<OrganizationApplianceDnsSplitProfile> UpdateOrganizationApplianceDnsSplitProfileAsync(
		string organizationId,
		string profileId,
		[Body] OrganizationApplianceDnsSplitProfileUpdateRequest request,
		CancellationToken cancellationToken = default
	);

	/// <summary>
	/// Deletes a split DNS profile
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId"></param>
	/// <param name="profileId"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("deleteOrganizationApplianceDnsSplitProfile")]
	[Delete("/organizations/{organizationId}/appliance/dns/split/profiles/{profileId}")]
	Task DeleteOrganizationApplianceDnsSplitProfileAsync(
		string organizationId,
		string profileId,
		CancellationToken cancellationToken = default
	);

	/// <summary>
	/// Fetch the split DNS profile assignments in the organization
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("getOrganizationApplianceDnsSplitProfilesAssignments")]
	[Get("/organizations/{organizationId}/appliance/dns/split/profiles/assignments")]
	Task<OrganizationApplianceDnsSplitProfilesAssignmentResponse> GetOrganizationApplianceDnsSplitProfilesAssignmentsAsync(
		string organizationId,
		CancellationToken cancellationToken = default
	);

	/// <summary>
	/// Assign the split DNS profile to networks in the organization
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId"></param>
	/// <param name="request"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("createOrganizationApplianceDnsSplitProfilesAssignmentsBulkCreate")]
	[Post("/organizations/{organizationId}/appliance/dns/split/profiles/assignments/bulkCreate")]
	Task<OrganizationApplianceDnsSplitProfilesAssignmentBulkResponse> CreateOrganizationApplianceDnsSplitProfilesAssignmentsBulkCreateAsync(
		string organizationId,
		[Body] OrganizationApplianceDnsSplitProfilesAssignmentBulkCreateRequest request,
		CancellationToken cancellationToken = default
	);
}
