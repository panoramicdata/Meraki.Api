namespace Meraki.Api.Extensions;

public static class INetworksVlanProfilesExtensions
{
	/// <summary>
	/// Get all the assigned VLAN Profiles for devices in a network
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="serials">Optional parameter to filter devices by serials. All devices returned belong to serial numbers that are an exact match.</param>
	/// <param name="productTypes">Optional parameter to filter devices by product types.</param>
	/// <param name="stackIds">Optional parameter to filter devices by Switch Stack ids.</param>
	public static Task<List<VlanProfileDeviceAssignment>> GetNetworkVlanProfilesAssignmentsByDeviceAllAsync(
		this INetworksVlanProfiles vlanProfiles,
		string networkId,
		List<string>? serials = null,
		List<string>? productTypes = null,
		List<string>? stackIds = null,
		CancellationToken cancellationToken = default)
		=> MerakiClient.GetAllAsync(
				(startingAfter, cancellationToken)
				=> vlanProfiles.GetNetworkVlanProfilesAssignmentsByDeviceApiResponseAsync(
						networkId,
						startingAfter,
						serials,
						productTypes,
						stackIds,
						cancellationToken
					),
					cancellationToken
			);
}
