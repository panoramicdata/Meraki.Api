﻿namespace Meraki.Api.Interfaces.Products.Sm;

public interface ISmTrustedAccessConfigs
{
	/// <summary>
	/// List Trusted Access Configs
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="perPage">The number of entries per page returned. Acceptable range is 3 - 1000. Default is 100. (optional)</param>
	/// <param name="startingAfter">A token used by the server to indicate the start of the page. Often this is a timestamp or an ID but it is not limited to those. This parameter should not be defined by client applications. The link for the first, last, prev, or next page in the HTTP Link header should define it. (optional)</param>
	/// <param name="endingBefore">A token used by the server to indicate the end of the page. Often this is a timestamp or an ID but it is not limited to those. This parameter should not be defined by client applications. The link for the first, last, prev, or next page in the HTTP Link header should define it. (optional)</param>
	[ApiOperationId("getNetworkSmTrustedAccessConfigs")]
	[Get("/networks/{networkId}/sm/trustedAccessConfigs")]
	Task<List<SmTrustedAccessConfig>> GetNetworkSmTrustedAccessConfigsAsync(
		[AliasAs("networkId")] string networkId,
		[AliasAs("perPage")] int? perPage = 1000,
		[AliasAs("startingAfter")] string? startingAfter = null,
		[AliasAs("endingBefore")] string? endingBefore = null,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// List Trusted Access Configs
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="startingAfter">A token used by the server to indicate the start of the page. Often this is a timestamp or an ID but it is not limited to those. This parameter should not be defined by client applications. The link for the first, last, prev, or next page in the HTTP Link header should define it. (optional)</param>
	[ApiOperationId("getNetworkSmTrustedAccessConfigs")]
	[Get("/networks/{networkId}/sm/trustedAccessConfigs")]
	internal Task<ApiResponse<List<SmTrustedAccessConfig>>> GetNetworkSmTrustedAccessConfigsApiResponseAsync(
		[AliasAs("networkId")] string networkId,
		[AliasAs("startingAfter")] string? startingAfter = null,
		CancellationToken cancellationToken = default
		);
}
