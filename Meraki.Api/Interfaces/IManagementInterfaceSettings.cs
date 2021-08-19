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
		/// Return the management interface settings for a device
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="serial">The serial number</param>
		[Get("/devices/{serial}/managementInterfaceSettings")]
		Task<WanSpecs> GetAsync(
			[AliasAs("serial")] string serial,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// Update the management interface settings for a device
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="serial">The serial number</param>
		/// <param name="ManagementInterfaceSettingsUpdateDto">Body for updating management interface settings</param>
		[Put("/devices/{serial}/managementInterfaceSettings")]
		Task<WanSpecs> UpdateAsync(
			[AliasAs("serial")] string serial,
			[Body] ManagementInterfaceSettingsUpdateRequest ManagementInterfaceSettingsUpdateDto,
			CancellationToken cancellationToken = default);
	}
}
