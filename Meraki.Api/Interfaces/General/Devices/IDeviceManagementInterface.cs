namespace Meraki.Api.Interfaces.General.Devices;

public interface IDeviceManagementInterface
{
	/// <summary>
	/// Return the management interface settings for a device
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="serial">The serial number</param>
	[ApiOperationId("getDeviceManagementInterface")]
	[Get("/devices/{serial}/managementInterface")]
	Task<DeviceManagementInterfaceSettings> GetDeviceManagementInterfaceAsync(
		[AliasAs("serial")] string serial,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Update the management interface settings for a device
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="serial">The serial number</param>
	/// <param name="managementInterfaceSettingsUpdateDto">Body for updating management interface settings</param>
	[ApiOperationId("updateDeviceManagementInterface")]
	[Put("/devices/{serial}/managementInterface")]
	Task<DeviceManagementInterfaceSettings> UpdateDeviceManagementInterfaceAsync(
		[AliasAs("serial")] string serial,
		[Body] DeviceManagementInterfaceSettings managementInterfaceSettingsUpdateDto,
		CancellationToken cancellationToken = default);
}
