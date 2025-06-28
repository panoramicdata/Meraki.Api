namespace Meraki.Api.Data;

/// <summary>
/// Port channel setting of the cluster
/// </summary>
[DataContract]
public class OrganizationCampusGatewayClusterPortChannel
{
	/// <summary>
	/// VLAN ID of the port channel
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "vlan")]
	public int Vlan { get; set; }

	/// <summary>
	/// Allowed VLANs of the port channel
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "allowedVlans")]
	public string AllowedVlans { get; set; } = string.Empty;

	/// <summary>
	/// ID of the port channel
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "id")]
	public string Id { get; set; } = string.Empty;

	/// <summary>
	/// Name of the port channel
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;
}