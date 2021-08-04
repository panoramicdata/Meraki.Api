using Meraki.Api.Data;
using Microsoft.Extensions.DependencyInjection;
using Refit;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Meraki.Api.Interfaces
{
	/// <summary>
	/// Represents a collection of functions to interact with the API endpoints
	/// </summary>
	public interface IAlertTypes
	{
		/// <summary>
		/// getOrganizationWebhooksAlertTypes
		/// </summary>
		/// <remarks>
		/// Return a list of alert types to be used with managing webhook alerts
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="organizationId"></param>
		/// <returns>Task of Object</returns>
		[Get("/organizations/{organizationId}/webhooks/alertTypes")]
		Task<List<WebhookAlertType>> GetOrganizationWebhooksAlertTypes(
			[AliasAs("organizationId")] string organizationId
			);
	}
}
