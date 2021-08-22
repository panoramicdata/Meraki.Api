using Meraki.Api.Data;
using Refit;
using System.Threading;
using System.Threading.Tasks;

namespace Meraki.Api.Interfaces
{
	/// <summary>
	/// Represents a collection of functions to interact with the API endpoints
	/// </summary>
	public interface IMgPortForwardingRules
	{
		/// <summary>
		/// Returns the port forwarding rules for a single MG.
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="serial">The serial number</param>
		[Get("/devices/{serial}/cellularGateway/settings/portForwardingRules")]
		Task<CellularGatewaySettingsPortForwardingRulesUpdateRequest> GetDeviceCellularGatewaySettingsPortForwardingRulesAsync(
			[AliasAs("serial")] string serial,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Updates the port forwarding rules for a single MG.
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="serial">The serial number</param>
		/// <param name="updateDeviceCellularGatewaySettingsPortForwardingRules">Body for updating port forwarding rules</param>
		[Put("/devices/{serial}/cellularGateway/settings/portForwardingRules")]
		Task<CellularGatewaySettingsPortForwardingRulesUpdateRequest> UpdateDeviceCellularGatewaySettingsPortForwardingRulesAsync(
			[AliasAs("serial")] string serial,
			[Body] CellularGatewaySettingsPortForwardingRulesUpdateRequest updateDeviceCellularGatewaySettingsPortForwardingRules,
			CancellationToken cancellationToken = default
			);
	}
}
