using Meraki.Api.Data;
using Refit;
using System.Threading.Tasks;

namespace Meraki.Api.Interfaces
{
	/// <summary>
	/// Represents a collection of functions to interact with the API endpoints
	/// </summary>
	public interface ISwitchPortSchedules
	{
		/// <summary>
		/// createNetworkSwitchPortSchedule
		/// </summary>
		/// <remarks>
		/// Add a switch port schedule
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <param name="createNetworkSwitchPortSchedule"></param>
		/// <returns>Task of Object</returns>
		[Post("/networks/{networkId}/switch/portSchedules")]
		Task<object> CreateNetworkSwitchPortSchedule(
			[AliasAs("networkId")]string networkId,
			[Body]SwitchPortScheduleCreationRequest createNetworkSwitchPortSchedule
			);

		/// <summary>
		/// deleteNetworkSwitchPortSchedule
		/// </summary>
		/// <remarks>
		/// Delete a switch port schedule
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <param name="portScheduleId"></param>
		/// <returns>Task of void</returns>
		[Delete("/networks/{networkId}/switch/portSchedules/{portScheduleId}")]
		Task DeleteNetworkSwitchPortSchedule(
			[AliasAs("networkId")]string networkId,
			[AliasAs("portScheduleId")]string portScheduleId
			);

		/// <summary>
		/// getNetworkSwitchPortSchedules
		/// </summary>
		/// <remarks>
		/// List switch port schedules
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <returns>Task of Object</returns>
		[Get("/networks/{networkId}/switch/portSchedules")]
		Task<object> GetNetworkSwitchPortSchedules(
			[AliasAs("networkId")]string networkId
			);

		/// <summary>
		/// updateNetworkSwitchPortSchedule
		/// </summary>
		/// <remarks>
		/// Update a switch port schedule
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <param name="portScheduleId"></param>
		/// <param name="updateNetworkSwitchPortSchedule"> (optional)</param>
		/// <returns>Task of Object</returns>
		[Put("/networks/{networkId}/switch/portSchedules/{portScheduleId}")]
		Task<object> UpdateNetworkSwitchPortSchedule(
			[AliasAs("networkId")]string networkId,
			[AliasAs("portScheduleId")]string portScheduleId,
			[Body]SwitchPortScheduleUpdateRequest updateNetworkSwitchPortSchedule
			);
	}
}
