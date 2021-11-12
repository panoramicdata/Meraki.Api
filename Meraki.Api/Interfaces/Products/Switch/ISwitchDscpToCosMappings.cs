namespace Meraki.Api.Interfaces.Products.Switch;

/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>
public interface ISwitchDscpToCosMappings
{
	/// <summary>
	/// Return the DSCP to CoS mappings
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	[ApiOperationId("getNetworkSwitchDscpToCosMappings")]
	[Get("/networks/{networkId}/switch/dscpToCosMappings")]
	Task<DscpToCosMappings> GetDscpToCosMappingsAsync(
		[AliasAs("networkId")] string networkId,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Update the DSCP to CoS mappings
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="settingsDscpToCosMappings"></param>
	[ApiOperationId("updateNetworkSwitchDscpToCosMappings")]
	[Put("/networks/{networkId}/switch/dscpToCosMappings")]
	Task<DscpToCosMappings> UpdateDscpToCosMappingsAsync(
		[AliasAs("networkId")] string networkId,
		[Body] DscpToCosMappings settingsDscpToCosMappings,
		CancellationToken cancellationToken = default
		);
}
