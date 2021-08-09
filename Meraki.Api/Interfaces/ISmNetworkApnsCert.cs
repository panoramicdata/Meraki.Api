using Meraki.Api.Data;
using Refit;
using System.Threading;
using System.Threading.Tasks;

namespace Meraki.Api.Interfaces
{
	/// <summary>
	/// Represents a collection of functions to interact with the API endpoints
	/// </summary>
	public interface ISmNetworkApnsCert
	{
		/// <summary>
		/// getOrganizationSmApnsCert
		/// </summary>
		/// <remarks>
		/// Get the organization's APNS certificate
		/// </remarks>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="organizationId">The Organization id</param>
		/// <returns>Task of Object</returns>
		[Get("/organizations/{organizationId}/sm/apnsCert")]
		Task<ApnsCert> GetOrganizationSmApnsCert(
			[AliasAs("organizationId")]string organizationId,
			CancellationToken cancellationToken = default);
	}
}