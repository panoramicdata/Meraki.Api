namespace Meraki.Api.Interfaces.General.Organizations;

public interface IOrganizationsSnmp
{
	/// <summary>
	/// Return the SNMP settings for an organization
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">The organization id</param>
	[Get("/organizations/{organizationId}/snmp")]
	Task<OrganizationSnmp> GetOrganizationSnmpAsync(
		[AliasAs("organizationId")] string organizationId,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Update the SNMP settings for an organization
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">The organization id</param>
	/// <param name="updateOrganizationSnmp"></param>
	[Put("/organizations/{organizationId}/snmp")]
	Task<OrganizationSnmpUpdateRequest> UpdateOrganizationSnmpAsync(
		[AliasAs("organizationId")] string organizationId,
		[Body] OrganizationSnmpUpdateRequest updateOrganizationSnmp,
		CancellationToken cancellationToken = default
		);
}
