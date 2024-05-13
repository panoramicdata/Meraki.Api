namespace Meraki.Api.Extensions;

public static class IOrganizationsAssuranceExtensions
{
	/// <summary>
	/// Return all health alerts for an organization
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	public static Task<List<OrganizationAssuranceAlert>> GetOrganizationAssuranceAlertsAllAsync(
		this IOrganizationsAssuranceAlerts organizationAssuranceAlerts,
		string organizationId,
		string? sortOrder,
		string? network,
		string? severity,
		List<string>? types,
		string? tsStart,
		string? tsEnd,
		string? category,
		string? sortBy,
		List<string>? serials,
		List<string>? deviceTypes,
		List<string>? deviceTags,
		bool? active,
		bool? dismissed,
		bool? resolved,
		bool? suppressAlertsForOfflineNodes,
		CancellationToken cancellationToken = default)
		=> MerakiClient.GetAllAsync(
				(startingAfter, cancellationToken)
				=> organizationAssuranceAlerts.GetOrganizationAssuranceAlertsApiResponseAsync(
						organizationId,
						startingAfter,
						sortOrder,
						network,
						severity,
						types,
						tsStart,
						tsEnd,
						category,
						sortBy,
						serials,
						deviceTypes,
						deviceTags,
						active,
						dismissed,
						resolved,
						suppressAlertsForOfflineNodes,
						cancellationToken
					),
					cancellationToken
			);
}
