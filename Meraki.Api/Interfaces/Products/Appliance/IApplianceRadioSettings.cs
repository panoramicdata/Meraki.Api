﻿namespace Meraki.Api.Interfaces.Products.Appliance;

public interface IApplianceRadioSettings
{
	/// <summary>
	/// Return the radio settings of an appliance
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="serial">The serial</param>
	/// <param name="cancellationToken"></param>
	[ApiOperationId("getDeviceApplianceRadioSettings")]
	[Get("/devices/{serial}/appliance/radio/settings")]
	Task<DeviceApplianceRadioSettings> GetDeviceApplianceRadioSettings(
		string serial,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Update the radio settings of an appliance
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="serial">Serial</param>
	/// <param name="deviceApplianceRadioSettingsUpdate">The radio settings update request</param>
	/// <param name="cancellationToken"></param>
	[ApiOperationId("updateDeviceApplianceRadioSettings")]
	[Put("/devices/{serial}/appliance/radio/settings")]
	Task<DeviceApplianceRadioSettings> UpdateDeviceApplianceRadioSettings(
		string serial,
		[Body] DeviceApplianceRadioSettingsUpdate deviceApplianceRadioSettingsUpdate,
		CancellationToken cancellationToken = default
		);
}
