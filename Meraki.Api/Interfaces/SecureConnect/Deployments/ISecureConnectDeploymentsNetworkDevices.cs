namespace Meraki.Api.Interfaces.SecureConnect.Deployments;

public interface ISecureConnectDeploymentsNetworkDevices
{
	/// <summary>
	/// List the network devices.
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">Organization ID associated with this resource.</param>
	/// <param name="cancellationToken">Cancellation token</param>
	[ApiOperationId("getAllNetworkDevices")]
	[Get("/organizations/{organizationId}/networkDevices")]
	Task<List<SecureConnectNetworkDevice>> GetAllNetworkDevicesAsync(
		string organizationId,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Get a network device.
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">Organization ID associated with this resource.</param>
	/// <param name="originId">The origin ID of the network device. minimum = 1</param>"
	/// <param name="cancellationToken">Cancellation token</param>
	[ApiOperationId("getNetworkDevice")]
	[Get("/organizations/{organizationId}/networkDevices/{originId}")]
	Task<SecureConnectNetworkDevice> GetNetworkDeviceAsync(
		string organizationId,
		int originId,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Create a network device.
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">Organization ID associated with this resource.</param>
	/// <param name="secureConnectNetworkDeviceCreateRequest">The device creation request</param>
	/// <param name="cancellationToken">Cancellation token</param>
	[ApiOperationId("createNetworkDevice")]
	[Get("/organizations/{organizationId}/networkDevices")]
	Task<SecureConnectNetworkDevice> CreateNetworkDeviceAsync(
		string organizationId,
		[Body] SecureConnectNetworkDeviceCreateRequest secureConnectNetworkDeviceCreateRequest,
		CancellationToken cancellationToken = default);
}
