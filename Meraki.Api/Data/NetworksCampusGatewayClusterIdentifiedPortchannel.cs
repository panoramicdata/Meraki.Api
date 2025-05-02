namespace Meraki.Api.Data;

/// <summary>
/// Port channel settings for the cluster.
/// </summary>
[DataContract]
public class NetworksCampusGatewayClusterIdentifiedPortchannel
{
	/// <summary>
	/// VLAN Id of the port channel
	/// </summary>
	[DataMember(Name = "vlan")]
	[ApiAccess(ApiAccess.Create)]
	public int? VLan { get; set; }

	/// <summary>
	/// Allowed VLANs of the port channel
	/// </summary>
	[DataMember(Name = "allowedVlans")]
	[ApiAccess(ApiAccess.Create)]
	public string? AllowedVlans { get; set; }

	/// <summary>
	/// ID of the port channel
	/// </summary>
	[DataMember(Name = "id")]
	[ApiAccess(ApiAccess.Create)]
	public string? Id { get; set; }

	/// <summary>
	/// Name of the port channel
	/// </summary>
	[DataMember(Name = "name")]
	[ApiAccess(ApiAccess.Create)]
	public string? Name { get; set; }
}