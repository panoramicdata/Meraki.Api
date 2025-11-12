namespace Meraki.Api.Interfaces.General.Devices;

/// <summary>
/// I Device Cellular Sims
/// </summary>
public interface IDeviceCellularSims
{
	/// <summary>
	/// Return the SIM and APN configurations for a cellular device.
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="serial">The serial number</param>
	/// <param name="cancellationToken"></param>
	[ApiOperationId("getDeviceCellularSims")]
	[Get("/devices/{serial}/cellular/sims")]
	Task<DeviceCellularSims> GetDeviceCellularSimsAsync(
		string serial,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Update the management interface settings for a device
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="serial">The serial number</param>
	/// <param name="deviceCellularSimsUpdateRequest">Body for updating</param>
	/// <param name="cancellationToken"></param>
	[ApiOperationId("updateDeviceCellularSims")]
	[Put("/devices/{serial}/cellular/sims")]
	Task<DeviceCellularSims> UpdateDeviceCellularSimsAsync(
		string serial,
		[Body] DeviceCellularSimsUpdateRequest deviceCellularSimsUpdateRequest,
		CancellationToken cancellationToken = default);
}
