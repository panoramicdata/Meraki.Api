namespace Meraki.Api.Interfaces.Products.CellularGateway;

/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>
public interface ICellularGatewayLan
{
	/// <summary>
	/// Show the LAN Settings of a MG
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="serial">The serial number</param>
	/// <param name="cancellationToken"></param>
	[Get("/devices/{serial}/cellularGateway/lan")]
	Task<CellularGatewayLan> GetDeviceCellularGatewayLanAsync(
		string serial,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Update the LAN Settings for a single MG.
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="serial">The serial number</param>
	/// <param name="cellularGatewaySettings">Body for updating LAN settings</param>
	/// <param name="cancellationToken"></param>
	[Put("/devices/{serial}/cellularGateway/lan")]
	Task<CellularGatewayLan> UpdateDeviceCellularGatewayLanAsync(
		string serial,
		[Body] CellularGatewayLanUpdateRequest cellularGatewaySettings,
		CancellationToken cancellationToken = default);
}
