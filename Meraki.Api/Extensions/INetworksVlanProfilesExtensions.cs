namespace Meraki.Api.Extensions;

/// <summary>
/// Extension methods for INetworks Vlan Profiles
/// </summary>

public static class INetworksVlanProfilesExtensions
{
	/// <summary>
	/// Get all the assigned VLAN Profiles for devices in a network
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="vlanProfiles"></param>
	/// <param name="networkId">The network id</param>
	/// <param name="serials">Optional parameter to filter devices by serials. All devices returned belong to serial numbers that are an exact match.</param>
	/// <param name="productTypes">Optional parameter to filter devices by product types.</param>
	/// <param name="stackIds">Optional parameter to filter devices by Switch Stack ids.</param>
	/// <param name="cancellationToken"></param>
	/// <remarks>
	/// Fetches every page before returning and is <b>all-or-nothing</b>: if any page fails, the
	/// exception propagates and the pages already fetched are discarded. An exception therefore means
	/// "no data was returned", never "here is what was fetched so far". In particular, a 404 from a
	/// genuinely empty collection and a 404 on the last of many pages reach the caller identically, so
	/// do not treat an exception as an empty result; retry or fail instead. See
	/// <see href="https://github.com/panoramicdata/Meraki.Api/issues/355">issue 355</see>.
	/// </remarks>
	public static Task<List<VlanProfileDeviceAssignment>> GetNetworkVlanProfilesAssignmentsByDeviceAllAsync(
		this INetworksVlanProfiles vlanProfiles,
		string networkId,
		List<string>? serials = null,
		List<string>? productTypes = null,
		List<string>? stackIds = null,
		CancellationToken cancellationToken = default)
		=> MerakiClient.GetAllAsync(
				(startingAfter, endingBefore, cancellationToken)
				=> vlanProfiles.GetNetworkVlanProfilesAssignmentsByDeviceApiResponseAsync(
						networkId,
						startingAfter,
						endingBefore,
						serials,
						productTypes,
						stackIds,
						cancellationToken
					),
					cancellationToken
			);
}
