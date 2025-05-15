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
}
