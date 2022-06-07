namespace Meraki.Api.Interfaces.Products.Sensor;

public interface IOrganizationSensorReadingsHistory
{
	/// <summary>
	/// Return all reported readings from sensors in a given timespan, sorted by timestamp
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="perPage">The number of entries per page returned. Acceptable range is 3 - 1000. Default is 1000.</param>
	/// <param name="startingAfter">A token used by the server to indicate the start of the page. Often this is a timestamp or an ID but it is not limited to those. This parameter should not be defined by client applications. The link for the first, last, prev, or next page in the HTTP Link header should define it.</param>
	/// <param name="endingBefore">A token used by the server to indicate the end of the page. Often this is a timestamp or an ID but it is not limited to those. This parameter should not be defined by client applications. The link for the first, last, prev, or next page in the HTTP Link header should define it.</param>
	/// <param name="t0">The beginning of the timespan for the data. The maximum lookback period is 365 days and 6 hours from today.</param>
	/// <param name="t1">The end of the timespan for the data. t1 can be a maximum of 7 days after t0.</param>
	/// <param name="timespan">The timespan for which the information will be fetched. If specifying timespan, do not specify parameters t0 and t1. The value must be in seconds and be less than or equal to 7 days. The default is 2 hours.</param>
	/// <param name="networkIds">Optional parameter to filter readings by network.</param>
	/// <param name="serials">Optional parameter to filter readings by sensor.</param>
	/// <param name="metrics">Types of sensor readings to retrieve. If no metrics are supplied, all available types of readings will be retrieved. Allowed values are temperature, humidity, water, door, tvoc, pm25, noise, indoorAirQuality, button, and battery.</param>
	[Get("/organizations/{organizationId}/sensor/readings/history")]
	Task<List<SensorReading>> GetOrganizationSensorReadingsHistoryAsync(
		[AliasAs("perPage")] int? perPage,
		[AliasAs("startingAfter")] string? startingAfter = null,
		[AliasAs("endingBefore")] string? endingBefore = null,
		[AliasAs("t0")] string t0 = null!,
		[AliasAs("t1")] string t1 = null!,
		[AliasAs("timespan")] double? timespan = null,
		[AliasAs("networkIds")] List<string>? networkIds = null,
		[AliasAs("serials")] List<string>? serials = null,
		[AliasAs("metrics")] List<SensorMetrics>? metrics = null,
		CancellationToken cancellationToken = default
		);
}
