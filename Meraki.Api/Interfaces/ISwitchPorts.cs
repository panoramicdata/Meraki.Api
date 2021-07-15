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
	public interface ISwitchPorts
	{
		/// <summary>
		/// getDeviceSwitchPort
		/// </summary>
		/// <remarks>
		/// Return a switch port
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="serial"></param>
		/// <param name="number"></param>
		/// <returns>Task of Object</returns>
		[Get("/devices/{serial}/switch/ports/{portId}")]
		Task<DeviceSwitchPort> GetDeviceSwitchPort(
			[AliasAs("serial")]string serial,
			[AliasAs("portId")]string number,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// getDeviceSwitchPortStatuses
		/// </summary>
		/// <remarks>
		/// Return the status for all the ports of a switch
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="serial"></param>
		/// <param name="t0">The beginning of the timespan for the data. The maximum lookback period is 31 days from today. (optional)</param>
		/// <param name="timespan">The timespan for which the information will be fetched. If specifying timespan, do not specify parameter t0. The value must be in seconds and be less than or equal to 31 days. The default is 1 day. (optional)</param>
		/// <returns>Task of Object</returns>
		[Get("/devices/{serial}/switchPortStatuses")]
		Task<List<SwitchPortStatus>> GetDeviceSwitchPortStatuses(
			[AliasAs("serial")] string serial,
			[AliasAs("t0")] string t0 = null!,
			[AliasAs("timespan")] double? timespan = null
			);

		/// <summary>
		/// getDeviceSwitchPortStatusesPackets
		/// </summary>
		/// <remarks>
		/// Return the packet counters for all the ports of a switch
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="serial"></param>
		/// <param name="t0">The beginning of the timespan for the data. The maximum lookback period is 1 day from today. (optional)</param>
		/// <param name="timespan">The timespan for which the information will be fetched. If specifying timespan, do not specify parameter t0. The value must be in seconds and be less than or equal to 1 day. The default is 1 day. (optional)</param>
		/// <returns>Task of Object</returns>
		[Get("/devices/{serial}/switchPortStatuses/packets")]
		Task<object> GetDeviceSwitchPortStatusesPackets(
			[AliasAs("serial")] string serial,
			[AliasAs("t0")] string t0 = null!,
			[AliasAs("timespan")] double? timespan = null
			);

		/// <summary>
		/// getDeviceSwitchPorts
		/// </summary>
		/// <remarks>
		/// List the switch ports for a switch
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="serial"></param>
		/// <returns>Task of list of DeviceSwitchPorts</returns>
		[Get("/devices/{serial}/switch/ports")]
		Task<List<DeviceSwitchPort>> GetDeviceSwitchPorts(
			[AliasAs("serial")] string serial,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// updateDeviceSwitchPort
		/// </summary>
		/// <remarks>
		/// Update a switch port
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="serial"></param>
		/// <param name="number"></param>
		/// <param name="updateDeviceSwitchPort"> (optional)</param>
		/// <returns>Task of Object</returns>
		[Put("/devices/{serial}/switchPorts/{number}")]
		Task<object> UpdateDeviceSwitchPort(
			[AliasAs("serial")] string serial,
			[AliasAs("number")] string number,
			[Body] SwitchPortUpdateRequest updateDeviceSwitchPort
			);
	}
}
