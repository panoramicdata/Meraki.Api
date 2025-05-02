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
	Task<NetworkFirmwareUpgradeStagedEventsResponse> GetNetworkFirmwareUpgradesStagedEventsAsync(
		string networkId,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Create a Staged Upgrade Event for a Network
	/// </summary>
	/// <param name="networkId">The network id</param>
	/// <param name="createNetworkFirmwareUpgradesStagedEvents"></param>
	/// <param name="cancellationToken">The Cancellation Token</param>
	/// <returns></returns>
	[Post("/networks/{networkId}/firmwareUpgrades/staged/events")]
	Task<NetworkFirmwareUpgradeStagedEventsResponse> CreateNetworkFirmwareUpgradesStagedEventsAsync(
		string networkId,
		[Body] NetworkFirmwareUpgradeStagedEventsCreateRequest createNetworkFirmwareUpgradesStagedEvents,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Update the Staged Upgrade Event for a network
	/// </summary>
	/// <param name="networkId">The network id</param>
	/// <param name="createNetworkFirmwareUpgradesStagedEvents"></param>
	/// <param name="cancellationToken">The Cancellation Token</param>
	/// <returns></returns>
	[Put("/networks/{networkId}/firmwareUpgrades/staged/events")]
	Task<NetworkFirmwareUpgradeStagedEventsResponse> UpdateNetworkFirmwareUpgradesStagedEventsAsync(
		string networkId,
		[Body] NetworkFirmwareUpgradeStagedEventsUpdateRequest createNetworkFirmwareUpgradesStagedEvents,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Postpone by 1 week all pending staged upgrade stages for a network
	/// </summary>
	/// <param name="networkId">The network id</param>
	/// <param name="cancellationToken">The Cancellation Token</param>
	/// <returns></returns>
	[Post("/networks/{networkId}/firmwareUpgrades/staged/events/defer")]
	Task<NetworkFirmwareUpgradeStagedEventsDeferResponse> DeferNetworkFirmwareUpgradesStagedEventsAsync(
		string networkId,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Rollback a Staged Upgrade Event for a Network
	/// </summary>
	/// <param name="networkId">The network id</param>
	/// <param name="createNetworkFirmwareUpgradesStagedEvents"></param>
	/// <param name="cancellationToken">The Cancellation Token</param>
	/// <returns></returns>
	[Post("/networks/{networkId}/firmwareUpgrades/staged/events/rollbacks")]
	Task<NetworkFirmwareUpgradeStagedEventsRollbacksResponse> RollbacksNetworkFirmwareUpgradesStagedEventsAsync(
		string networkId,
		[Body] NetworkFirmwareUpgradeStagedEventsRollbacksRequest createNetworkFirmwareUpgradesStagedEvents,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// List of Staged Upgrade Groups in a Network
	/// </summary>
	/// <param name="networkId">The network id</param>
	/// <param name="cancellationToken">The Cancellation Token</param>
	/// <returns></returns>
	[Get("/networks/{networkId}/firmwareUpgrades/staged/groups")]
	Task<List<NetworkFirmwareUpgradesStagedGroup>> GetNetworkFirmwareUpgradesStagedGroupsAsync(
		string networkId,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Get a Staged Upgrade Group from a Network
	/// </summary>
	/// <param name="networkId">The network id</param>
	/// <param name="groupId">Group ID</param>
	/// <param name="cancellationToken">The Cancellation Token</param>
	/// <returns></returns>
	[Get("/networks/{networkId}/firmwareUpgrades/staged/groups/{groupId}")]
	Task<NetworkFirmwareUpgradesStagedGroup> GetNetworkFirmwareUpgradesStagedGroupsAsync(
		string networkId,
		string groupId,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Create a Staged Upgrade Group for a Network
	/// </summary>
	/// <param name="networkId">The network id</param>
	/// <param name="createNetworkFirmwareUpgradesStagedGroups"></param>
	/// <param name="cancellationToken">The Cancellation Token</param>
	/// <returns></returns>
	[Post("/networks/{networkId}/firmwareUpgrades/staged/groups")]
	Task<NetworkFirmwareUpgradesStagedGroup> CreateNetworkFirmwareUpgradesStagedGroupsAsync(
		string networkId,
		[Body] NetworkFirmwareUpgradesStagedGroupCreateRequest createNetworkFirmwareUpgradesStagedGroups,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Update a Staged Upgrade Group for a network
	/// </summary>
	/// <param name="networkId">The network id</param>
	/// <param name="groupId"></param>
	/// <param name="createNetworkFirmwareUpgradesStagedGroups"></param>
	/// <param name="cancellationToken">The Cancellation Token</param>
	/// <returns></returns>
	[Put("/networks/{networkId}/firmwareUpgrades/staged/groups/{groupId}")]
	Task<NetworkFirmwareUpgradesStagedGroupUpdateResponse> UpdateNetworkFirmwareUpgradesStagedGroupsAsync(
		string networkId,
		string groupId,
		[Body] NetworkFirmwareUpgradesStagedGroupUpdateRequest createNetworkFirmwareUpgradesStagedGroups,
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
