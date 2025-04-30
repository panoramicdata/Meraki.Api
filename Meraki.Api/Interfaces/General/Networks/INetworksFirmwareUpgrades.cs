namespace Meraki.Api.Interfaces.General.Networks;

public interface INetworksFirmwareUpgrades
{
	/// <summary>
	/// Get firmware upgrade information for a network
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="cancellationToken">The Cancellation Token</param>
	[ApiOperationId("getNetworkFirmwareUpgrades")]
	[Get("/networks/{networkId}/firmwareUpgrades")]
	Task<NetworkFirmwareUpgrade> GetNetworkFirmwareUpgradesAsync(
		string networkId,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Update firmware upgrade information for a network
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="updateNetworkFirmwareUpgrades">Body for updating network firmware upgrades</param>
	/// <param name="cancellationToken">The Cancellation Token</param>
	[ApiOperationId("updateNetworkFirmwareUpgrades")]
	[Put("/networks/{networkId}/firmwareUpgrades")]
	Task<NetworkFirmwareUpgrade> UpdateNetworkFirmwareUpgradesAsync(
		string networkId,
		[Body] NetworkFirmwareUpgradeUpdateRequest updateNetworkFirmwareUpgrades,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Get the staged Upgrade events for a Network
	/// </summary>
	/// /// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="cancellationToken">The Cancellation Token</param>
	/// <returns></returns>
	[Get("/networks/{networkId}/firmwareUpgrades/staged/events")]
	Task<NetworkFirmwareUpgradeStagedEvents> GetNetworkFirmwareUpgradesStagedEventsAsync(
		string networkId,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Rollback a Firmware Upgrade For A Network
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="createNetworkFirmwareUpgradesRollback">Body for creating network firmware upgrade rollbacks</param>
	/// <param name="cancellationToken">The Cancellation Token</param>
	[ApiOperationId("createNetworkFirmwareUpgradesRollback")]
	[Post("/networks/{networkId}/firmwareUpgrades/rollbacks")]
	Task<NetworkFirmwareUpgrade> CreateNetworkFirmwareUpgradesRollbackAsync(
		string networkId,
		[Body] FirmwareUpgradeRollbackRequest createNetworkFirmwareUpgradesRollback,
		CancellationToken cancellationToken = default
		);
}
