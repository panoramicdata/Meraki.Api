namespace Meraki.Api.Interfaces.Products.Sm;

public interface ISmUsersDeviceProfiles
{
	/// <summary>
	/// Get the profiles associated with a user
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="userId">The user id</param>
	[Get("/networks/{networkId}/sm/users/{userId}/deviceProfiles")]
	Task<List<DeviceProfile>> GetNetworkSmUserDeviceProfilesAsync(
		string networkId,
		string userId,
		CancellationToken cancellationToken = default
		);
}
