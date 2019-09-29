using Meraki.Api.Data;
using Refit;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Meraki.Api.Interfaces
{
	/// <summary>
	/// ApiUsages interface
	/// </summary>
	public interface IApiUsages
	{
		/// <summary>
		/// GetAsync
		/// </summary>
		/// <param name="organizationId">The organization id</param>
		/// <param name="t0">The beginning of the timespan for the data. The maximum lookback period is 31 days from today.</param>
		/// <param name="t1">The end of the timespan for the data. t1 can be a maximum of 31 days after t0.</param>
		/// <param name="timeSpan">The timespan for which the information will be fetched. If specifying timespan, do not specify parameters t0 and t1. The value must be in seconds and be less than or equal to 31 days. The default is 31 days.</param>
		/// <param name="perPage">The timespan for which the information will be fetched. If specifying timespan, do not specify parameters t0 and t1. The value must be in seconds and be less than or equal to 31 days. The default is 31 days.</param>
		/// <param name="startingAfter">A token used by the server to indicate the start of the page. Often this is a timestamp or an ID but it is not limited to those. This parameter should not be defined by client applications. The link for the first, last, prev, or next page in the HTTP Link header should define it.</param>
		/// <param name="endingBefore">A token used by the server to indicate the end of the page. Often this is a timestamp or an ID but it is not limited to those. This parameter should not be defined by client applications. The link for the first, last, prev, or next page in the HTTP Link header should define it.</param>
		/// <param name="adminId">Filter the results by the ID of the admin who made the API requests</param>
		/// <param name="path">Filter the results by the path of the API requests</param>
		/// <param name="method">Filter the results by the method of the API requests (must be 'GET', 'PUT', 'POST' or 'DELETE')</param>
		/// <param name="responseCode">Filter the results by the response code of the API requests</param>
		[Get("/organizations/{organizationId}/apiRequests")]
		Task<List<ApiUsage>> GetPageAsync(
			long organizationId,
			[AliasAs("t0")] DateTimeOffset? t0 = default,
			[AliasAs("t1")] DateTimeOffset? t1 = default,
			[AliasAs("timeSpan")] int? timeSpan = default,
			[AliasAs("perPage")] int? perPage = default,
			[AliasAs("startingAfter")] string startingAfter = default!,
			[AliasAs("endingBefore")] string endingBefore = default!,
			[AliasAs("adminId")] DateTimeOffset adminId = default,
			[AliasAs("path")] DateTimeOffset path = default,
			[AliasAs("method")] string Method = default!,
			[AliasAs("responseCode")] int? ResponseCode = default,
			CancellationToken cancellationToken = default);
	}
}
