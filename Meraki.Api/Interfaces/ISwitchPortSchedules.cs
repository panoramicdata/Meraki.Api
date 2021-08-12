using Meraki.Api.Data;
using Refit;
using System.Collections.Generic;
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
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="createNetworkSwitchPortSchedule"></param>
		/// <returns>The created Switch Port Schedule</returns>
		[Post("/networks/{networkId}/switch/portSchedules")]
		Task<SwitchPortSchedule> CreateNetworkSwitchPortSchedule(
			[AliasAs("networkId")] string networkId,
			[Body] SwitchPortScheduleCreationRequest createNetworkSwitchPortSchedule
			);

		/// <summary>
		/// deleteNetworkSwitchPortSchedule
		/// </summary>
		/// <remarks>
		/// Delete a switch port schedule
		/// </remarks>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="portScheduleId"></param>
		/// <returns>Task of void</returns>
		[Delete("/networks/{networkId}/switch/portSchedules/{portScheduleId}")]
		Task DeleteNetworkSwitchPortSchedule(
			[AliasAs("networkId")] string networkId,
			[AliasAs("portScheduleId")] string portScheduleId
			);

		/// <summary>
		/// getNetworkSwitchPortSchedules
		/// </summary>
		/// <remarks>
		/// List switch port schedules
		/// </remarks>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <returns>A list of switch port schedules</returns>
		[Get("/networks/{networkId}/switch/portSchedules")]
		Task<List<SwitchPortSchedule>> GetNetworkSwitchPortSchedules(
			[AliasAs("networkId")] string networkId
			);

		/// <summary>
		/// updateNetworkSwitchPortSchedule
		/// </summary>
		/// <remarks>
		/// Update a switch port schedule
		/// </remarks>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="portScheduleId"></param>
		/// <param name="updateNetworkSwitchPortSchedule"> (optional)</param>
		/// <returns>Task of Object</returns>
		[Put("/networks/{networkId}/switch/portSchedules/{portScheduleId}")]
		Task<SwitchPortSchedule> UpdateNetworkSwitchPortSchedule(
			[AliasAs("networkId")] string networkId,
			[AliasAs("portScheduleId")] string portScheduleId,
			[Body] SwitchPortScheduleCreationRequest updateNetworkSwitchPortSchedule
			);
	}
}
