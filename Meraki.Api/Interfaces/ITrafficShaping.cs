using Meraki.Api.Data;
using Refit;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Meraki.Api.Interfaces
{
	/// <summary>
	/// Represents a collection of functions to interact with the API endpoints
	/// </summary>
	public interface ITrafficShaping
	{
		/// <summary>
		/// Display the traffic shaping settings for a SSID on an MR network
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="number">The SSID number</param>
		[Get("/networks/{networkId}/wireless/ssids/{number}/trafficShaping/rules")]
		Task<SsidTrafficShapingUpdateRequest> GetNetworkWirelessSsidTrafficShapingRulesAsync(
			[AliasAs("networkId")] string networkId,
			[AliasAs("number")] string number,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Returns the application categories for traffic shaping rules.
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		[Get("/networks/{networkId}/trafficShaping/applicationCategories")]
		Task<Layer7ApplicationCategories> GetNetworkTrafficShapingApplicationCategoriesAsync(
			[AliasAs("networkId")] string networkId,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Returns the available DSCP tagging options for your traffic shaping rules.
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		[Get("/networks/{networkId}/trafficShaping/dscpTaggingOptions")]
		Task<List<DscpTaggingValues>> GetNetworkTrafficShapingDscpTaggingOptionsAsync(
			[AliasAs("networkId")] string networkId,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Update the traffic shaping settings for an SSID on an MR network
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="number">The SSID number</param>
		/// <param name="UpdateNetworkSsidTrafficShaping"></param>
		[Put("/networks/{networkId}/wireless/ssids/{number}/trafficShaping/rules")]
		Task<SsidTrafficShapingUpdateRequest> UpdateNetworkWirelessSsidTrafficShapingRulesAsync(
			[AliasAs("networkId")] string networkId,
			[AliasAs("number")] string number,
			[Body] SsidTrafficShapingUpdateRequest UpdateNetworkSsidTrafficShaping,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Show uplink selection settings for an MX network
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		[Get("/networks/{networkId}/appliance/trafficShaping/uplinkSelection")]
		Task<UplinkSelection> GetNetworkApplianceTrafficShapingUpinkSelectionAsync(
			[AliasAs("networkId")] string networkId,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Update uplink selection settings for an MX network
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		[Put("/networks/{networkId}/appliance/trafficShaping/uplinkSelection")]
		Task<UplinkSelection> UpdateNetworkApplianceTrafficShapingUplinkSelectionAsync(
			[AliasAs("networkId")] string networkId,
			[Body] UplinkSelection UpdateNetworkApplianceTrafficShapingUplinkSelection,
			CancellationToken cancellationToken = default
			);
	}
}
