namespace Meraki.Api.Interfaces.Products.Sm;

/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>
public interface ISmUserAccessDevices
{
	/// <summary>
	/// List User Access Devices and its Trusted Access Connections
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="perPage">The number of entries per page returned. Acceptable range is 3 - 1000. Default is 100.</param>
	/// <param name="startingAfter">A token used by the server to indicate the start of the page. Often this is a timestamp or an ID but it is not limited to those. This parameter should not be defined by client applications. The link for the first, last, prev, or next page in the HTTP Link header should define it.</param>
	/// <param name="endingBefore">A token used by the server to indicate the end of the page. Often this is a timestamp or an ID but it is not limited to those. This parameter should not be defined by client applications. The link for the first, last, prev, or next page in the HTTP Link header should define it.</param>
	[Get("/networks/{networkId}/sm/userAccessDevices")]
	Task<List<UserAccessDevices>> GetNetworkSmUserAccessDevicesAsync(
		[AliasAs("networkId")] string networkId,
		[AliasAs("perPage")] int? perPage = 1000,
		[AliasAs("startingAfter")] string startingAfter = null!,
		[AliasAs("endingBefore")] string endingBefore = null!,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Delete a User Access Device
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="userAccessDeviceId">The user access device id</param>
	[Delete("/networks/{networkId}/sm/userAccessDevices/{userAccessDeviceId}")]
	Task DeleteNetworkSmUserAccessDeviceAsync(
		[AliasAs("networkId")] string networkId,
		[AliasAs("userAccessDeviceId")] string userAccessDeviceId,
		CancellationToken cancellationToken = default
		);
}
