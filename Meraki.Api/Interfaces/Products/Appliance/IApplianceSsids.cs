namespace Meraki.Api.Interfaces.Products.Appliance;

public interface IApplianceSsids
{
	/// <summary>
	/// Return a single MX SSID
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="number">The number of the SSID</param>
	/// <param name="cancellationToken"></param>
	[ApiOperationId("getNetworkApplianceSsid")]
	[Get("/networks/{networkId}/appliance/ssids/{number}")]
	Task<NetworkApplianceSsid> GetNetworkApplianceSsidAsync(
		string networkId,
		string number,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// List the MX SSIDs in a network
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="cancellationToken"></param>
	[ApiOperationId("getNetworkApplianceSsids")]
	[Get("/networks/{networkId}/appliance/ssids")]
	Task<List<NetworkApplianceSsid>> GetNetworkApplianceSsidsAsync(
		string networkId,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Update the attributes of an MX SSID
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="number">The number of the SSID</param>
	/// <param name="networkApplianceSsidUpdateRequest">The body for updating an SSID</param>
	/// <param name="cancellationToken"></param>
	[ApiOperationId("updateNetworkApplianceSsid")]
	[Put("/networks/{networkId}/appliance/ssids/{number}")]
	Task<NetworkApplianceSsid> UpdateNetworkApplianceSsidAsync(
		string networkId,
		string number,
		NetworkApplianceSsidUpdateRequest networkApplianceSsidUpdateRequest,
		CancellationToken cancellationToken = default
		);
}
