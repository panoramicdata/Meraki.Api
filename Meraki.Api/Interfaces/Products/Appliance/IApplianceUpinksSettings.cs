namespace Meraki.Api.Interfaces.Products.Appliance;

public interface IApplianceUplinksSettings
{
	/// <summary>
	/// Return the uplink settings for an MX appliance
	/// </summary>
	/// <param name="serial">The MX Device Sertial Number</param>
	/// <param name="cancellationToken"></param>
	[ApiOperationId("getDeviceApplianceUplinksSettings")]
	[Get("/devices/{serial}/appliance/uplinks/settings")]
	Task<DeviceApplianceUplinkSettings> GetDeviceApplianceUplinksSettingsAsync(
		string serial,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Update the uplink settings for an MX appliance
	/// </summary>
	/// <param name="serial">The MX Device Sertial Number</param>
	/// <param name="deviceApplianceUplinkSettingsUpdateRequest">Update request body</param>
	/// <param name="cancellationToken"></param>
	[ApiOperationId("updateDeviceApplianceUplinksSettings")]
	[Put("/devices/{serial}/appliance/uplinks/settings")]
	Task<DeviceApplianceUplinkSettings> UpdateDeviceApplianceUplinksSettingsAsync(
		string serial,
		[Body] DeviceApplianceUplinkSettingsUpdateRequest deviceApplianceUplinkSettingsUpdateRequest,
		CancellationToken cancellationToken = default);
}
