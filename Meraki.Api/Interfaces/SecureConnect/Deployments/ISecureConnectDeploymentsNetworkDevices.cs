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
	[Post("/organizations/{organizationId}/networkDevices")]
	Task<SecureConnectNetworkDevice> CreateNetworkDeviceAsync(
		string organizationId,
		[Body] SecureConnectNetworkDeviceCreateRequest secureConnectNetworkDeviceCreateRequest,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Update a network device.
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="originId">The origin ID of the network device. minimum = 1</param>"
	/// <param name="organizationId">Organization ID associated with this resource.</param>
	/// <param name="secureConnectNetworkDeviceUpdateRequest">The device creation request</param>
	/// <param name="cancellationToken">Cancellation token</param>
	[ApiOperationId("updateNetworkDevice")]
	[Patch("/organizations/{organizationId}/networkDevices/{originId}")]
	Task<SecureConnectNetworkDevice> UpdateNetworkDeviceAsync(
		string organizationId,
		int originId,
		[Body] SecureConnectNetworkDeviceUpdateRequest secureConnectNetworkDeviceUpdateRequest,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Remove a network device.
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="originId">The origin ID of the network device. minimum = 1</param>"
	/// <param name="organizationId">Organization ID associated with this resource.</param>
	/// <param name="cancellationToken">Cancellation token</param>
	[ApiOperationId("deleteNetworkDevice")]
	[Delete("/organizations/{organizationId}/networkDevices/{originId}")]
	Task DeleteNetworkDeviceAsync(
		string organizationId,
		int originId,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// List the Umbrella policies associated with a network device. If no filters are supplied, Umbrella returns the DNS policies.
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">Organization ID associated with this resource.</param>
	/// <param name="originId">The origin ID of the network device. minimum = 1</param>"
	/// <param name="cancellationToken">Cancellation token</param>
	[ApiOperationId("listNetworkDevicePolicies")]
	[Get("/organizations/{organizationId}/networkDevices/{originId}/policies")]
	Task<List<SecureConnectDevicePolicy>> ListNetworkDevicePoliciesAsync(
		string organizationId,
		int originId,
		CancellationToken cancellationToken = default);
}
