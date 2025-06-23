﻿namespace Meraki.Api.Interfaces.Products.Appliance;

/// <summary>
/// Defines methods for retrieving performance metrics for appliances.
/// </summary>
/// <remarks>This interface provides functionality to fetch performance data for a specific appliance identified
/// by its serial number. The performance data can be retrieved for a specific time range or a specified
/// timespan.</remarks>
public interface IAppliancePerformance
{
	/// <summary>
	/// Return the performance score for a single MX
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="serial">The serial number</param>
	/// <param name="t0">The beginning of the timespan for the data.</param>
	/// <param name="t1">The end of the timespan for the data. t1 can be a maximum of 14 days after t0.</param>
	/// <param name="timespan">The timespan for which the information will be fetched. If specifying timespan, do not specify parameters t0 and t1. The value must be in seconds and be greater than or equal to 30 minutes and be less than or equal to 14 days. The default is 30 minutes.minimum = 1800, maximum = 1209600</param>
	/// <param name="cancellationToken">Cancellation token</param>
	[Get("/devices/{serial}/appliance/performance")]
	Task<Performance> GetDeviceAppliancePerformanceAsync(
		string serial,
		string? t0,
		string? t1,
		int? timespan,
		CancellationToken cancellationToken = default);
}
