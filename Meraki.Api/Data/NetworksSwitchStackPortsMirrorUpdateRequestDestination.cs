namespace Meraki.Api.Data;

/// <summary>
/// Destination port Details
/// </summary>
[DataContract]
public class NetworksSwitchStackPortsMirrorUpdateRequestDestination
{
	/// <summary>
	/// Transit or destination vlan only for RSPAN
	/// </summary>
	[DataMember(Name = "vlan")]
	public string? Vlan { get; set; }

	/// <summary>
	/// Port specific details
	/// </summary>
	[DataMember(Name = "port")]
	public NetworksSwitchStackPortsMirrorUpdateRequestDestinationPort? Port { get; set; }
}
