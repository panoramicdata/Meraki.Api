namespace Meraki.Api.Data;

/// <summary>
/// VPN settings for a VLAN - Undocumented, observed in live API responses only
/// </summary>
[DataContract]
public class VlanVpn
{
	/// <summary>
	/// VPN advertisement settings
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "advertisement")]
	public VlanVpnAdvertisement? Advertisement { get; set; }
}
