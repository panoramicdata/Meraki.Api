namespace Meraki.Api.Data;

/// <summary>
/// Access policy
/// </summary>
[DataContract]
public class AccessPolicy
{
	/// <summary>
	/// Access policy number
	/// </summary>
	[ApiKey]
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "accessPolicyNumber")]
	public string? AccessPolicyNumber { get; set; }

	/// <summary>
	/// Name of the access policy
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "name")]
	public string? Name { get; set; }

	/// <summary>
	/// List of RADIUS servers to require connecting devices to authenticate against before granting network access
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "radiusServers")]
	public List<RadiusServer>? RadiusServers { get; set; }

	/// <summary>
	/// Object for RADIUS Settings
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "radius")]
	public Radius? Radius { get; set; }

	/// <summary>
	/// If enabled, Meraki devices will periodically send access-request messages to these RADIUS servers
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "radiusTestingEnabled")]
	public bool? RadiusTestingEnabled { get; set; }

	/// <summary>
	/// Guest Port Bouncng - Undocumented
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "guestPortBouncing")]
	public bool? GuestPortBouncing { get; set; }

	/// <summary>
	/// Change of authentication for RADIUS re-authentication and disconnection
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "radiusCoaSupportEnabled")]
	public bool? RadiusCoaSupportEnabled { get; set; }

	/// <summary>
	/// Enable to send start, interim-update and stop messages to a configured RADIUS accounting server for tracking connected clients
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "radiusAccountingEnabled")]
	public bool? RadiusAccountingEnabled { get; set; }

	/// <summary>
	/// List of RADIUS accounting servers to require connecting devices to authenticate against before granting network access
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "radiusAccountingServers")]
	public List<RadiusServer>? RadiusAccountingServers { get; set; }

	/// <summary>
	/// Acceptable values are `""` for None, or `"11"` for Group Policies ACL
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "radiusGroupAttribute")]
	public string? RadiusGroupAttribute { get; set; }

	/// <summary>
	/// Choose the Host Mode for the access policy.
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "hostMode")]
	public string? HostMode { get; set; }

	/// <summary>
	/// Access Type of the policy.Automatically 'Hybrid authentication' when hostMode is 'Multi-Domain'.
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "accessPolicyType")]
	public string? AccessPolicyType { get; set; }

	/// <summary>
	/// Enabling this option will make switches execute 802.1X and MAC-bypass authentication simultaneously so that clients authenticate faster. Only required when accessPolicyType is 'Hybrid Authentication.
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "increaseAccessSpeed")]
	public bool? IncreaseAccessSpeed { get; set; }

	/// <summary>
	/// ID for the guest VLAN allow unauthorized devices access to limited network resources
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "guestVlanId")]
	public int? GuestVlanId { get; set; }

	/// <summary>
	/// CDP/LLDP capable voice clients will be able to use this VLAN. Automatically true when hostMode is 'Multi-Domain'.
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "voiceVlanClients")]
	public bool? VoiceVlanClients { get; set; }

	/// <summary>
	/// Enable to restrict access for clients to a specific set of IP addresses or hostnames prior to authentication
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "urlRedirectWalledGardenEnabled")]
	public bool? UrlRedirectWalledGardenEnabled { get; set; }

	/// <summary>
	/// IP address ranges, in CIDR notation, to restrict access for clients to a specific set of IP addresses or hostnames prior to authentication
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "urlRedirectWalledGardenRanges")]
	public List<string>? UrlRedirectWalledGardenRanges { get; set; }

	/// <summary>
	/// 802.1x Settings
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "dot1x")]
	public Dot1x? Dot1x { get; set; }

	/// <summary>
	/// Authentication Method - Undocumented, no responses other than null observed yet
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "authenticationMethod")]
	public object? AuthenticationMethod { get; set; }

	/// <summary>
	/// Counts
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "counts")]
	public AccessPolicyCounts? Counts { get; set; }
}
