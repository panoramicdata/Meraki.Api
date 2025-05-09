namespace Meraki.Api.Data;

/// <summary>
/// Port channel settings of the cluster
/// </summary>
[DataContract]
public class NetworksCampusGatewayClusterPortchannel
{
	/// <summary>
	/// VLAN ID of the port channel
	/// </summary>
	[DataMember(Name = "vlan")]
	public int VLan { get; set; }

	/// <summary>
	/// Allowed VLANs of the port channel
	/// </summary>
	[DataMember(Name = "allowedVlans")]
	public string AllowedVLans { get; set; } = string.Empty;

	/// <summary>
	/// Name of the port channel
	/// </summary>
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;
}