namespace Meraki.Api.Interfaces.General.Devices;
/// <summary>
/// I Devices Appliance Prefixes
/// </summary>
public interface IDevicesAppliancePrefixes
{
	/// <summary>
	/// Return current delegated IPv6 prefixes on an appliance.
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="serial"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("getDeviceAppliancePrefixesDelegated")]
	[Get("/devices/{serial}/appliance/prefixes/delegated")]
	Task<List<DeviceAppliancePrefixesDelegatedItem>> GetDeviceAppliancePrefixesDelegatedAsync(string serial, CancellationToken cancellationToken = default);

	/// <summary>
	/// Return prefixes assigned to all IPv6 enabled VLANs on an appliance.
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="serial"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("getDeviceAppliancePrefixesDelegatedVlanAssignments")]
	[Get("/devices/{serial}/appliance/prefixes/delegated/vlanAssignments")]
	Task<List<DeviceAppliancePrefixesDelegatedVlanAssignmentItem>> GetDeviceAppliancePrefixesDelegatedVlanAssignmentsAsync(string serial, CancellationToken cancellationToken = default);
}
