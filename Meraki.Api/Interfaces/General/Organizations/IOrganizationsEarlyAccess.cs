namespace Meraki.Api.Interfaces.General.Organizations;

public interface IOrganizationsEarlyAccess
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
}
