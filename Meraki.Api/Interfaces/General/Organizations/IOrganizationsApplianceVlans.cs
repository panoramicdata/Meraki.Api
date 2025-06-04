namespace Meraki.Api.Interfaces.General.Organizations;
public interface IOrganizationsApplianceVlans
{
	/// <summary>
	/// List the VLANs for an Organization
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("getOrganizationApplianceVlans")]
	[Get("/organizations/{organizationId}/appliance/vlans")]
	Task<List<OrganizationsApplianceVlan>> GetOrganizationApplianceVlansAsync(string organizationId, CancellationToken cancellationToken = default);
}
