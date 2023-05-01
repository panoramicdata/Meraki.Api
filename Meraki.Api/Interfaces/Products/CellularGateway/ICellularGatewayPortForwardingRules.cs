namespace Meraki.Api.Interfaces.Products.CellularGateway;

/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>
public interface ICellularGatewayPortForwardingRules
{
	/// <summary>
	/// Returns the port forwarding rules for a single MG.
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="serial">The serial number</param>
	[Get("/devices/{serial}/cellularGateway/portForwardingRules")]
	Task<CellularGatewayPortForwardingRules> GetDeviceCellularGatewayPortForwardingRulesAsync(
		string serial,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Updates the port forwarding rules for a single MG.
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="serial">The serial number</param>
	/// <param name="updateDeviceCellularGatewaySettingsPortForwardingRules">Body for updating port forwarding rules</param>
	[Put("/devices/{serial}/cellularGateway/portForwardingRules")]
	Task<CellularGatewayPortForwardingRules> UpdateDeviceCellularGatewayPortForwardingRulesAsync(
		string serial,
		[Body] CellularGatewayPortForwardingRules updateDeviceCellularGatewaySettingsPortForwardingRules,
		CancellationToken cancellationToken = default
		);
}
