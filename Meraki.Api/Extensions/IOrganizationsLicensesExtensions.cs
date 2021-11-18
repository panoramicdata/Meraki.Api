﻿namespace Meraki.Api.Extensions;

public static class IOrganizationsLicensesExtensions
{
	/// <summary>
	/// List the licenses for an organization
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">The organization id</param>
	/// <param name="deviceSerial">Filter the licenses to those assigned to a particular device (optional)</param>
	/// <param name="networkId">Filter the licenses to those assigned in a particular network (optional)</param>
	/// <param name="state">Filter the licenses to those in a particular state. Can be one of &#39;active&#39;, &#39;expired&#39;, &#39;expiring&#39;, &#39;unused&#39;, &#39;unusedActive&#39; or &#39;recentlyQueued&#39; (optional)</param>
	public static Task<List<OrganizationLicense>> GetOrganizationLicensesAllAsync(
		this IOrganizationsLicenses organizationsLicenses,
		string organizationId,
		string? deviceSerial = null,
		string? networkId = null,
		string? state = null,
		CancellationToken cancellationToken = default)
			=> MerakiClient.GetAllAsync(
				(startingAfter, cancellationToken)
				=> organizationsLicenses.GetPagedApiResponseAsync(
					organizationId,
					startingAfter,
					deviceSerial,
					networkId,
					state,
					cancellationToken)
				, cancellationToken
				);
}
