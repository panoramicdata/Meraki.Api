﻿namespace Meraki.Api.Extensions;

/// <summary>
/// Provides extension methods for managing switch ports on network devices.
/// </summary>
/// <remarks>This static class contains methods that extend the functionality of the <see cref="ISwitchPorts"/>
/// interface, allowing for operations such as updating port schedules on network switches.</remarks>
public static class ISwitchPortsExtensions
{
	/// <summary>
	/// Updates the port schedule ID for a specified switch port on a device.
	/// </summary>
	/// <remarks>This method allows you to update the schedule associated with a specific port on a network switch
	/// device. If <paramref name="portScheduleId"/> is null, any existing schedule will be removed from the
	/// port.</remarks>
	/// <param name="switchPorts">The interface for managing switch ports.</param>
	/// <param name="serial">The serial number of the device containing the switch port. Cannot be null or empty.</param>
	/// <param name="portId">The identifier of the switch port to update. Cannot be null or empty.</param>
	/// <param name="portScheduleId">The new port schedule ID to assign to the switch port. Can be null to remove the schedule.</param>
	/// <param name="cancellationToken">A token to monitor for cancellation requests.</param>
	/// <returns>A task representing the asynchronous operation, with a <see cref="SwitchPort"/> result containing the updated
	/// switch port details.</returns>
	public static Task<SwitchPort> UpdateDeviceSwitchPortSetPortScheduleIdAsync(
		this ISwitchPorts switchPorts,
		string serial,
		string portId,
		string? portScheduleId,
		CancellationToken cancellationToken = default
		)
		=> switchPorts.InternalUpdateDeviceSwitchPortSetPortScheduleIdAsync(
				serial,
				portId,
				new SwitchPortUpdatePortScheduleIdRequest
				{
					PortScheduleId = portScheduleId
				},
				cancellationToken
			);

	/// <summary>
	/// Updates the VLAN setting for a specified switch port on a device asynchronously.
	/// </summary>
	/// <remarks>This method allows you to change the VLAN configuration of a specific port on a network switch
	/// device. The operation is performed asynchronously and can be cancelled using the provided <paramref
	/// name="cancellationToken"/>.</remarks>
	/// <param name="switchPorts">The interface for managing switch ports.</param>
	/// <param name="serial">The serial number of the device containing the switch port.</param>
	/// <param name="portId">The identifier of the switch port to update.</param>
	/// <param name="vlan">The VLAN ID to set for the switch port. Can be null to remove the VLAN setting.</param>
	/// <param name="cancellationToken">A token to monitor for cancellation requests.</param>
	/// <returns>A task that represents the asynchronous operation. The task result contains the updated <see cref="SwitchPort"/>
	/// object.</returns>
	public static Task<SwitchPort> UpdateDeviceSwitchPortSetVlanAsync(
		this ISwitchPorts switchPorts,
		string serial,
		string portId,
		int? vlan,
		CancellationToken cancellationToken = default
		)
		=> switchPorts.InternalUpdateDeviceSwitchPortSetVlanAsync(
				serial,
				portId,
				new SwitchPortUpdateVlanRequest
				{
					Vlan = vlan
				},
				cancellationToken
			);
}
