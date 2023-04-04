namespace Meraki.Api.Interfaces.Products.Wireless;

public interface IWirelessChannelUtilizationHistory
{
	/// <summary>
	/// Return AP channel utilization over time for a device or network client
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="t0">The beginning of the timespan for the data. The maximum lookback period is 31 days from today. (optional)</param>
	/// <param name="t1">The end of the	 timespan for the data. t1 can be a maximum of 31 days after t0. (optional)</param>
	/// <param name="timespan">The timespan for which the information will be fetched. If specifying timespan, do not specify parameters t0 and t1. The value must be in seconds and be less than or equal to 31 days. The default is 1 day. (optional)</param>
	/// <param name="resolution">The time resolution in seconds for returned data. The valid resolutions are: 600. The default is 600.</param>
	/// <param name="autoResolution">Automatically select a data resolution based on the given timespan; this overrides the value specified by the 'resolution' parameter. The default setting is false.</param>
	/// <param name="clientId">Filter results by network client to return per-device, per-band AP channel utilization metrics inner joined by the queried client's connection history.</param>
	/// <param name="deviceSerial">Filter results by device to return AP channel utilization metrics for the queried device; either :band or :clientId must be jointly specified.</param>
	/// <param name="apTag">Filter results by AP tag to return AP channel utilization metrics for devices labeled with the given tag; either :clientId or :deviceSerial must be jointly specified.</param>
	/// <param name="band">Filter results by band (either '2.4' or '5').</param>
	[Get("/networks/{networkId}/wireless/channelUtilizationHistory")]
	Task<List<ChannelUtilizationHistory>> GetNetworkWirelessChannelUtilizationHistoryAsync(
		string networkId,
		string t0 = null!,
		string t1 = null!,
		double? timespan = null,
		int? resolution = null,
		bool? autoResolution = null,
		string? clientId = null,
		string? deviceSerial = null,
		string? apTag = null,
		string? band = null,
		CancellationToken cancellationToken = default
		);
}
