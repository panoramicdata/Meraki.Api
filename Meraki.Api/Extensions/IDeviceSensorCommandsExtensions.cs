namespace Meraki.Api.Extensions;
public static class IDeviceSensorCommandsExtensions
{
	/// <summary>
	/// Returns a historical log of all commands
	/// </summary>
	/// <param name="serial">Serial</param>
	/// <param name="operations">Optional parameter to filter commands by operation</param>
	/// <param name="endingBefore">A token used by the server to indicate the end of the page. Often this is a timestamp or an ID but it is not limited to those. This parameter should not be defined by client applications. The link for the first, last, prev, or next page in the HTTP Link header should define it.</param>
	/// <param name="t0">The beginning of the timespan for the data. The maximum lookback period is 30 days from today.</param>
	/// <param name="t1">The end of the timespan for the data. t1 can be a maximum of 30 days after t0.</param>
	/// <param name="timespan">The timespan for which the information will be fetched. If specifying timespan, do not specify parameters t0 and t1. The value must be in seconds and be less than or equal to 30 days. The default is 1 day.</param>
	/// <param name="cancellationToken"></param>
	/// <returns>A list of <see cref="SensorCommand"></returns>
	public static Task<List<SensorCommand>> GetDeviceSensorCommandsAllAsync(
		this IDeviceSensorCommands deviceSensorCommands,
		string serial,
		List<string>? operations = null,
		string? endingBefore = null,
		string? t0 = null,
		string? t1 = null,
		string? timespan = null,
		CancellationToken cancellationToken = default)
		=> MerakiClient.GetAllAsync(
				(startingAfter, cancellationToken)
				=> deviceSensorCommands.GetDeviceSensorCommandsApiResponseAsync(
					serial,
					operations,
					startingAfter,
					endingBefore,
					t0,
					t1,
					timespan,
					cancellationToken
				),
				cancellationToken
			);
}
