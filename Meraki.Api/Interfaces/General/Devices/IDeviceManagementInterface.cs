namespace Meraki.Api.Interfaces.General.Devices;

public interface IDeviceManagementInterface
{
	/// <summary>
	/// Return the management interface settings for a device
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="serial">The serial number</param>
	[Get("/devices/{serial}/managementInterface")]
	Task<DeviceManagementInterfaceSettings> GetManagementInterfaceAsync(
		[AliasAs("serial")] string serial,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Update the management interface settings for a device
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="serial">The serial number</param>
	/// <param name="managementInterfaceSettingsUpdateDto">Body for updating management interface settings</param>
	[Put("/devices/{serial}/managementInterface")]
	Task<DeviceManagementInterfaceSettings> UpdateManagementInterfaceAsync(
		[AliasAs("serial")] string serial,
		[Body] DeviceManagementInterfaceSettings managementInterfaceSettingsUpdateDto,
		CancellationToken cancellationToken = default);
}
