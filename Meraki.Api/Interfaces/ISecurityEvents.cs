using Refit;
using System.Threading.Tasks;

namespace Meraki.Api.Interfaces
{
	/// <summary>
	/// Represents a collection of functions to interact with the API endpoints
	/// </summary>
	public interface ISecurityEvents
	{
		/// <summary>
		/// getNetworkClientSecurityEvents
		/// </summary>
		/// <remarks>
		/// List the security events for a client. Clients can be identified by a client key or either the MAC or IP depending on whether the network uses Track-by-IP.
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <param name="clientId"></param>
		/// <param name="t0">The beginning of the timespan for the data. The maximum lookback period is 791 days from today. (optional)</param>
		/// <param name="t1">The end of the timespan for the data. t1 can be a maximum of 791 days after t0. (optional)</param>
		/// <param name="timespan">The timespan for which the information will be fetched. If specifying timespan, do not specify parameters t0 and t1. The value must be in seconds and be less than or equal to 791 days. The default is 31 days. (optional)</param>
		/// <param name="perPage">The number of entries per page returned. Acceptable range is 3 - 1000. Default is 100. (optional)</param>
		/// <param name="startingAfter">A token used by the server to indicate the start of the page. Often this is a timestamp or an ID but it is not limited to those. This parameter should not be defined by client applications. The link for the first, last, prev, or next page in the HTTP Link header should define it. (optional)</param>
		/// <param name="endingBefore">A token used by the server to indicate the end of the page. Often this is a timestamp or an ID but it is not limited to those. This parameter should not be defined by client applications. The link for the first, last, prev, or next page in the HTTP Link header should define it. (optional)</param>
		/// <returns>Task of Object</returns>
		[Get("/networks/{networkId}/clients/{clientId}/securityEvents")]
		Task<object> GetNetworkClientSecurityEvents(
			[AliasAs("networkId")]string networkId,
			[AliasAs("clientId")]string clientId,
			[AliasAs("t0")]string t0 = null!,
			[AliasAs("t1")]string t1 = null!,
			[AliasAs("timespan")]double? timespan = null,
			[AliasAs("perPage")]int? perPage = null,
			[AliasAs("startingAfter")]string startingAfter = null!,
			[AliasAs("endingBefore")]string endingBefore = null!
			);

		/// <summary>
		/// getNetworkSecurityEvents
		/// </summary>
		/// <remarks>
		/// List the security events for a network
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <param name="t0">The beginning of the timespan for the data. The maximum lookback period is 365 days from today. (optional)</param>
		/// <param name="t1">The end of the timespan for the data. t1 can be a maximum of 365 days after t0. (optional)</param>
		/// <param name="timespan">The timespan for which the information will be fetched. If specifying timespan, do not specify parameters t0 and t1. The value must be in seconds and be less than or equal to 365 days. The default is 31 days. (optional)</param>
		/// <param name="perPage">The number of entries per page returned. Acceptable range is 3 - 1000. Default is 100. (optional)</param>
		/// <param name="startingAfter">A token used by the server to indicate the start of the page. Often this is a timestamp or an ID but it is not limited to those. This parameter should not be defined by client applications. The link for the first, last, prev, or next page in the HTTP Link header should define it. (optional)</param>
		/// <param name="endingBefore">A token used by the server to indicate the end of the page. Often this is a timestamp or an ID but it is not limited to those. This parameter should not be defined by client applications. The link for the first, last, prev, or next page in the HTTP Link header should define it. (optional)</param>
		/// <returns>Task of Object</returns>
		[Get("/networks/{networkId}/securityEvents")]
		Task<object> GetNetworkSecurityEvents(
			[AliasAs("networkId")]string networkId,
			[AliasAs("t0")]string t0 = null!,
			[AliasAs("t1")]string t1 = null!,
			[AliasAs("timespan")]double? timespan = null,
			[AliasAs("perPage")]int? perPage = null,
			[AliasAs("startingAfter")]string startingAfter = null!,
			[AliasAs("endingBefore")]string endingBefore = null!
			);

		/// <summary>
		/// getOrganizationSecurityEvents
		/// </summary>
		/// <remarks>
		/// List the security events for an organization
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="organizationId"></param>
		/// <param name="t0">The beginning of the timespan for the data. The maximum lookback period is 365 days from today. (optional)</param>
		/// <param name="t1">The end of the timespan for the data. t1 can be a maximum of 365 days after t0. (optional)</param>
		/// <param name="timespan">The timespan for which the information will be fetched. If specifying timespan, do not specify parameters t0 and t1. The value must be in seconds and be less than or equal to 365 days. The default is 31 days. (optional)</param>
		/// <param name="perPage">The number of entries per page returned. Acceptable range is 3 - 1000. Default is 100. (optional)</param>
		/// <param name="startingAfter">A token used by the server to indicate the start of the page. Often this is a timestamp or an ID but it is not limited to those. This parameter should not be defined by client applications. The link for the first, last, prev, or next page in the HTTP Link header should define it. (optional)</param>
		/// <param name="endingBefore">A token used by the server to indicate the end of the page. Often this is a timestamp or an ID but it is not limited to those. This parameter should not be defined by client applications. The link for the first, last, prev, or next page in the HTTP Link header should define it. (optional)</param>
		/// <returns>Task of Object</returns>
		[Get("/organizations/{organizationId}/securityEvents")]
		Task<object> GetOrganizationSecurityEvents(
			[AliasAs("organizationId")]string organizationId,
			[AliasAs("t0")]string t0 = null!,
			[AliasAs("t1")]string t1 = null!,
			[AliasAs("timespan")]double? timespan = null,
			[AliasAs("perPage")]int? perPage = null,
			[AliasAs("startingAfter")]string startingAfter = null!,
			[AliasAs("endingBefore")]string endingBefore = null!
			);
	}
}
