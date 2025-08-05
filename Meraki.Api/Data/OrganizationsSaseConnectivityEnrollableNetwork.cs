namespace Meraki.Api.Data;

/// <summary>
/// Network
/// </summary>
[DataContract]
public class OrganizationsSaseConnectivityEnrollableNetwork
{
	/// <summary>
	/// Model of the network's primary MX device
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "model")]
	public string Model { get; set; } = string.Empty;

	/// <summary>
	/// Site name
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;

	/// <summary>
	/// Network ID, may not be unique in result set
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "networkId")]
	public string NetworkId { get; set; } = string.Empty;

	/// <summary>
	/// The site's type (one of: 'meraki_spoke', 'meraki_hub', 'meraki_template')
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "type")]
	public string Type { get; set; } = string.Empty;

	/// <summary>
	/// The address of the site
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "address")]
	public OrganizationsSaseConnectivityEnrollableNetworkAddress Address { get; set; } = new();

	/// <summary>
	/// The region to which the site is connected
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "region")]
	public OrganizationsSaseConnectivityEnrollableNetworkRegion Region { get; set; } = new();

	/// <summary>
	/// Routing configuration for the site
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "routing")]
	public OrganizationsSaseConnectivityEnrollableNetworkRouting Routing { get; set; } = new();

	/// <summary>
	/// VPN configuration for the site
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "vpn")]
	public OrganizationsSaseConnectivityEnrollableNetworkVpn Vpn { get; set; } = new();
}
