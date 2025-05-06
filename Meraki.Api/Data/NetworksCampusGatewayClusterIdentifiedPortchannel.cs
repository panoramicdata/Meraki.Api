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
	[ApiAccess(ApiAccess.CreateUpdate)]
	public int? VLan { get; set; }

	/// <summary>
	/// Allowed VLANs of the port channel
	/// </summary>
	[DataMember(Name = "allowedVlans")]
	[ApiAccess(ApiAccess.CreateUpdate)]
	public string? AllowedVlans { get; set; }

	/// <summary>
	/// ID of the port channel
	/// </summary>
	[DataMember(Name = "id")]
	[ApiAccess(ApiAccess.CreateUpdate)]
	public string? Id { get; set; }

	/// <summary>
	/// Name of the port channel
	/// </summary>
	[DataMember(Name = "name")]
	[ApiAccess(ApiAccess.CreateUpdate)]
	public string? Name { get; set; }
}