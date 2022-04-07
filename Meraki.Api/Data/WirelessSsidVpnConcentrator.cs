namespace Meraki.Api.Data;

/// <summary>
/// The VPN concentrator settings for this SSID.
/// </summary>
[DataContract]
public class WirelessSsidVpnConcentrator
{
	/// <summary>
	/// The NAT ID of the concentrator that should be set.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "networkId")]
	public string NetworkId { get; set; } = string.Empty;

	/// <summary>
	/// The concentrator name - cannot be set
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "name")]
	public string? Name { get; set; }
}