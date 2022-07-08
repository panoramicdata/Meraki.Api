﻿namespace Meraki.Api.Interfaces.Products.Appliance;

public interface IApplianceSettings
{
	/// <summary>
	/// Return the appliance settings for a network
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	[ApiOperationId("getNetworkApplianceSettings")]
	[Get("/networks/{networkId}/appliance/settings")]
	Task<ApplianceSettings> GetNetworkApplianceSettingsAsync(
		[AliasAs("networkId")] string networkId,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Update the appliance settings for a network
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	[ApiOperationId("updateNetworkApplianceSettings")]
	[Put("/networks/{networkId}/appliance/settings")]
	Task<ApplianceSettings> UpdateNetworkApplianceSettingsAsync(
		[AliasAs("networkId")] string networkId,
		[Body] ApplianceSettings applianceSettings,
		CancellationToken cancellationToken = default
		);
}
