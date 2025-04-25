namespace Meraki.Api.Interfaces.General.Devices;

public interface IDevicesWirelessRadioAfc
{
	/// <summary>
	/// Get the AFC position of a device
	/// </summary>
	/// <param name="serial">The serial</param>
	/// <param name="cancellationToken">Cancellation Token</param>
	/// <returns></returns>
	[Get("/devices/{serial}/wireless/radio/afc/position")]
	Task<DevicesWirelessRadioAfcPositionGetResponse> GetDeviceWirelessRadioAfcPositionAsync(
		string serial,
		CancellationToken cancellationToken = default
		);
}
