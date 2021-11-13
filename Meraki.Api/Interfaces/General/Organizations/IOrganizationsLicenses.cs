﻿namespace Meraki.Api.Interfaces.General.Organizations;

public interface IOrganizationsLicenses
{
	/// <summary>
	/// Assign SM seats to a network
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">The organization id</param>
	[Post("/organizations/{organizationId}/licenses/assignSeats")]
	Task<AssignSeatsResponse> AssignOrganizationLicensesSeatsAsync(
		[AliasAs("organizationId")] string organizationId,
		[Body] LicenseSeatsAssignmentRequest licenseSeatsAssignmentRequest,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Display a license
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">The organization id</param>
	/// <param name="licenseId">The license id</param>
	[Get("/organizations/{organizationId}/licenses/{licenseId}")]
	Task<OrganizationLicense> GetAsync(
		[AliasAs("organizationId")] string organizationId,
		[AliasAs("licenseId")] string licenseId,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// List the licenses for an organization
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">The organization id</param>
	/// <param name="perPage">The number of entries per page returned. Acceptable range is 3 - 1000. Default is 1000. (optional)</param>
	/// <param name="startingAfter">A token used by the server to indicate the start of the page. Often this is a timestamp or an ID but it is not limited to those. This parameter should not be defined by client applications. The link for the first, last, prev, or next page in the HTTP Link header should define it. (optional)</param>
	/// <param name="endingBefore">A token used by the server to indicate the end of the page. Often this is a timestamp or an ID but it is not limited to those. This parameter should not be defined by client applications. The link for the first, last, prev, or next page in the HTTP Link header should define it. (optional)</param>
	/// <param name="deviceSerial">Filter the licenses to those assigned to a particular device (optional)</param>
	/// <param name="networkId">Filter the licenses to those assigned in a particular network (optional)</param>
	/// <param name="state">Filter the licenses to those in a particular state. Can be one of &#39;active&#39;, &#39;expired&#39;, &#39;expiring&#39;, &#39;unused&#39;, &#39;unusedActive&#39; or &#39;recentlyQueued&#39; (optional)</param>
	[Get("/organizations/{organizationId}/licenses")]
	Task<List<OrganizationLicense>> GetPagedAsync(
		[AliasAs("organizationId")] string organizationId,
		[AliasAs("perPage")] int? perPage = 1000,
		[AliasAs("startingAfter")] string? startingAfter = null,
		[AliasAs("endingBefore")] string? endingBefore = null,
		[AliasAs("deviceSerial")] string? deviceSerial = null,
		[AliasAs("networkId")] string? networkId = null,
		[AliasAs("state")] string? state = null,
		CancellationToken cancellationToken = default);

	[Get("/organizations/{organizationId}/licenses")]
	internal Task<ApiResponse<List<OrganizationLicense>>> GetPagedApiResponseAsync(
		[AliasAs("organizationId")] string organizationId,
		[AliasAs("startingAfter")] string? startingAfter = null,
		[AliasAs("deviceSerial")] string? deviceSerial = null,
		[AliasAs("networkId")] string? networkId = null,
		[AliasAs("state")] string? state = null,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// List the licenses for an organization
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">The organization id</param>
	/// <param name="perPage">The number of entries per page returned. Acceptable range is 3 - 1000. Default is 1000. (optional)</param>
	/// <param name="startingAfter">A token used by the server to indicate the start of the page. Often this is a timestamp or an ID but it is not limited to those. This parameter should not be defined by client applications. The link for the first, last, prev, or next page in the HTTP Link header should define it. (optional)</param>
	/// <param name="deviceSerial">Filter the licenses to those assigned to a particular device (optional)</param>
	/// <param name="networkId">Filter the licenses to those assigned in a particular network (optional)</param>
	/// <param name="state">Filter the licenses to those in a particular state. Can be one of &#39;active&#39;, &#39;expired&#39;, &#39;expiring&#39;, &#39;unused&#39;, &#39;unusedActive&#39; or &#39;recentlyQueued&#39; (optional)</param>
	Task<List<OrganizationLicense>> GetAllAsync(
		string organizationId,
		int? perPage = 1000,
		string? startingAfter = null,
		string? deviceSerial = null,
		string? networkId = null,
		string? state = null,
		CancellationToken cancellationToken = default)
			=> MerakiClient.GetAllAsync(
				(startingAfter, cancellationToken)
				=> GetPagedApiResponseAsync(
					organizationId,
					startingAfter,
					deviceSerial,
					networkId,
					state,
					cancellationToken)
				, cancellationToken
				);

	/// <summary>
	/// Move licenses to another organization
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">The organization id</param>
	/// <param name="licenseMoveRequest">Body for moving a license</param>
	[Post("/organizations/{organizationId}/licenses/move")]
	Task<LicenseMoveRequest> MoveToOrganizationAsync(
		[AliasAs("organizationId")] string organizationId,
		[Body] LicenseMoveRequest licenseMoveRequest,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Move SM seats to another organization
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">The organization id</param>
	/// <param name="licenseSeatsMoveRequest">Body for moving SM seats</param>
	[Post("/organizations/{organizationId}/licenses/moveSeats")]
	Task<LicenseSeatsMoveRequest> MoveSeatsAsync(
		[AliasAs("organizationId")] string organizationId,
		[Body] LicenseSeatsMoveRequest licenseSeatsMoveRequest,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Renew SM seats of a license
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">The organization id</param>
	/// <param name="licenseSeatsRenewalRequest">Body for renewing SM seats</param>
	[Post("/organizations/{organizationId}/licenses/renewSeats")]
	Task<AssignSeatsResponse> RenewSeatsAsync(
		[AliasAs("organizationId")] string organizationId,
		[Body] LicenseSeatsRenewalRequest licenseSeatsRenewalRequest,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Update a license
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">The organization id</param>
	/// <param name="licenseId">The license id</param>
	/// <param name="updateOrganizationLicense">Body for updating a license</param>
	[Put("/organizations/{organizationId}/licenses/{licenseId}")]
	Task<OrganizationLicense> UpdateAsync(
		[AliasAs("organizationId")] string organizationId,
		[AliasAs("licenseId")] string licenseId,
		[Body] LicenseUpdateRequest updateOrganizationLicense,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Return an overview of the license state for an organization
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">The organization id</param>
	[Get("/organizations/{organizationId}/licenses/overview")]
	Task<OrganizationLicenseState> GetLicenseStateAsync(
		[AliasAs("organizationId")] string organizationId,
		CancellationToken cancellationToken = default);
}