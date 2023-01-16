namespace Meraki.Api.Data;

/// <summary>
/// Vpn Bgp
/// </summary>
[DataContract]
public class VpnBgp
{
	/// <summary>
	/// Boolean value to enable or disable the BGP configuration. When BGP is enabled, the asNumber (ASN) will be auto-populated with the preconfigured ASN at other Hubs or a default value if there is no ASN configured.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "enabled")]
	public bool? Enabled { get; set; }

	/// <summary>
	/// An Autonomous System Number (ASN) is required if you are to run BGP and peer with another BGP Speaker outside of the Auto VPN domain. This ASN will be applied to the entire Auto VPN domain. The entire 4-byte ASN range is supported. So, the ASN must be an integer between 1 and 4294967295. When absent, this field is not updated. If no value exists then it defaults to 64512.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "asNumber")]
	public int? AsNumber { get; set; }

	/// <summary>
	/// The IBGP hold timer in seconds. The IBGP hold timer must be an integer between 12 and 240. When absent, this field is not updated. If no value exists then it defaults to 240.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "ibgpHoldTimer")]
	public int? IbgpHoldTimer { get; set; }

	/// <summary>
	/// List of BGP neighbors. This list replaces the existing set of neighbors. When absent, this field is not updated.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "neighbors")]
	public List<Neighbor>? Neighbors { get; set; } = new();
}
