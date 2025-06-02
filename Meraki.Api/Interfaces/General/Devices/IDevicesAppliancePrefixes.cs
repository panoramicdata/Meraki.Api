namespace Meraki.Api.Interfaces.General.Devices;
public interface IDevicesAppliancePrefixes
{
	/// <summary>
	/// Return current delegated IPv6 prefixes on an appliance.
	/// </summary>
	/// <param name="serial"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("getDeviceAppliancePrefixesDelegated")]
	[Get("/devices/{serial}/appliance/prefixes/delegated")]
	Task<List<DeviceAppliancePrefixesDelegatedItem>> GetDeviceAppliancePrefixesDelegatedAsync(string serial, CancellationToken cancellationToken = default);
}
