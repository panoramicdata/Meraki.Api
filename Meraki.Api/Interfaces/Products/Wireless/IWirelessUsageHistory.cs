namespace Meraki.Api.Interfaces.Products.Wireless;

/// <summary>
/// I Wireless Usage History
/// </summary>
public interface IWirelessUsageHistory
{
	/// <summary>
	/// Return AP usage over time for a device or network client
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="t0">The beginning of the timespan for the data. The maximum lookback period is 31 days from today.</param>
	/// <param name="t1">The end of the timespan for the data. t1 can be a maximum of 31 days after t0.</param>
	/// <param name="timespan">The timespan for which the information will be fetched. If specifying timespan, do not specify parameters t0 and t1. The value must be in seconds and be less than or equal to 31 days. The default is 7 days.</param>
	/// <param name="resolution">The time resolution in seconds for returned data. The valid resolutions are: 300, 600, 1200, 3600, 14400, 86400. The default is 86400.</param>
	/// <param name="autoResolution">Automatically select a data resolution based on the given timespan; this overrides the value specified by the 'resolution' parameter. The default setting is false.</param>
	/// <param name="clientId">Filter results by network client to return per-device AP usage over time inner joined by the queried client's connection history.</param>
	/// <param name="deviceSerial">Filter results by device. Requires :band.</param>
	/// <param name="apTag">Filter results by AP tag; either :clientId or :deviceSerial must be jointly specified.</param>
	/// <param name="band">Filter results by band (either '2.4' or '5').</param>
	/// <param name="ssid">Filter results by SSID number.</param>
	/// <param name="cancellationToken"></param>
	[Get("/networks/{networkId}/wireless/usageHistory")]
	Task<List<UsageHistory>> GetNetworkWirelessUsageHistoryAsync(
		string networkId,
		string? t0 = null,
		string? t1 = null,
		double? timespan = null,
		int? resolution = null,
		bool? autoResolution = null,
		string? clientId = null,
		string? deviceSerial = null,
		string? apTag = null,
		string? band = null,
		string? ssid = null,
		CancellationToken cancellationToken = default
		);
}
