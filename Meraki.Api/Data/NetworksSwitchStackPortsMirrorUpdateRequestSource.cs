namespace Meraki.Api.Data;

/// <summary>
/// Source port details
/// </summary>
[DataContract]
public class NetworksSwitchStackPortsMirrorUpdateRequestSource
{
	/// <summary>
	/// Source Port filter traffic based on vlans
	/// </summary>
	[DataMember(Name = "filter")]
	public NetworksSwitchStackPortsMirrorUpdateRequestSourceFilter? Filter { get; set; }

	/// <summary>
	/// Port specific details
	/// </summary>
	[DataMember(Name = "ports")]
	public List<NetworksSwitchStackPortsMirrorUpdateRequestSourcePort>? Ports { get; set; }
}
