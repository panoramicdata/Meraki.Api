namespace Meraki.Api.Interfaces.Products.Appliance;

public interface IApplianceSecurityIntrusion
{
	/// <summary>
	/// Returns all supported intrusion settings for an organization
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">The organization id</param>
	[Get("/organizations/{organizationId}/appliance/security/intrusion")]
	Task<OrganizationSecurityIntrusion> GetSecurityIntrusionAsync(
		[AliasAs("organizationId")] string organizationId,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Sets supported intrusion settings for an organization
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">The organization id</param>
	/// <param name="securityIntrusion">Body for updating security intrusion settings</param>
	[Put("/organizations/{organizationId}/appliance/security/intrusion")]
	Task<OrganizationSecurityIntrusion> UpdateSecurityIntrusionAsync(
		[AliasAs("organizationId")] string organizationId,
		[Body] OrganizationSecurityIntrusion securityIntrusion,
		CancellationToken cancellationToken = default
		);
}
