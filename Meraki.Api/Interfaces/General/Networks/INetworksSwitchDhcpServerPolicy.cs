namespace Meraki.Api.Interfaces.General.Networks;
/// <summary>
/// I Networks Switch Dhcp Server Policy
/// </summary>
public interface INetworksSwitchDhcpServerPolicy
{
	/// <summary>
	/// Return the devices that have a Dynamic ARP Inspection warning and their warnings
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("getNetworkSwitchDhcpServerPolicyArpInspectionWarningsByDevice")]
	[Get("/networks/{networkId}/switch/dhcpServerPolicy/arpInspection/warnings/byDevice")]
	Task<List<NetworksSwitchDhcpServerPolicyArpInspectionWarning>> GetNetworkSwitchDhcpServerPolicyArpInspectionWarningsByDeviceAsync(
		string networkId,
		CancellationToken cancellationToken = default
	);
}
