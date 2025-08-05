namespace Meraki.Api.Interfaces.General.Networks;

public interface INetworksDevices
{
	/// <summary>
	/// List the devices in a network
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="cancellationToken"></param>
	[ApiOperationId("getNetworkDevices")]
	[Get("/networks/{networkId}/devices")]
	Task<List<Device>> GetNetworkDevicesAsync(
		string networkId,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Claim devices into a network.
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="addAtomically">Whether to claim devices atomically. If true, all devices will be claimed or none will be claimed. Default is true.</param>
	/// <param name="claimNetworkDevices">Body for claiming a network device</param>
	/// <param name="cancellationToken"></param>
	[ApiOperationId("claimNetworkDevices")]
	[Post("/networks/{networkId}/devices/claim")]
	Task ClaimNetworkDevicesAsync(
		string networkId,
		bool addAtomically,
		[Body] DeviceClaimRequest claimNetworkDevices,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Remove a single device
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="deviceRemovalRequest"></param>
	/// <param name="cancellationToken"></param>
	[ApiOperationId("removeNetworkDevices")]
	[Post("/networks/{networkId}/devices/remove")]
	Task RemoveNetworkDevicesAsync(
		string networkId,
		[Body] DeviceRemovalRequest deviceRemovalRequest,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Claim a vMX into a network
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="vmxNetworkDevicesClaim">Body of request</param>
	/// <param name="cancellationToken"></param>
	[ApiOperationId("vmxNetworkDevicesClaim")]
	[Post("/networks/{networkId}/devices/claim/vmx")]
	Task<Device> VmxNetworkDevicesClaimAsync(
		string networkId,
		[Body] VmxNetworkDevicesClaim vmxNetworkDevicesClaim,
		CancellationToken cancellationToken = default);
}
