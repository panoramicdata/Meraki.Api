namespace Meraki.Api.Interfaces.Switch;
/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>
public interface ISwitchPortSchedules
{
	/// <summary>
	/// List switch port schedules
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	[ApiOperationId("getNetworkSwitchPortSchedules")]
	[Get("/networks/{networkId}/switch/portSchedules")]
	Task<List<SwitchPortSchedule>> GetNetworkSwitchPortSchedulesAsync(
		[AliasAs("networkId")] string networkId,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Add a switch port schedule
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="createNetworkSwitchPortSchedule"></param>
	[ApiOperationId("createNetworkSwitchPortSchedules")]
	[Post("/networks/{networkId}/switch/portSchedules")]
	Task<SwitchPortSchedule> CreateNetworkSwitchPortScheduleAsync(
		[AliasAs("networkId")] string networkId,
		[Body] SwitchPortScheduleCreationRequest createNetworkSwitchPortSchedule,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Update a switch port schedule
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="portScheduleId">The port schedule id</param>
	/// <param name="updateNetworkSwitchPortSchedule"></param>
	[ApiOperationId("updateNetworkSwitchPortSchedules")]
	[Put("/networks/{networkId}/switch/portSchedules/{portScheduleId}")]
	Task<SwitchPortSchedule> UpdateNetworkSwitchPortScheduleAsync(
		[AliasAs("networkId")] string networkId,
		[AliasAs("portScheduleId")] string portScheduleId,
		[Body] SwitchPortScheduleCreationRequest updateNetworkSwitchPortSchedule,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Delete a switch port schedule
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="portScheduleId">The port schedule id</param>
	[ApiOperationId("deleteNetworkSwitchPortSchedules")]
	[Delete("/networks/{networkId}/switch/portSchedules/{portScheduleId}")]
	Task DeleteNetworkSwitchPortScheduleAsync(
		[AliasAs("networkId")] string networkId,
		[AliasAs("portScheduleId")] string portScheduleId,
		CancellationToken cancellationToken = default
		);
}
