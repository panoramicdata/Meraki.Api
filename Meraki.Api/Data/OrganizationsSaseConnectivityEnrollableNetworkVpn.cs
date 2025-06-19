namespace Meraki.Api.Data;

/// <summary>
/// VPN configuration for the site
/// </summary>
[DataContract]
public class OrganizationsSaseConnectivityEnrollableNetworkVpn
{
	/// <summary>
	/// The VPN type of the site
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "type")]
	public string Type { get; set; } = string.Empty;
}