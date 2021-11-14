namespace Meraki.Api.Interfaces
{
	/// <summary>
	/// Represents a collection of functions to interact with the API endpoints
	/// </summary>
	public interface ISms
	{
		/// <summary>
		/// List the owners in an SM network with various specified fields and filters
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="ids">Filter users by id(s). Multiple ids can be passed in as comma separated values. (optional)</param>
		/// <param name="usernames">Filter users by username(s). Multiple usernames can be passed in as comma separated values. (optional)</param>
		/// <param name="emails">Filter users by email(s). Multiple emails can be passed in as comma separated values. (optional)</param>
		/// <param name="scope">Specifiy a scope (one of all, none, withAny, withAll, withoutAny, withoutAll) and a set of tags as comma separated values. (optional)</param>
		[Get("/networks/{networkId}/sm/users")]
		Task<List<SmNetworkUsers>> GetNetworkSmUsersAsync(
			[AliasAs("networkId")] string networkId,
			[AliasAs("ids")] string ids = null!,
			[AliasAs("usernames")] string usernames = null!,
			[AliasAs("emails")] string emails = null!,
			[AliasAs("scope")] string scope = null!,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// List the saved SSID names on a device
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="deviceId">The device id</param>
		[Get("/networks/{networkId}/sm/devices/{deviceId}/wlanLists")]
		Task<List<WlanList>> GetNetworkSmWlanListsAsync(
			[AliasAs("networkId")] string networkId,
			[AliasAs("deviceId")] string deviceId,
			CancellationToken cancellationToken = default
			);





		/// <summary>
		/// Modify the fields of a device
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="updateNetworkSmDeviceFields">Body for modifying a device</param>
		[Put("/networks/{networkId}/sm/devices/fields")]
		Task<SmDeviceFieldsUpdateRequest> UpdateNetworkSmDeviceFieldsAsync(
			[AliasAs("networkId")] string networkId,
			[Body] SmDeviceFieldsUpdateRequest updateNetworkSmDeviceFields,
			CancellationToken cancellationToken = default
			);
	}
}
