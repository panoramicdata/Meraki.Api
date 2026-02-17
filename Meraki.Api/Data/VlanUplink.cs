namespace Meraki.Api.Data;

/// <summary>
/// VLAN uplink configuration
/// </summary>
[DataContract]
public class VlanUplink
{
	/// <summary>
	/// The physical WAN interface (e.g. 'wan1', 'wan2')
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "interface")]
	public string? Interface { get; set; }

	/// <summary>
	/// NAT settings for this uplink
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "nat")]
	public VlanUplinkNat? Nat { get; set; }
}
