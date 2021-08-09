using Meraki.Api.Data;
using Refit;
using System.Threading;
using System.Threading.Tasks;

namespace Meraki.Api.Interfaces
{
	/// <summary>
	/// Represents a collection of functions to interact with the API endpoints
	/// </summary>
	public interface ISwitchWarmSpare
	{
		/// <summary>
		/// getDeviceSwitchWarmSpare
		/// </summary>
		/// <remarks>
		/// Return warm spare configuration for a switch
		/// </remarks>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="serial"></param>
		/// <returns>Task of Object</returns>
		[Get("/devices/{serial}/switch/warmSpare")]
		Task<SwitchWarmSpare> GetDeviceSwitchWarmSpare(
			[AliasAs("serial")]string serial
			);

		/// <summary>
		/// updateDeviceSwitchWarmSpare
		/// </summary>
		/// <remarks>
		/// Update warm spare configuration for a switch
		/// </remarks>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="serial"></param>
		/// <param name="updateDeviceSwitchWarmSpare"></param>
		/// <returns>Task of Object</returns>
		[Put("/devices/{serial}/switch/warmSpare")]
		Task<object> UpdateAsync(
			[AliasAs("serial")]string serial,
			[Body]SwitchWarmSpareUpdateRequest updateDeviceSwitchWarmSpare,
			CancellationToken cancellationToken = default);
	}
}