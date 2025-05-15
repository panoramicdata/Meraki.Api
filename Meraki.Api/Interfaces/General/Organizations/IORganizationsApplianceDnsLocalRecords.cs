namespace Meraki.Api.Interfaces.General.Organizations;
public interface IOrganizationsApplianceDnsLocalRecords
{
	/// <summary>
	/// Fetch the DNS records used in local DNS profiles
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("getOrganizationApplianceDnsLocalRecords")]
	[Get("/organizations/{organizationId}/appliance/dns/local/records")]
	Task<OrganizationApplianceDnsLocalRecordsResponse> GetOrganizationApplianceDnsLocalRecordsAsync(
		string organizationId,
		CancellationToken cancellationToken = default);
}
