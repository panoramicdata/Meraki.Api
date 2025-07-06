﻿namespace Meraki.Api.Extensions;

public static class IOrganizationsConfigurationChangesExtensions
{
	/// <summary>
	/// Get all Change Log Entries for your organization
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationConfigurationChanges"></param>
	/// <param name="organizationId">The organization id</param>
	/// <param name="t0">The beginning of the timespan for the data. The maximum lookback period is 365 days from today. (optional)</param>
	/// <param name="t1">The end of the timespan for the data. t1 can be a maximum of 365 days after t0. (optional)</param>
	/// <param name="timespan">The timespan for which the information will be fetched. If specifying timespan, do not specify parameters t0 and t1. The value must be in seconds and be less than or equal to 365 days. The default is 365 days. (optional)</param>
	/// <param name="networkId">Filters on the given network (optional)</param>
	/// <param name="adminId">Filters on the given Admin (optional)</param>
	/// <param name="cancellationToken"></param>
	public static Task<List<ChangeLogEntry>> GetOrganizationConfigurationChangesAllAsync(
		this IOrganizationsConfigurationChanges organizationConfigurationChanges,
		string organizationId,
		string? t0 = null,
		string? t1 = null,
		double? timespan = null,
		string? networkId = null,
		string? adminId = null,
		CancellationToken cancellationToken = default)
			=> MerakiClient.GetAllAsync(
				(startingAfter, endingBefore, cancellationToken)
				=> organizationConfigurationChanges.GetOrganizationConfigurationChangesApiResponseAsync(
					organizationId,
					t0,
					t1,
					timespan,
					startingAfter,
					endingBefore,
					networkId,
					adminId,
					cancellationToken)
				, cancellationToken
				);
}
