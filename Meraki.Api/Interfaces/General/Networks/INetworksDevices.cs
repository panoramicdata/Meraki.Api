namespace Meraki.Api.Interfaces.General.Networks;

public interface INetworksDevices
{
	/// <summary>
	/// List the devices in a network
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	[ApiOperationId("getNetworkDevices")]
	[Get("/networks/{networkId}/devices")]
	Task<List<Device>> GetNetworkDevicesAsync(
		[AliasAs("networkId")] string networkId,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Claim devices into a network.
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="claimNetworkDevices">Body for claiming a network device</param>
	[ApiOperationId("claimNetworkDevices")]
	[Post("/networks/{networkId}/devices/claim")]
	Task ClaimNetworkDevicesAsync(
		[AliasAs("networkId")] string networkId,
		[Body] DeviceClaimRequest claimNetworkDevices,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Remove a single device
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	[ApiOperationId("removeNetworkDevices")]
	[Post("/networks/{networkId}/devices/remove")]
	Task RemoveNetworkDevicesAsync(
		[AliasAs("networkId")] string networkId,
		[Body] DeviceRemovalRequest deviceRemovalRequest,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Claim a vMX into a network
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="vmxNetworkDevicesClaim">Body of request</param>
	[ApiOperationId("vmxNetworkDevicesClaim")]
	[Post("/networks/{networkId}/devices/claim/vmx")]
	Task<Device> VmxNetworkDevicesClaimAsync(
		[AliasAs("networkId")] string networkId,
		[Body] VmxNetworkDevicesClaim vmxNetworkDevicesClaim,
		CancellationToken cancellationToken = default);
}
