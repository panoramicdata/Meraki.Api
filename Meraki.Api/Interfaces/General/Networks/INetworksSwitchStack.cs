namespace Meraki.Api.Interfaces.General.Networks;

public interface INetworksSwitchStack
{
	/// <summary>
	/// Update switch port mirrors for switch stacks
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId"></param>
	/// <param name="switchStackId"></param>
	/// <param name="request"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("updateNetworkSwitchStackPortsMirror")]
	[Put("/networks/{networkId}/switch/stacks/{switchStackId}/ports/mirror")]
	Task<NetworksSwitchStackPortsMirror> UpdateNetworkSwitchStackPortsMirrorAsync(
		string networkId,
		string switchStackId,
		[Body] NetworksSwitchStackPortsMirrorUpdateRequest request,
		CancellationToken cancellationToken = default
	);
}
