namespace Meraki.Api.Interfaces.General.Organizations;
public interface IOrganizationsApplianceDnsLocalProfiles
{
	/// <summary>
	/// Fetch the local DNS profile assignments in the organization
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("getOrganizationApplianceDnsLocalProfilesAssignments")]
	[Get("/organizations/{organizationId}/appliance/dns/local/profiles/assignments")]
	Task<OrganizationApplianceDnsLocalProfilesAssignmentsResponse> GetOrganizationApplianceDnsLocalProfilesAssignmentsAsync(
		string organizationId,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Assign the local DNS profile to networks in the organization
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId"></param>
	/// <param name="request"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("bulkOrganizationApplianceDnsLocalProfilesAssignmentsCreate")]
	[Post("/organizations/{organizationId}/appliance/dns/local/profiles/assignments/bulkCreate")]
	Task<OrganizationApplianceDnsLocalProfilesAssignmentsBulkResponse> BulkCreateOrganizationApplianceDnsLocalProfilesAssignmentsAsync(
		string organizationId,
		OrganizationApplianceDnsLocalProfilesAssignmentsBulkCreateRequest request,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Unassign the local DNS profile to networks in the organization
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId"></param>
	/// <param name="request"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("createOrganizationApplianceDnsLocalProfilesAssignmentsBulkDelete")]
	[Post("/organizations/{organizationId}/appliance/dns/local/profiles/assignments/bulkDelete")]
	Task<OrganizationApplianceDnsLocalProfilesAssignmentsBulkResponse> CreateOrganizationApplianceDnsLocalProfilesAssignmentsBulkDeleteAsync(
		string organizationId,
		OrganizationApplianceDnsLocalProfilesAssignmentsBulkDeleteRequest request,
		CancellationToken cancellationToken = default);
}
