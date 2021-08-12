using Meraki.Api.Data;
using Refit;
using System.Threading.Tasks;

namespace Meraki.Api.Interfaces
{
	/// <summary>
	/// Represents a collection of functions to interact with the API endpoints
	/// </summary>
	public interface IMgPortForwardingRules
	{
		/// <summary>
		/// getDeviceCellularGatewaySettingsPortForwardingRules
		/// </summary>
		/// <remarks>
		/// Returns the port forwarding rules for a single MG.
		/// </remarks>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="serial">The serial number</param>
		/// <returns>Task of Object</returns>
		[Get("/devices/{serial}/cellularGateway/settings/portForwardingRules")]
		Task<object> GetDeviceCellularGatewaySettingsPortForwardingRules(
			[AliasAs("serial")]string serial
			);

		/// <summary>
		/// updateDeviceCellularGatewaySettingsPortForwardingRules
		/// </summary>
		/// <remarks>
		/// Updates the port forwarding rules for a single MG.
		/// </remarks>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="serial">The serial number</param>
		/// <param name="updateDeviceCellularGatewaySettingsPortForwardingRules"> (optional)</param>
		/// <returns>Task of Object</returns>
		[Put("/devices/{serial}/cellularGateway/settings/portForwardingRules")]
		Task<object> UpdateDeviceCellularGatewaySettingsPortForwardingRules(
			[AliasAs("serial")]string serial,
			[Body]CellularGatewaySettingsPortForwardingRulesUpdateRequest updateDeviceCellularGatewaySettingsPortForwardingRules
			);
	}
}
