namespace Meraki.Api.Interfaces.General.Organizations;
public interface IOrganizationsApplianceSdwan
{
	/// <summary>
	/// Get the SDWAN internet traffic preferences for an MX network
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("getOrganizationApplianceSdwanInternetPolicies")]
	[Get("/organizations/{organizationId}/appliance/sdwan/internetPolicies")]
	Task<OrganizationApplianceSdwanInternetPolicies> GetOrganizationApplianceSdwanInternetPoliciesAsync(
		string organizationId,
		CancellationToken cancellationToken = default
	);
}
