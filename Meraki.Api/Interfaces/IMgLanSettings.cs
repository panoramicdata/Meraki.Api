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
		/// getDeviceCellularGatewaySettings
		/// </summary>
		/// <remarks>
		/// Show the LAN Settings of a MG
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="serial"></param>
		/// <returns>Task of Object</returns>
		[Get("/devices/{serial}/cellularGateway/settings")]
		Task<object> GetCellularGatewaySettingsAsync(
			[AliasAs("serial")]string serial,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// updateDeviceCellularGatewaySettings
		/// </summary>
		/// <remarks>
		/// Update the LAN Settings for a single MG.
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="serial"></param>
		/// <param name="cellularGatewaySettingsUpdateRequest"> (optional)</param>
		/// <returns>Task of Object</returns>
		[Put("/devices/{serial}/cellularGateway/settings")]
		Task<object> UpdateCellularGatewaySettingsAsync(
			[AliasAs("serial")]string serial,
			[Body]CellularGatewaySettingsUpdateRequest cellularGatewaySettingsUpdateRequest,
			CancellationToken cancellationToken = default);
	}
}
