﻿namespace Meraki.Api.Interfaces.Products.Sm;

public interface ISmDevicesRestrictions
{
	/// <summary>
	/// List the restrictions on a device
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="deviceId">The device id</param>
	/// <param name="cancellationToken"></param>
	[Get("/networks/{networkId}/sm/devices/{deviceId}/restrictions")]
	Task<List<SmDeviceRestrictions>> GetNetworkSmDeviceRestrictionsAsync(
		string networkId,
		string deviceId,
		CancellationToken cancellationToken = default
		);
}
