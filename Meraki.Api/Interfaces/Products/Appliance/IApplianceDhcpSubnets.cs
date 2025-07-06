﻿namespace Meraki.Api.Interfaces.Products.Appliance;

public interface IApplianceDhcpSubnets
{
	/// <summary>
	/// Return the DHCP subnet information for an appliance
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="serial">The serial number</param>
	/// <param name="cancellationToken"></param>
	[Get("/devices/{serial}/appliance/dhcp/subnets")]
	Task<List<DhcpSubnets>> GetDeviceApplianceDhcpSubnetsAsync(
		string serial,
		CancellationToken cancellationToken = default
		);
}
