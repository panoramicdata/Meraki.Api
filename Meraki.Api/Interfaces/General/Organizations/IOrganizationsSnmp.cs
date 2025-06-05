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
		string organizationId,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Update the SNMP settings for an organization
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">The organization id</param>
	/// <param name="updateOrganizationSnmp"></param>
	[Put("/organizations/{organizationId}/snmp")]
	Task<OrganizationSnmp> UpdateOrganizationSnmpAsync(
		string organizationId,
		[Body] OrganizationSnmpUpdateRequest updateOrganizationSnmp,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Retrieve the SNMP trap configuration for the networks in an organization
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("getOrganizationSnmpTrapsByNetwork")]
	[Get("/organizations/{organizationId}/snmp/traps/byNetwork")]
	Task<List<OrganizationSnmpTrapByNetwork>> GetOrganizationSnmpTrapByNetworksAsync(
		string organizationId,
		CancellationToken cancellationToken = default
		);
}
