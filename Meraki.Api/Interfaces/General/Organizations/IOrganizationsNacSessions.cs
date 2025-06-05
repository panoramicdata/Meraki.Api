namespace Meraki.Api.Interfaces.General.Organizations;

public interface IOrganizationsNacSessions
{
	/// <summary>
	/// List the NAC Sessions for this organization
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("getOrganizationNacSessionsHistory")]
	[Get("/organizations/{organizationId}/nac/sessions/history")]
	Task<OrganizationsNacSessionsHistory> GetOrganizationsNacSessionsHistoryAsync(
		string organizationId,
		CancellationToken cancellationToken = default
	);

	/// <summary>
	/// Return the details of selected NAC Sessions
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId"></param>
	/// <param name="sessionId"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("getOrganizationNacSessionDetails")]
	[Get("/organizations/{organizationId}/nac/sessions/{sessionId}/details")]
	Task<OrganizationsNacSessionDetails> GetOrganizationsNacSessionsDetailsAsync(
		string organizationId,
		string sessionId,
		CancellationToken cancellationToken = default
	);
}
