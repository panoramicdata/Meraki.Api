namespace Meraki.Api.Interfaces.General.Networks;

/// <summary>
/// I Networks Events Event Types
/// </summary>
public interface INetworksEventsEventTypes
{
	/// <summary>
	/// List the event type to human-readable description
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="cancellationToken"></param>
	[ApiOperationId("getNetworkEventsEventTypes")]
	[Get("/networks/{networkId}/events/eventTypes")]
	Task<List<EventType>> GetNetworkEventsEventTypesAsync(
		string networkId,
		CancellationToken cancellationToken = default
		);
}
