namespace Meraki.Api.Interfaces.General.Devices;

public interface IDeviceWirelessAlternateManagementInterface
{
	/// <summary>
	/// Update alternate management interface IPv6 address
	/// </summary>
	/// <param name="serial">The serial</param>
	/// <param name="updateDeviceWirelessAlternateManagementInterfaceIpv6"></param>
	/// <param name="cancellationToken">Cancellation Token</param>
	/// <returns></returns>
	[Put("/devices/{serial}/wireless/alternateManagementInterface/ipv6")]
	Task<WirelessAlternateMangementInterfaceIpv6Data> UpdateDeviceWirelessAlternateManagementInterfaceIpv6Async(
		string serial,
		[Body] WirelessAlternateMangementInterfaceIpv6Data updateDeviceWirelessAlternateManagementInterfaceIpv6,
		CancellationToken cancellationToken = default
		);
}
