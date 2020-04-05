using Meraki.Api.Data;
using Refit;
using System.Threading.Tasks;

namespace Meraki.Api.Interfaces
{
	/// <summary>
	/// Represents a collection of functions to interact with the API endpoints
	/// </summary>
	public interface ITrafficShaping
	{
		/// <summary>
		/// getNetworkSsidTrafficShaping
		/// </summary>
		/// <remarks>
		/// Display the traffic shaping settings for a SSID on an MR network
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <param name="number"></param>
		/// <returns>Task of Object</returns>
		[Get("/networks/{networkId}/ssids/{number}/trafficShaping")]
		Task<object> GetNetworkSsidTrafficShaping(
			[AliasAs("networkId")]string networkId,
			[AliasAs("number")]string number
			);

		/// <summary>
		/// getNetworkTrafficShaping
		/// </summary>
		/// <remarks>
		/// Display the traffic shaping settings for an MX network
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <returns>Task of Object</returns>
		[Get("/networks/{networkId}/trafficShaping")]
		Task<object> GetNetworkTrafficShaping(
			[AliasAs("networkId")]string networkId
			);

		/// <summary>
		/// getNetworkTrafficShapingApplicationCategories
		/// </summary>
		/// <remarks>
		/// Returns the application categories for traffic shaping rules.
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <returns>Task of Object</returns>
		[Get("/networks/{networkId}/trafficShaping/applicationCategories")]
		Task<object> GetNetworkTrafficShapingApplicationCategories(
			[AliasAs("networkId")]string networkId
			);

		/// <summary>
		/// getNetworkTrafficShapingDscpTaggingOptions
		/// </summary>
		/// <remarks>
		/// Returns the available DSCP tagging options for your traffic shaping rules.
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <returns>Task of Object</returns>
		[Get("/networks/{networkId}/trafficShaping/dscpTaggingOptions")]
		Task<object> GetNetworkTrafficShapingDscpTaggingOptions(
			[AliasAs("networkId")]string networkId
			);

		/// <summary>
		/// updateNetworkSsidTrafficShaping
		/// </summary>
		/// <remarks>
		/// Update the traffic shaping settings for an SSID on an MR network
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <param name="number"></param>
		/// <param name="updateNetworkSsidTrafficShaping"> (optional)</param>
		/// <returns>Task of Object</returns>
		[Put("/networks/{networkId}/ssids/{number}/trafficShaping")]
		Task<object> UpdateNetworkSsidTrafficShaping(
			[AliasAs("networkId")]string networkId,
			[AliasAs("number")]string number,
			[Body]SsidTrafficShapingUpdateRequest updateNetworkSsidTrafficShaping
			);

		/// <summary>
		/// updateNetworkTrafficShaping
		/// </summary>
		/// <remarks>
		/// Update the traffic shaping settings for an MX network
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <param name="updateNetworkTrafficShaping"> (optional)</param>
		/// <returns>Task of Object</returns>
		[Put("/networks/{networkId}/trafficShaping")]
		Task<object> UpdateNetworkTrafficShaping(
			[AliasAs("networkId")]string networkId,
			[Body]TrafficShapingUpdateRequest updateNetworkTrafficShaping
			);
	}
}
