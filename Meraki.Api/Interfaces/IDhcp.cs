using Meraki.Api.Data;
using Refit;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Meraki.Api.Interfaces
{
	public interface IDhcp
	{
		/// <summary>
		/// Return the DHCP subnet information for an appliance
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="serial">The serial number</param>
		[Get("/devices/{serial}/appliance/dhcp/subnets")]
		Task<List<DhcpSubnets>> GetDeviceApplianceDhcpSubnetsAsync(
			[AliasAs("serial")] string serial,
			CancellationToken cancellationToken = default
			);
	}
}
