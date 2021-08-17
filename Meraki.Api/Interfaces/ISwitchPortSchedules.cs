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
	public interface ISwitchPortSchedules
	{
		/// <summary>
		/// Add a switch port schedule
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="CreateNetworkSwitchPortSchedule"></param>
		[Post("/networks/{networkId}/switch/portSchedules")]
		Task<SwitchPortSchedule> CreateNetworkSwitchPortScheduleAsync(
			[AliasAs("networkId")] string networkId,
			[Body] SwitchPortScheduleCreationRequest CreateNetworkSwitchPortSchedule,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Delete a switch port schedule
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="portScheduleId">The port schedule id</param>
		[Delete("/networks/{networkId}/switch/portSchedules/{portScheduleId}")]
		Task DeleteNetworkSwitchPortScheduleAsync(
			[AliasAs("networkId")] string networkId,
			[AliasAs("portScheduleId")] string portScheduleId,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// List switch port schedules
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		[Get("/networks/{networkId}/switch/portSchedules")]
		Task<List<SwitchPortSchedule>> GetNetworkSwitchPortSchedulesAsync(
			[AliasAs("networkId")] string networkId,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Update a switch port schedule
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="portScheduleId">The port schedule id</param>
		/// <param name="UpdateNetworkSwitchPortSchedule"></param>
		[Put("/networks/{networkId}/switch/portSchedules/{portScheduleId}")]
		Task<SwitchPortSchedule> UpdateNetworkSwitchPortScheduleAsync(
			[AliasAs("networkId")] string networkId,
			[AliasAs("portScheduleId")] string portScheduleId,
			[Body] SwitchPortScheduleCreationRequest UpdateNetworkSwitchPortSchedule,
			CancellationToken cancellationToken = default
			);
	}
}
