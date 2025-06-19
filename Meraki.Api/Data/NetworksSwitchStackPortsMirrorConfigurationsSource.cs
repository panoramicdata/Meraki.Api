namespace Meraki.Api.Data;

/// <summary>
/// Source port mirror configuration
/// </summary>
[DataContract]
public class NetworksSwitchStackPortsMirrorConfigurationsSource
{
	/// <summary>
	/// Source Port filter traffic based on vlans
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "filter")]
	public NetworksSwitchStackPortsMirrorConfigurationsSourceFilter Filter { get; set; } = new();

	/// <summary>
	/// Source Port specific configuraion
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "ports")]
	public List<NetworksSwitchStackPortsMirrorConfigurationsSourcePort> Ports { get; set; } = [];
}
