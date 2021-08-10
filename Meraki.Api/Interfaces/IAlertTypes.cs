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
		/// Return a list of alert types to be used with managing webhook alerts
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="organizationId">The organization id</param>
		[Get("/organizations/{organizationId}/webhooks/alertTypes")]
		Task<List<WebhookAlertType>> GetOrganizationWebhooksAlertTypesAsync(
			[AliasAs("organizationId")] string organizationId,
			CancellationToken cancellationToken = default
			);
	}
}
