using Meraki.Api.Data;
using Refit;
using System.Threading.Tasks;

namespace Meraki.Api.Interfaces
{
	/// <summary>
	/// Represents a collection of functions to interact with the API endpoints
	/// </summary>
	public interface ISwitchStacks
	{
		/// <summary>
		/// addNetworkSwitchStack
		/// </summary>
		/// <remarks>
		/// Add a switch to a stack
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <param name="switchStackId"></param>
		/// <param name="addNetworkSwitchStack"></param>
		/// <returns>Task of Object</returns>
		[Post("/networks/{networkId}/switchStacks/{switchStackId}/add")]
		Task<object> AddNetworkSwitchStack(
			[AliasAs("networkId")]string networkId,
			[AliasAs("switchStackId")]string switchStackId,
			[Body]NetworkSwitchStackCreationRequest addNetworkSwitchStack
			);

		/// <summary>
		/// createNetworkSwitchStack
		/// </summary>
		/// <remarks>
		/// Create a stack
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <param name="createNetworkSwitchStack"></param>
		/// <returns>Task of Object</returns>
		[Post("/networks/{networkId}/switchStacks")]
		Task<object> CreateNetworkSwitchStack(
			[AliasAs("networkId")]string networkId,
			[Body]SwitchStackCreationRequest createNetworkSwitchStack
			);

		/// <summary>
		/// deleteNetworkSwitchStack
		/// </summary>
		/// <remarks>
		/// Delete a stack
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <param name="switchStackId"></param>
		/// <returns>Task of void</returns>
		[Delete("/networks/{networkId}/switchStacks/{switchStackId}")]
		Task DeleteNetworkSwitchStack(
			[AliasAs("networkId")]string networkId,
			[AliasAs("switchStackId")]string switchStackId
			);

		/// <summary>
		/// getNetworkSwitchStack
		/// </summary>
		/// <remarks>
		/// Show a switch stack
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <param name="switchStackId"></param>
		/// <returns>Task of Object</returns>
		[Get("/networks/{networkId}/switchStacks/{switchStackId}")]
		Task<object> GetNetworkSwitchStack(
			[AliasAs("networkId")]string networkId,
			[AliasAs("switchStackId")]string switchStackId
			);

		/// <summary>
		/// getNetworkSwitchStacks
		/// </summary>
		/// <remarks>
		/// List the switch stacks in a network
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <returns>Task of Object</returns>
		[Get("/networks/{networkId}/switchStacks")]
		Task<object> GetNetworkSwitchStacks(
			[AliasAs("networkId")]string networkId
			);

		/// <summary>
		/// removeNetworkSwitchStack
		/// </summary>
		/// <remarks>
		/// Remove a switch from a stack
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <param name="switchStackId"></param>
		/// <param name="removeNetworkSwitchStack"></param>
		/// <returns>Task of Object</returns>
		[Post("/networks/{networkId}/switchStacks/{switchStackId}/remove")]
		Task<object> RemoveNetworkSwitchStack(
			[AliasAs("networkId")]string networkId,
			[AliasAs("switchStackId")]string switchStackId,
			[Body]RemoveNetworkSwitchStack removeNetworkSwitchStack
			);
	}
}
