using Meraki.Api.Data;
using Refit;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Meraki.Api.Interfaces
{
	/// <summary>
	/// Represents a collection of functions to interact with the API endpoints
	/// </summary>
	public interface IDataRateHistory
	{
		/// <summary>
		/// Return PHY data rates over time for a network, device, or network client
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="t0">The beginning of the timespan for the data. The maximum lookback period is 31 days from today.</param>
		/// <param name="t1">The end of the timespan for the data. t1 can be a maximum of 31 days after t0.</param>
		/// <param name="timespan">The timespan for which the information will be fetched. If specifying timespan, do not specify parameters t0 and t1. The value must be in seconds and be less than or equal to 31 days. The default is 7 days.</param>
		/// <param name="resolution">The time resolution in seconds for returned data. The valid resolutions are: 300, 600, 1200, 3600, 14400, 86400. The default is 86400.</param>
		/// <param name="autoResolution">Automatically select a data resolution based on the given timespan; this overrides the value specified by the 'resolution' parameter. The default setting is false.</param>
		/// <param name="clientId">Filter results by network client.</param>
		/// <param name="deviceSerial">Filter results by device.</param>
		/// <param name="apTag">Filter results by AP tag.	</param>
		/// <param name="band">Filter results by band (either '2.4' or '5').</param>
		/// <param name="ssid">Filter results by SSID number.</param>
		[Get("/networks/{networkId}/wireless/dataRateHistory")]
		Task<List<DataRateHistory>> GetNetworkWirelessDataRateHistoryAsync(
			[AliasAs("networkId")]string networkId,
			[AliasAs("t0")] string? t0 = null,
			[AliasAs("t1")] string? t1 = null,
			[AliasAs("timespan")] double? timespan = null,
			[AliasAs("resolution")] int? resolution = null,
			[AliasAs("autoResolution")] bool? autoResolution = null,
			[AliasAs("clientId")] string? clientId = null,
			[AliasAs("deviceSerial")] string? deviceSerial = null,
			[AliasAs("apTag")] string? apTag = null,
			[AliasAs("band")] string? band = null,
			[AliasAs("ssid")] int? ssid = null,
			CancellationToken cancellationToken = default
			);
	}
}