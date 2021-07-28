using Meraki.Api.Data;
using Refit;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Meraki.Api.Interfaces
{
	public interface IDhcp
	{
		/// <summary>
		/// getDeviceApplianceDhcpSubnets
		/// </summary>
		/// <remarks>
		/// Return the DHCP subnet information for an appliance
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="serial"></param>
		/// <returns>Task of Object</returns>
		[Get("/devices/{serial}/appliance/dhcp/subnets")]
		Task<List<DhcpSubnets>> GetDeviceApplianceDhcpSubnets(
			[AliasAs("serial")] string serial
			);
	}
}
