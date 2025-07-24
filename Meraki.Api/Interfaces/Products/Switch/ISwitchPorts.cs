namespace Meraki.Api.Interfaces.Products.Switch;

/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>
public interface ISwitchPorts
{
	/// <summary>
	/// List the switch ports for a switch
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="serial">The serial number</param>
	/// <param name="cancellationToken"></param>
	[ApiOperationId("getDeviceSwitchPorts")]
	[Get("/devices/{serial}/switch/ports")]
	Task<List<SwitchPort>> GetDeviceSwitchPortsAsync(
		string serial,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Return a switch port
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="serial">The serial number</param>
	/// <param name="portId">The port id</param>
	/// <param name="cancellationToken"></param>
	[ApiOperationId("getDeviceSwitchPort")]
	[Get("/devices/{serial}/switch/ports/{portId}")]
	Task<SwitchPort> GetDeviceSwitchPortAsync(
		string serial,
		string portId,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Update a switch port
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="serial">The serial number</param>
	/// <param name="portId">The port id</param>
	/// <param name="deviceSwitchPort">The new configuration</param>
	/// <param name="cancellationToken"></param>
	[ApiOperationId("updateDeviceSwitchPort")]
	[Put("/devices/{serial}/switch/ports/{portId}")]
	Task<SwitchPort> UpdateDeviceSwitchPortAsync(
		string serial,
		string portId,
		[Body] SwitchPort deviceSwitchPort,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Update a switch port
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="serial">The serial number</param>
	/// <param name="portId">The port id</param>
	/// <param name="switchPortUpdateRequest">The switch port update request</param>
	/// <param name="cancellationToken"></param>
	[ApiOperationId("updateDeviceSwitchPort")]
	[Put("/devices/{serial}/switch/ports/{portId}")]
	Task<SwitchPort> UpdateDeviceSwitchPortAsync(
		string serial,
		string portId,
		[Body] SwitchPortUpdateRequest switchPortUpdateRequest,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Update a switch port
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="serial">The serial number</param>
	/// <param name="portId">The port id</param>
	/// <param name="switchPortUpdateRequest">The switch port update request</param>
	/// <param name="cancellationToken"></param>
	[ApiOperationId("updateDeviceSwitchPort")]
	[Put("/devices/{serial}/switch/ports/{portId}")]
	internal Task<SwitchPort> InternalUpdateDeviceSwitchPortSetPortScheduleIdAsync(
		string serial,
		string portId,
		[Body] SwitchPortUpdatePortScheduleIdRequest switchPortUpdateRequest,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Return the status for all the ports of a switch
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="serial">The serial number</param>
	/// <param name="t0">The beginning of the timespan for the data. The maximum lookback period is 31 days from today. (optional)</param>
	/// <param name="timespan">The timespan for which the information will be fetched. If specifying timespan, do not specify parameter t0. The value must be in seconds and be less than or equal to 31 days. The default is 1 day. (optional)</param>
	/// <param name="cancellationToken"></param>
	[Get("/devices/{serial}/switch/ports/statuses")]
	Task<List<SwitchPortStatus>> GetDeviceSwitchPortsStatusesAsync(
		string serial,
		string t0 = null!,
		double? timespan = null,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Return the packet counters for all the ports of a switch
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="serial">The serial number</param>
	/// <param name="t0">The beginning of the timespan for the data. The maximum lookback period is 1 day from today. (optional)</param>
	/// <param name="timespan">The timespan for which the information will be fetched. If specifying timespan, do not specify parameter t0. The value must be in seconds and be less than or equal to 1 day. The default is 1 day. (optional)</param>
	/// <param name="cancellationToken"></param>
	[Get("/devices/{serial}/switch/ports/statuses/packets")]
	Task<List<PacketsList>> GetDeviceSwitchPortsStatusesPacketsAsync(
		string serial,
		string t0 = null!,
		double? timespan = null,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Cycle a set of switch ports
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="serial">The serial number</param>
	/// <param name="deviceSwitchPortsCycleRequest">Body for cycling switch ports</param>
	/// <param name="cancellationToken"></param>
	[Post("/devices/{serial}/switch/ports/cycle")]
	Task<DeviceSwitchPortsCycleRequest> CycleDeviceSwitchPortsAsync(
		string serial,
		[Body] DeviceSwitchPortsCycleRequest deviceSwitchPortsCycleRequest,
		CancellationToken cancellationToken = default);
	/// <summary>
	/// Update a port mirror
	/// </summary>
	/// <param name="serial">The serial number</param>
	/// <param name="deviceSwitchPortsMirrorUpdateRequest">Body for updating switch ports mirror</param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[Put("/devices/{serial}/switch/ports/mirror")]
	Task<DeviceSwitchPortsMirrorUpdateResponse> UpdateDeviceSwitchPortsMirrorAsync(
		string serial,
		[Body] DeviceSwitchPortsMirrorUpdateRequest deviceSwitchPortsMirrorUpdateRequest,
		CancellationToken cancellationToken = default);
}
