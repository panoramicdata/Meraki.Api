using Meraki.Api.Data;
using Refit;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Meraki.Api.Interfaces
{
	/// <summary>
	/// Represents a collection of functions to interact with the API endpoints
	/// </summary>
	public interface ILicenses
	{
		/// <summary>
		/// Assign SM seats to a network
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="organizationId">The organization id</param>
		[Post("/organizations/{organizationId}/licenses/assignSeats")]
		Task<AssignSeatsResponse> AssignOrganizationLicensesSeatsAsync(
			[AliasAs("organizationId")] string organizationId,
			[Body] LicenseSeatsAssignmentRequest LicenseSeatsAssignmentRequest,
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
		Task<List<OrganizationLicense>> GetPageAsync(
			[AliasAs("organizationId")] string organizationId,
			[AliasAs("perPage")] int? perPage = null,
			[AliasAs("startingAfter")] string startingAfter = null!,
			[AliasAs("endingBefore")] string endingBefore = null!,
			[AliasAs("deviceSerial")] string deviceSerial = null!,
			[AliasAs("networkId")] string networkId = null!,
			[AliasAs("state")] string state = null!,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// Move licenses to another organization
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="organizationId">The organization id</param>
		/// <param name="LicenseMoveRequest">Body for moving a license</param>
		[Post("/organizations/{organizationId}/licenses/move")]
		Task<LicenseMoveRequest> MoveToOrganizationAsync(
			[AliasAs("organizationId")] string organizationId,
			[Body] LicenseMoveRequest LicenseMoveRequest,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// Move SM seats to another organization
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="organizationId">The organization id</param>
		/// <param name="LicenseSeatsMoveRequest">Body for moving SM seats</param>
		[Post("/organizations/{organizationId}/licenses/moveSeats")]
		Task<LicenseSeatsMoveRequest> MoveSeatsAsync(
			[AliasAs("organizationId")] string organizationId,
			[Body] LicenseSeatsMoveRequest LicenseSeatsMoveRequest,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// Renew SM seats of a license
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="organizationId">The organization id</param>
		/// <param name="LicenseSeatsRenewalRequest">Body for renewing SM seats</param>
		[Post("/organizations/{organizationId}/licenses/renewSeats")]
		Task<AssignSeatsResponse> RenewSeatsAsync(
			[AliasAs("organizationId")] string organizationId,
			[Body] LicenseSeatsRenewalRequest LicenseSeatsRenewalRequest,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// Update a license
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="organizationId">The organization id</param>
		/// <param name="licenseId">The license id</param>
		/// <param name="UpdateOrganizationLicense">Body for updating a license</param>
		[Put("/organizations/{organizationId}/licenses/{licenseId}")]
		Task<OrganizationLicense> UpdateAsync(
			[AliasAs("organizationId")] string organizationId,
			[AliasAs("licenseId")] string licenseId,
			[Body] LicenseUpdateRequest UpdateOrganizationLicense,
			CancellationToken cancellationToken = default);
	}
}
