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
	Task<DevicesWirelessRadioAfcPositionResponse> GetDeviceWirelessRadioAfcPositionAsync(
		string serial,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Update the position attributes for this device
	/// </summary>
	/// <param name="serial">The serial</param>
	/// <param name="request">Information for updating</param>
	/// <param name="cancellationToken">Cancellation Token</param>
	/// <returns></returns>
	[Put("/devices/{serial}/wireless/radio/afc/position")]
	Task<DevicesWirelessRadioAfcPositionResponse>
		UpdateDeviceWirelessRadioAfcPositionAsync(
			string serial,
			[Body] DevicesWirelessRadioAfcPositionPutRequest request,
			CancellationToken cancellationToken = default
		);
}
