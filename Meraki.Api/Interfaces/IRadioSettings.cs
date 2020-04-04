using Meraki.Api.Data;
using Refit;
using System.Threading.Tasks;

namespace Meraki.Api.Interfaces
{
	/// <summary>
	/// Represents a collection of functions to interact with the API endpoints
	/// </summary>
	public interface IRadioSettings
	{
		/// <summary>
		/// createNetworkWirelessRfProfile
		/// </summary>
		/// <remarks>
		/// Creates new RF profile for this network
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <param name="createNetworkWirelessRfProfile"></param>
		/// <returns>Task of Object</returns>
		[Post("/networks/{networkId}/wireless/rfProfiles")]
		Task<object> CreateNetworkWirelessRfProfile(
			[AliasAs("networkId")]string networkId,
			[Body]CreateNetworkWirelessRfProfile createNetworkWirelessRfProfile
			);

		/// <summary>
		/// deleteNetworkWirelessRfProfile
		/// </summary>
		/// <remarks>
		/// Delete a RF Profile
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <param name="rfProfileId"></param>
		/// <returns>Task of void</returns>
		[Delete("/networks/{networkId}/wireless/rfProfiles/{rfProfileId}")]
		Task DeleteNetworkWirelessRfProfile(
			[AliasAs("networkId")]string networkId,
			[AliasAs("rfProfileId")]string rfProfileId
			);

		/// <summary>
		/// getNetworkDeviceWirelessRadioSettings
		/// </summary>
		/// <remarks>
		/// Return the radio settings of a device
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <param name="serial"></param>
		/// <returns>Task of Object</returns>
		[Get("/networks/{networkId}/devices/{serial}/wireless/radioSettings")]
		Task<object> GetNetworkDeviceWirelessRadioSettings(
			[AliasAs("networkId")]string networkId,
			[AliasAs("serial")]string serial
			);

		/// <summary>
		/// getNetworkWirelessRfProfile
		/// </summary>
		/// <remarks>
		/// Return a RF profile
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <param name="rfProfileId"></param>
		/// <returns>Task of Object</returns>
		[Get("/networks/{networkId}/wireless/rfProfiles/{rfProfileId}")]
		Task<object> GetNetworkWirelessRfProfile(
			[AliasAs("networkId")]string networkId,
			[AliasAs("rfProfileId")]string rfProfileId
			);

		/// <summary>
		/// getNetworkWirelessRfProfiles
		/// </summary>
		/// <remarks>
		/// List the non-basic RF profiles for this network
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <param name="includeTemplateProfiles">    If the network is bound to a template, this parameter controls whether or not the non-basic RF profiles defined on the template     should be included in the response alongside the non-basic profiles defined on the bound network. Defaults to false.  (optional)</param>
		/// <returns>Task of Object</returns>
		[Get("/networks/{networkId}/wireless/rfProfiles")]
		Task<object> GetNetworkWirelessRfProfiles(
			[AliasAs("networkId")]string networkId,
			[AliasAs("includeTemplateProfiles")]bool? includeTemplateProfiles = null
			);

		/// <summary>
		/// updateNetworkDeviceWirelessRadioSettings
		/// </summary>
		/// <remarks>
		/// Update the radio settings of a device
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <param name="serial"></param>
		/// <param name="updateNetworkDeviceWirelessRadioSettings"> (optional)</param>
		/// <returns>Task of Object</returns>
		[Put("/networks/{networkId}/devices/{serial}/wireless/radioSettings")]
		Task<object> UpdateNetworkDeviceWirelessRadioSettings(
			[AliasAs("networkId")]string networkId,
			[AliasAs("serial")]string serial,
			[Body]UpdateNetworkDeviceWirelessRadioSettings updateNetworkDeviceWirelessRadioSettings
			);

		/// <summary>
		/// updateNetworkWirelessRfProfile
		/// </summary>
		/// <remarks>
		/// Updates specified RF profile for this network
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <param name="rfProfileId"></param>
		/// <param name="updateNetworkWirelessRfProfile"> (optional)</param>
		/// <returns>Task of Object</returns>
		[Put("/networks/{networkId}/wireless/rfProfiles/{rfProfileId}")]
		Task<object> UpdateNetworkWirelessRfProfile(
			[AliasAs("networkId")]string networkId,
			[AliasAs("rfProfileId")]string rfProfileId,
			[Body]UpdateNetworkWirelessRfProfile updateNetworkWirelessRfProfile
			);
	}
}
