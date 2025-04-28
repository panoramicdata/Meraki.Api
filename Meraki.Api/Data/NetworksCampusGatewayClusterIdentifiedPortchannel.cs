namespace Meraki.Api.Data;

/// <summary>
/// Port channel settings for the cluster.
/// </summary>
public class NetworksCampusGatewayClusterIdentifiedPortchannel
{
	/// <summary>
	/// VLAN Id of the port channel
	/// </summary>
	[DataMember(Name = "vlan")]
	public int? VLan { get; set; }

	/// <summary>
	/// Allowed VLANs of the port channel
	/// </summary>
	[DataMember(Name = "allowedVlans")]
	public string? AllowedVlans { get; set; }

	/// <summary>
	/// ID of the port channel
	/// </summary>
	[DataMember(Name = "id")]
	public string? Id { get; set; }

	/// <summary>
	/// Name of the port channel
	/// </summary>
	[DataMember(Name = "name")]
	public string? Name { get; set; }
}