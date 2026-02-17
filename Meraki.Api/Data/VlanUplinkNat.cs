namespace Meraki.Api.Data;

/// <summary>
/// NAT settings for a VLAN uplink
/// </summary>
[DataContract]
public class VlanUplinkNat
{
	/// <summary>
	/// Whether NAT is enabled for this uplink
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "enabled")]
	public bool Enabled { get; set; }
}
