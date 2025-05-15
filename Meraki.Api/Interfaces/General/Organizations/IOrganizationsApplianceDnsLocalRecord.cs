namespace Meraki.Api.Interfaces.General.Organizations;
public interface IOrganizationsApplianceDnsLocalRecord
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

	/// <summary>
	/// Create a new local DNS record
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId"></param>
	/// <param name="request"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("createOrganizationApplianceDnsLocalRecord")]
	[Post("/organizations/{organizationId}/appliance/dns/local/records")]
	Task<OrganizationApplianceDnsLocalRecordsResponse> CreateOrganizationApplianceDnsLocalRecordAsync(
		string organizationId,
		OrganizationApplianceDnsLocalRecordsCreateRequest request,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Updates a local DNS record
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId"></param>
	/// <param name="recordId"></param>
	/// <param name="request"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("updateOrganizationApplianceDnsLocalRecord")]
	[Put("/organizations/{organizationId}/appliance/dns/local/records/{recordId}")]
	Task<OrganizationApplianceDnsLocalRecordsProfile> UpdateOrganizationApplianceDnsLocalRecordAsync(
		string organizationId,
		string recordId,
		OrganizationApplianceDnsLocalRecordsUpdateRequest request,
		CancellationToken cancellationToken = default);
}
