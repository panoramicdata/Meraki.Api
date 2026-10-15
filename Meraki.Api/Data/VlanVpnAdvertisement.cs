namespace Meraki.Api.Data;

/// <summary>
/// VPN advertisement settings for a VLAN - Undocumented, observed in live API responses only
/// </summary>
[DataContract]
public class VlanVpnAdvertisement
{
	/// <summary>
	/// Whether the VLAN is advertised over VPN
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "enabled")]
	public bool? Enabled { get; set; }
}
