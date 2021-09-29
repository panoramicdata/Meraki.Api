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
	public interface IEvents
	{
		/// <summary>
		/// List the events for the network
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="productType">The product type to fetch events for. This parameter is required for networks with multiple device types. Valid types are wireless, appliance, switch, systemsManager, camera, and cellularGateway (optional)</param>
		/// <param name="includedEventTypes">A list of event types. The returned events will be filtered to only include events with these types. (optional)</param>
		/// <param name="excludedEventTypes">A list of event types. The returned events will be filtered to exclude events with these types. (optional)</param>
		/// <param name="deviceMac">The MAC address of the Meraki device which the list of events will be filtered with (optional)</param>
		/// <param name="deviceSerial">The serial of the Meraki device which the list of events will be filtered with (optional)</param>
		/// <param name="deviceName">The name of the Meraki device which the list of events will be filtered with (optional)</param>
		/// <param name="clientIp">The IP of the client which the list of events will be filtered with. Only supported for track-by-IP networks. (optional)</param>
		/// <param name="clientMac">The MAC address of the client which the list of events will be filtered with. Only supported for track-by-MAC networks. (optional)</param>
		/// <param name="clientName">The name, or partial name, of the client which the list of events will be filtered with (optional)</param>
		/// <param name="smDeviceMac">The MAC address of the Systems Manager device which the list of events will be filtered with (optional)</param>
		/// <param name="smDeviceName">The name of the Systems Manager device which the list of events will be filtered with (optional)</param>
		/// <param name="perPage">The number of entries per page returned. Acceptable range is 3 - 1000. Default is 10. (optional)</param>
		/// <param name="startingAfter">A token used by the server to indicate the start of the page. Often this is a timestamp or an ID but it is not limited to those. This parameter should not be defined by client applications. The link for the first, last, prev, or next page in the HTTP Link header should define it. (optional)</param>
		/// <param name="endingBefore">A token used by the server to indicate the end of the page. Often this is a timestamp or an ID but it is not limited to those. This parameter should not be defined by client applications. The link for the first, last, prev, or next page in the HTTP Link header should define it. (optional)</param>
		[Get("/networks/{networkId}/events")]
		Task<NetworkEvents> GetNetworkEventsAsync(
			[AliasAs("networkId")] string networkId,
			[AliasAs("productType")] string productType = null!,
			[AliasAs("includedEventTypes")] List<string> includedEventTypes = null!,
			[AliasAs("excludedEventTypes")] List<string> excludedEventTypes = null!,
			[AliasAs("deviceMac")] string deviceMac = null!,
			[AliasAs("deviceSerial")] string deviceSerial = null!,
			[AliasAs("deviceName")] string deviceName = null!,
			[AliasAs("clientIp")] string clientIp = null!,
			[AliasAs("clientMac")] string clientMac = null!,
			[AliasAs("clientName")] string clientName = null!,
			[AliasAs("smDeviceMac")] string smDeviceMac = null!,
			[AliasAs("smDeviceName")] string smDeviceName = null!,
			[AliasAs("perPage")] int? perPage = 1000,
			[AliasAs("startingAfter")] string startingAfter = null!,
			[AliasAs("endingBefore")] string endingBefore = null!,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// List the event type to human-readable description
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		[Get("/networks/{networkId}/events/eventTypes")]
		Task<List<EventType>> GetNetworkEventsEventTypesAsync(
			[AliasAs("networkId")] string networkId,
			CancellationToken cancellationToken = default
			);
	}
}
