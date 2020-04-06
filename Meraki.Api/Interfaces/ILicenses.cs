using Meraki.Api.Data;
using Refit;
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
		/// assignOrganizationLicensesSeats
		/// </summary>
		/// <remarks>
		/// Assign SM seats to a network. This will increase the managed SM device limit of the network
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="organizationId"></param>
		/// <param name="assignOrganizationLicensesSeats"></param>
		/// <returns>Task of Object</returns>
		[Post("/organizations/{organizationId}/licenses/assignSeats")]
		Task<object> AssignOrganizationLicensesSeatsAsync(
			[AliasAs("organizationId")]string organizationId,
			[Body]LicenseSeatsAssignmentRequest licenseSeatsAssignmentRequest,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// getOrganizationLicense
		/// </summary>
		/// <remarks>
		/// Display a license
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="organizationId"></param>
		/// <param name="licenseId"></param>
		/// <returns>Task of Object</returns>
		[Get("/organizations/{organizationId}/licenses/{licenseId}")]
		Task<object> GetAsync(
			[AliasAs("organizationId")]string organizationId,
			[AliasAs("licenseId")]string licenseId,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// getOrganizationLicenses
		/// </summary>
		/// <remarks>
		/// List the licenses for an organization
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="organizationId"></param>
		/// <param name="perPage">The number of entries per page returned. Acceptable range is 3 - 1000. Default is 1000. (optional)</param>
		/// <param name="startingAfter">A token used by the server to indicate the start of the page. Often this is a timestamp or an ID but it is not limited to those. This parameter should not be defined by client applications. The link for the first, last, prev, or next page in the HTTP Link header should define it. (optional)</param>
		/// <param name="endingBefore">A token used by the server to indicate the end of the page. Often this is a timestamp or an ID but it is not limited to those. This parameter should not be defined by client applications. The link for the first, last, prev, or next page in the HTTP Link header should define it. (optional)</param>
		/// <param name="deviceSerial">Filter the licenses to those assigned to a particular device (optional)</param>
		/// <param name="networkId">Filter the licenses to those assigned in a particular network (optional)</param>
		/// <param name="state">Filter the licenses to those in a particular state. Can be one of &#39;active&#39;, &#39;expired&#39;, &#39;expiring&#39;, &#39;unused&#39;, &#39;unusedActive&#39; or &#39;recentlyQueued&#39; (optional)</param>
		/// <returns>Task of Object</returns>
		[Get("/organizations/{organizationId}/licenses")]
		Task<object> GetPageAsync(
			[AliasAs("organizationId")]string organizationId,
			[AliasAs("perPage")]int? perPage = null,
			[AliasAs("startingAfter")]string startingAfter = null!,
			[AliasAs("endingBefore")]string endingBefore = null!,
			[AliasAs("deviceSerial")]string deviceSerial = null!,
			[AliasAs("networkId")]string networkId = null!,
			[AliasAs("state")]string state = null!,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// moveOrganizationLicenses
		/// </summary>
		/// <remarks>
		/// Move licenses to another organization. This will also move any devices that the licenses are assigned to
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="organizationId"></param>
		/// <param name="licenseMoveRequest"></param>
		/// <returns>Task of Object</returns>
		[Post("/organizations/{organizationId}/licenses/move")]
		Task<object> MoveToOrganizationAsync(
			[AliasAs("organizationId")]string organizationId,
			[Body]LicenseMoveRequest licenseMoveRequest,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// moveOrganizationLicensesSeats
		/// </summary>
		/// <remarks>
		/// Move SM seats to another organization
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="organizationId"></param>
		/// <param name="licenseSeatsMoveRequest"></param>
		/// <returns>Task of Object</returns>
		[Post("/organizations/{organizationId}/licenses/moveSeats")]
		Task<object> MoveSeatsAsync(
			[AliasAs("organizationId")]string organizationId,
			[Body]LicenseSeatsMoveRequest licenseSeatsMoveRequest,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// renewOrganizationLicensesSeats
		/// </summary>
		/// <remarks>
		/// Renew SM seats of a license. This will extend the license expiration date of managed SM devices covered by this license
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="organizationId"></param>
		/// <param name="licenseSeatsRenewalRequest"></param>
		/// <returns>Task of Object</returns>
		[Post("/organizations/{organizationId}/licenses/renewSeats")]
		Task<object> RenewSeatsAsync(
			[AliasAs("organizationId")]string organizationId,
			[Body]LicenseSeatsRenewalRequest licenseSeatsRenewalRequest,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// updateOrganizationLicense
		/// </summary>
		/// <remarks>
		/// Update a license
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="organizationId"></param>
		/// <param name="licenseId"></param>
		/// <param name="updateOrganizationLicense"> (optional)</param>
		/// <returns>Task of Object</returns>
		[Put("/organizations/{organizationId}/licenses/{licenseId}")]
		Task<object> UpdateAsync(
			[AliasAs("organizationId")]string organizationId,
			[AliasAs("licenseId")]string licenseId,
			[Body]LicenseUpdateRequest updateOrganizationLicense,
			CancellationToken cancellationToken = default);
	}
}
