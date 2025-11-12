namespace Meraki.Api.Interfaces.General.Organizations;

/// <summary>
/// I Organizations Network Devices
/// </summary>
public interface IOrganizationsNetworkDevices
{
	/// <summary>
	/// List the Umbrella policies associated with a network deviceIf no filters are supplied, Umbrella returns the DNS policies.
	/// </summary>
	/// <param name="organizationId">Organization ID</param>
	/// <param name="originId">Origin ID</param>
	/// <param name="cancellationToken">Cancellation Token</param>
	/// <returns></returns>
	[Get("/organizations/{organizationId}/networkDevices/{originId}/policies")]
	Task<List<NetworkDevicePolicy>> ListNetworkDevicePoliciesAsync(
	string organizationId,
	string originId,
	CancellationToken cancellationToken = default
);
}
