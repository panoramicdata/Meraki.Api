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
	public string? NetworkId { get; set; }

	/// <summary>
	/// The VLAN that should be tagged for the concentrator.
	/// </summary>
	[ApiForeignKey(typeof(Vlan))]
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "vlanId")]
	public string? VlanId { get; set; }

	/// <summary>
	/// The concentrator name - cannot be set
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "name")]
	public string? Name { get; set; }
}