namespace Meraki.Api.Interfaces.General.Networks;

public interface INetworksTrafficShapingDscpTaggingOptions
{
	/// <summary>
	/// Returns the available DSCP tagging options for your traffic shaping rules.
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	[Get("/networks/{networkId}/trafficShaping/dscpTaggingOptions")]
	Task<List<DscpTaggingValue>> GetNetworkTrafficShapingDscpTaggingOptionsAsync(
		string networkId,
		CancellationToken cancellationToken = default
		);
}
