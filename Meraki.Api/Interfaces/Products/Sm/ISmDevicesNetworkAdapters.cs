﻿namespace Meraki.Api.Interfaces.Products.Sm;

public interface ISmDevicesNetworkAdapters
{
	/// <summary>
	/// List the network adapters of a device
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="deviceId">The device id</param>
	/// <param name="cancellationToken"></param>
	[Get("/networks/{networkId}/sm/devices/{deviceId}/networkAdapters")]
	Task<List<NetworkAdapter>> GetNetworkSmDeviceNetworkAdaptersAsync(
		string networkId,
		string deviceId,
		CancellationToken cancellationToken = default
		);
}
