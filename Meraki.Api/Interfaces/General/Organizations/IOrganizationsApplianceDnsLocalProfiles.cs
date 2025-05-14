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
	[Get("/organizations/{organizationId}/appliance/dns/localProfiles/assignments")]
	Task<OrganizationApplianceDnsLocalProfilesAssignmentsResponse> GetOrganizationApplianceDnsLocalProfilesAssignmentsAsync(
		string organizationId,
		CancellationToken cancellationToken = default);
}
