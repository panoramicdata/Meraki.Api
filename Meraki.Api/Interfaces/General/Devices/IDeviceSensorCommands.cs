namespace Meraki.Api.Interfaces.General.Devices;
public interface IDeviceSensorCommands
{
	/// <summary>
	/// Returns a historical log of all commands
	/// </summary>
	/// <param name="serial">Serial</param>
	/// <param name="operations">Optional parameter to filter commands by operation</param>
	/// <param name="perPage">The number of entries per page returned. Acceptable range is 3 - 1000. Default is 10.</param>
	/// <param name="startingAfter">A token used by the server to indicate the start of the page. Often this is a timestamp or an ID but it is not limited to those. This parameter should not be defined by client applications. The link for the first, last, prev, or next page in the HTTP Link header should define it.</param>
	/// <param name="endingBefore">A token used by the server to indicate the end of the page. Often this is a timestamp or an ID but it is not limited to those. This parameter should not be defined by client applications. The link for the first, last, prev, or next page in the HTTP Link header should define it.</param>
	/// <param name="t0">The beginning of the timespan for the data. The maximum lookback period is 30 days from today.</param>
	/// <param name="t1">The end of the timespan for the data. t1 can be a maximum of 30 days after t0.</param>
	/// <param name="timespan">The timespan for which the information will be fetched. If specifying timespan, do not specify parameters t0 and t1. The value must be in seconds and be less than or equal to 30 days. The default is 1 day.</param>
	/// <param name="cancellationToken"></param>
	/// <returns>A list of <see cref="SensorCommand"></returns>
	[ApiOperationId("getDeviceSensorCommands")]
	[Get("/devices/{serial}/sensor/commands")]
	Task<List<SensorCommand>> GetDeviceSensorCommandsAsync(
		string serial,
		[AliasAs("operations[]")] List<string>? operations = null,
		int? perPage = 1000,
		string? startingAfter = null,
		string? endingBefore = null,
		string? t0 = null,
		string? t1 = null,
		string? timespan = null,
		CancellationToken cancellationToken = default);

	[Get("/devices/{serial}/sensor/commands")]
	internal Task<ApiResponse<List<SensorCommand>>> GetDeviceSensorCommandsApiResponseAsync(
		string serial,
		[AliasAs("operations[]")] List<string>? operations = null,
		string? startingAfter = null,
		string? endingBefore = null,
		string? t0 = null,
		string? t1 = null,
		string? timespan = null,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Returns information about the command's execution, including the status
	/// </summary>
	/// <param name="serial">Serial</param>
	/// <param name="commandId">CommandId</param>
	/// <param name="cancellationToken"></param>
	/// <returns>A <see cref="SensorCommand"></returns>
	[ApiOperationId("getDeviceSensorCommand")]
	[Get("/devices/{serial}/sensor/commands/{commandId}")]
	Task<SensorCommand> GetDeviceSensorCommandAsync(
		string serial,
		string commandId,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Sends a command to a sensor
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="serial">The serial number</param>
	/// <param name="createDeviceSensorCommand">Body</param>
	[ApiOperationId("createDeviceSensorCommand")]
	[Post("/devices/{serial}/sensor/commands")]
	Task<SensorCommand> CreateDeviceSensorCommandAsync(
		string serial,
		[Body] SensorCommandCreateRequest createDeviceSensorCommand,
		CancellationToken cancellationToken = default);
}
