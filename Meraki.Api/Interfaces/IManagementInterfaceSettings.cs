using Meraki.Api.Data;
using Refit;
using System.Threading;
using System.Threading.Tasks;

namespace Meraki.Api.Interfaces
{
	/// <summary>
	/// Represents a collection of functions to interact with the API endpoints
	/// </summary>
	public interface IManagementInterfaceSettings
	{
		/// <summary>
		/// getNetworkDeviceManagementInterfaceSettings
		/// </summary>
		/// <remarks>
		/// Return the management interface settings for a device
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <param name="serial"></param>
		/// <returns>Task of Object</returns>
		[Get("/devices/{serial}/managementInterfaceSettings")]
		Task<WanSpecs> GetAsync(
			[AliasAs("serial")]string serial,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// updateNetworkDeviceManagementInterfaceSettings
		/// </summary>
		/// <remarks>
		/// Update the management interface settings for a device
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <param name="serial"></param>
		/// <param name="updateNetworkDeviceManagementInterfaceSettings"> (optional)</param>
		/// <returns>Task of Object</returns>
		[Put("/devices/{serial}/managementInterfaceSettings")]
		Task<WanSpecs> UpdateAsync(
			[AliasAs("serial")]string serial,
			[Body]ManagementInterfaceSettingsUpdateRequest managementInterfaceSettingsUpdateDto,
			CancellationToken cancellationToken = default);
	}
}
