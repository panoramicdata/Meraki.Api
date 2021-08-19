using Meraki.Api.Data;
using Refit;
using System.Threading;
using System.Threading.Tasks;

namespace Meraki.Api.Interfaces
{
	/// <summary>
	/// Represents a collection of functions to interact with the API endpoints
	/// </summary>
	public interface IMgLanSettings
	{
		/// <summary>
		/// Show the LAN Settings of a MG
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="serial">The serial number</param>
		[Get("/devices/{serial}/cellularGateway/lan")]
		Task<CellularGatewaySettingsUpdateRequest> GetCellularGatewaySettingsAsync(
			[AliasAs("serial")] string serial,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// Update the LAN Settings for a single MG.
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="serial">The serial number</param>
		/// <param name="CellularGatewaySettingsUpdateRequest">Body for updating LAN settings</param>
		[Put("/devices/{serial}/cellularGateway/lan")]
		Task<CellularGatewaySettingsUpdateRequest> UpdateCellularGatewaySettingsAsync(
			[AliasAs("serial")] string serial,
			[Body] CellularGatewaySettingsUpdateRequest CellularGatewaySettingsUpdateRequest,
			CancellationToken cancellationToken = default);
	}
}
