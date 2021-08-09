using Meraki.Api.Data;
using Refit;
using System.Threading.Tasks;

namespace Meraki.Api.Interfaces
{
	/// <summary>
	/// Represents a collection of functions to interact with the API endpoints
	/// </summary>
	public interface IFirewalledServices
	{
		/// <summary>
		/// getNetworkFirewalledServices
		/// </summary>
		/// <remarks>
		/// List the appliance services and their accessibility rules
		/// </remarks>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <returns>Task of Object</returns>
		[Get("/networks/{networkId}/appliance/firewall/firewalledServices")]
		Task<object> GetNetworkFirewalledServices(
			[AliasAs("networkId")]string networkId
			);
	}
}
