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
	public interface IUserAccessDevices
	{
		/// <summary>
		/// getNetworkSmUserAccessDevices
		/// </summary>
		/// <remarks>
		/// List User Access Devices and its Trusted Access Connections
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <param name="perPage">The number of entries per page returned. Acceptable range is 3 - 1000. Default is 100.</param>
		/// <param name="startingAfter">A token used by the server to indicate the start of the page. Often this is a timestamp or an ID but it is not limited to those. This parameter should not be defined by client applications. The link for the first, last, prev, or next page in the HTTP Link header should define it.</param>
		/// <param name="endingBefore">A token used by the server to indicate the end of the page. Often this is a timestamp or an ID but it is not limited to those. This parameter should not be defined by client applications. The link for the first, last, prev, or next page in the HTTP Link header should define it.</param>
		/// <returns>Task of Object</returns>
		[Get("/networks/{networkId}/sm/userAccessDevices")]
		Task<List<UserAccessDevices>> GetNetworkSmUserAccessDevices(
			[AliasAs("networkId")] string networkId,
			[AliasAs("perPage")] int? perPage = null,
			[AliasAs("startingAfter")] string startingAfter = null!,
			[AliasAs("endingBefore")] string endingBefore = null!
			);

		/// <summary>
		/// deleteNetworkSmUserAccessDevice
		/// </summary>
		/// <remarks>
		/// Delete a User Access Device
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <param name="userAccessDeviceId"></param>
		/// <returns>Task of void</returns>
		[Delete("/networks/{networkId}/sm/userAccessDevices/{userAccessDeviceId}")]
		Task DeleteNetworkSmUserAccessDevice(
			[AliasAs("networkId")] string networkId,
			[AliasAs("userAccessDeviceId")] string userAccessDeviceId
			);
	}
}
