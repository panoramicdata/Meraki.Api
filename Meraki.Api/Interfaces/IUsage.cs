using Meraki.Api.Data;
using Refit;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Meraki.Api.Interfaces
{
	public interface IUsage
	{
		/// <summary>
		/// getNetworkWirelessUsageHistory
		/// </summary>
		/// <remarks>
		/// Return AP usage over time for a device or network client
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
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
		/// <returns>Task of Object</returns>
		[Get("/networks/{networkId}/wireless/usageHistory")]
		Task<List<UsageHistory>> GetNetworkWirelessUsageHistory(
			[AliasAs("networkId")] string networkId,
			[AliasAs("t0")] string? t0 = null,
			[AliasAs("t1")] string? t1 = null,
			[AliasAs("timespan")] double? timespan = null,
			[AliasAs("resolution")] int? resolution = null,
			[AliasAs("autoResolution")] bool? autoResolution = null,
			[AliasAs("clientId")] string? clientId = null,
			[AliasAs("deviceSerial")] string? deviceSerial = null,
			[AliasAs("apTag")] string? apTag = null,
			[AliasAs("band")] string? band = null,
			[AliasAs("ssid")] string? ssid = null
			);
	}
}
