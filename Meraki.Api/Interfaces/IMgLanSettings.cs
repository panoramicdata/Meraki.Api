using Meraki.Api.Data;
using Refit;
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
		Task<object> GetDeviceCellularGatewaySettings(
			[AliasAs("serial")]string serial
			);

		/// <summary>
		/// updateDeviceCellularGatewaySettings
		/// </summary>
		/// <remarks>
		/// Update the LAN Settings for a single MG.
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="serial"></param>
		/// <param name="updateDeviceCellularGatewaySettings"> (optional)</param>
		/// <returns>Task of Object</returns>
		[Put("/devices/{serial}/cellularGateway/settings")]
		Task<object> UpdateDeviceCellularGatewaySettings(
			[AliasAs("serial")]string serial,
			[Body]UpdateDeviceCellularGatewaySettings updateDeviceCellularGatewaySettings
			);
	}
}
