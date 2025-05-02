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
	[ApiAccess(ApiAccess.Create)]
	public int VLan { get; set; }

	/// <summary>
	/// Allowed VLANs of the port channel
	/// </summary>
	[DataMember(Name = "allowedVlans")]
	[ApiAccess(ApiAccess.Create)]
	public string AllowedVLans { get; set; } = string.Empty;

	/// <summary>
	/// Name of the port channel
	/// </summary>
	[DataMember(Name = "name")]
	[ApiAccess(ApiAccess.Create)]
	public string Name { get; set; } = string.Empty;
}