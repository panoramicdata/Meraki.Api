namespace Meraki.Api.Data;

/// <summary>
/// UpdateNetworkSsid
/// </summary>
[DataContract]
public class SsidUpdateRequest
{
	/// <summary>
	/// The default VLAN ID used for 'all other APs'. This param is only valid when the ipAssignmentMode is 'Bridge mode' or 'Layer 3 roaming'
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "defaultVlanId")]
	public int? DefaultVlanId { get; set; }

	/// <summary>
	/// The upload bandwidth limit in Kbps. (0 represents no limit.)
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "perClientBandwidthLimitUp")]
	public int? PerClientBandwidthLimitUp { get; set; }

	/// <summary>
	/// The download bandwidth limit in Kbps. (0 represents no limit.)
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "perClientBandwidthLimitDown")]
	public int? PerClientBandwidthLimitDown { get; set; }

	/// <summary>
	/// The total upload bandwidth limit in Kbps. (0 represents no limit.)
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "perSsidBandwidthLimitUp")]
	public int? PerSsidBandwidthLimitUp { get; set; }

	/// <summary>
	/// The total download bandwidth limit in Kbps. (0 represents no limit.)
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "perSsidBandwidthLimitDown")]
	public int? PerSsidBandwidthLimitDown { get; set; }

	/// <summary>
	/// The interval (in seconds) in which accounting information is updated and sent to the RADIUS accounting server
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "radiusAccountingInterimInterval")]
	public int? RadiusAccountingInterimInterval { get; set; }

	/// <summary>
	/// VLAN ID of the RADIUS Guest VLAN. This param is only valid if the authMode is 'open-with-radius' and addressing mode is not set to 'isolated' or 'nat' mode
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "radiusGuestVlanId")]
	public int? RadiusGuestVlanId { get; set; }

	/// <summary>
	/// The maximum number of transmit attempts after which a RADIUS server is failed over (must be between 1-5).
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "radiusServerAttemptsLimit")]
	public int? RadiusServerAttemptsLimit { get; set; }

	/// <summary>
	/// The amount of time for which a RADIUS client waits for a reply from the RADIUS server (must be between 1-10 seconds).
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "radiusServerTimeout")]
	public int? RadiusServerTimeout { get; set; }

	/// <summary>
	/// The VLAN ID used for VLAN tagging. This param is only valid when the ipAssignmentMode is 'Layer 3 roaming with a concentrator' or 'VPN'
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "vlanId")]
	public int? VlanId { get; set; }

	/// <summary>
	/// Adaptive policy group ID this SSID is assigned to.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "adaptivePolicyGroupId")]
	public string? AdaptivePolicyGroupId { get; set; }

	/// <summary>
	/// The association control method for the SSID ('open', 'psk', 'open-with-radius', '8021x-meraki', '8021x-radius', '8021x-google', '8021x-localradius', 'ipsk-with-radius' or 'ipsk-without-radius')
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "authMode")]
	public AuthMode? AuthMode { get; set; }

	/// <summary>
	/// The client-serving radio frequencies of this SSID in the default indoor RF profile. ('Dual band operation', '5 GHz band only' or 'Dual band operation with Band Steering')
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "bandSelection")]
	public string? BandSelection { get; set; }

	/// <summary>
	/// The concentrator to use when the ipAssignmentMode is 'Layer 3 roaming with a concentrator' or 'VPN'.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "concentratorNetworkId")]
	public string? ConcentratorNetworkId { get; set; }

	/// <summary>
	/// The psk encryption mode for the SSID ('wep' or 'wpa'). This param is only valid if the authMode is 'psk'
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "encryptionMode")]
	public EncryptionMode? EncryptionMode { get; set; }

	/// <summary>
	/// Whether or not an SSID is accessible by 'enterprise' administrators ('access disabled' or 'access enabled')
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "enterpriseAdminAccess")]
	public EnterpriseAdminAccess? EnterpriseAdminAccess { get; set; }

	/// <summary>
	/// The client IP assignment mode('NAT mode', 'Bridge mode', 'Layer 3 roaming', 'Layer 3 roaming with a concentrator' or 'VPN')
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "ipAssignmentMode")]
	public string? IpAssignmentMode { get; set; }

	/// <summary>
	/// The name of the SSID
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "name")]
	public string? Name { get; set; } = string.Empty;

	/// <summary>
	/// The passkey for the SSID. This param is only valid if the authMode is 'psk'
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "psk")]
	public string? Psk { get; set; }

	/// <summary>
	/// Specify the RADIUS attribute used to look up group policies ('Filter-Id', 'Reply-Message', 'Airespace-ACL-Name' or 'Aruba-User-Role'). Access points must receive this attribute in the RADIUS Access-Accept message
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "radiusAttributeForGroupPolicies")]
	public string? RadiusAttributeForGroupPolicies { get; set; }

	/// <summary>
	/// The template of the NAS identifier to be used for RADIUS authentication (ex. $NODE_MAC$:$VAP_NUM$).
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "radiusAuthenticationNasId")]
	public string? RadiusAuthenticationNasId { get; set; }

	/// <summary>
	/// The template of the called station identifier to be used for RADIUS (ex. $NODE_MAC$:$VAP_NUM$).
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "radiusCalledStationId")]
	public string? RadiusCalledStationId { get; set; }

	/// <summary>
	/// This policy determines how authentication requests should be handled in the event that all of the configured RADIUS servers are unreachable ('Deny access' or 'Allow access')
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "radiusFailoverPolicy")]
	public RadiusFailoverPolicy? RadiusFailoverPolicy { get; set; }

	/// <summary>
	/// This policy determines which RADIUS server will be contacted first in an authentication attempt and the ordering of any necessary retry attempts ('Strict priority order' or 'Round robin')
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "radiusLoadBalancingPolicy")]
	public RadiusLoadBalancingPolicy? RadiusLoadBalancingPolicy { get; set; }

	/// <summary>
	/// The secondary concentrator to use when the ipAssignmentMode is 'VPN'. If configured, the APs will switch to using this concentrator if the primary concentrator is unreachable. This param is optional. ('disabled' represents no secondary concentrator.)
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "secondaryConcentratorNetworkId")]
	public string? SecondaryConcentratorNetworkId { get; set; }

	/// <summary>
	/// The type of splash page for the SSID ('None', 'Click-through splash page', 'Billing', 'Password-protected with Meraki RADIUS', 'Password-protected with custom RADIUS', 'Password-protected with Active Directory', 'Password-protected with LDAP', 'SMS authentication', 'Systems Manager Sentry', 'Facebook Wi-Fi', 'Google OAuth', 'Sponsored guest', 'Cisco ISE' or 'Google Apps domain'). This attribute is not supported for template children.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "splashPage")]
	public SplashPage? SplashPage { get; set; }

	/// <summary>
	/// The types of WPA encryption. ('WPA1 only', 'WPA1 and WPA2', 'WPA2 only', 'WPA3 Transition Mode' or 'WPA3 only')
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "wpaEncryptionMode")]
	public WpaEncryptionMode? WpaEncryptionMode { get; set; }

	/// <summary>
	/// Boolean indicating whether or not adult content will be blocked
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "adultContentFilteringEnabled")]
	public bool? AdultContentFilteringEnabled { get; set; }

	/// <summary>
	/// Boolean indicating whether all APs should broadcast the SSID or if it should be restricted to APs matching any availability tags. Can only be false if the SSID has availability tags
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "availableOnAllAps")]
	public bool? AvailableOnAllAps { get; set; }

	/// <summary>
	/// Disassociate clients when 'VPN' concentrator failover occurs in order to trigger clients to re-associate and generate new DHCP requests. This param is only valid if ipAssignmentMode is 'VPN'.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "disassociateClientsOnVpnFailover")]
	public bool? DisassociateClientsOnVpnFailover { get; set; }

	/// <summary>
	/// Whether or not the SSID is enabled
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "enabled")]
	public bool? Enabled { get; set; }

	/// <summary>
	/// Boolean indicating whether Layer 2 LAN isolation should be enabled or disabled. Only configurable when ipAssignmentMode is 'Bridge mode'.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "lanIsolationEnabled")]
	public bool? LanIsolationEnabled { get; set; }

	/// <summary>
	/// If true, Mandatory DHCP will enforce that clients connecting to this SSID must use the IP address assigned by the DHCP server. Clients who use a static IP address won't be able to associate.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "mandatoryDhcpEnabled")]
	public bool? MandatoryDhcpEnabled { get; set; }

	/// <summary>
	/// Whether or not RADIUS accounting is enabled. This param is only valid if the authMode is 'open-with-radius', '8021x-radius' or 'ipsk-with-radius'
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "radiusAccountingEnabled")]
	public bool? RadiusAccountingEnabled { get; set; }

	/// <summary>
	/// If true, Meraki devices will act as a RADIUS Dynamic Authorization Server and will respond to RADIUS Change-of-Authorization and Disconnect messages sent by the RADIUS server.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "radiusCoaEnabled")]
	public bool? RadiusCoaEnabled { get; set; }

	/// <summary>
	/// Whether or not higher priority RADIUS servers should be retried after 60 seconds.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "radiusFallbackEnabled")]
	public bool? RadiusFallbackEnabled { get; set; }

	/// <summary>
	/// radiusRadsecTlsIdleTimeout - undocumented
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "radiusRadsecTlsIdleTimeout")]
	public int? RadiusRadsecTlsIdleTimeout { get; set; }

	/// <summary>
	/// The current settings for RADIUS RADSec
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "radiusRadsec")]
	public SsidUpdateRequestRadiusRadsec? RadiusRadsec { get; set; }

	/// <summary>
	/// Whether or not RADIUS Guest VLAN is enabled. This param is only valid if the authMode is 'open-with-radius' and addressing mode is not set to 'isolated' or 'nat' mode
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "radiusGuestVlanEnabled")]
	public bool? RadiusGuestVlanEnabled { get; set; }

	/// <summary>
	/// If true, the RADIUS response can override VLAN tag. This is not valid when ipAssignmentMode is 'NAT mode'.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "radiusOverride")]
	public bool? RadiusOverride { get; set; }

	/// <summary>
	/// If true, Meraki devices will proxy RADIUS messages through the Meraki cloud to the configured RADIUS auth and accounting servers.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "radiusProxyEnabled")]
	public bool? RadiusProxyEnabled { get; set; }

	/// <summary>
	/// If true, Meraki devices will periodically send Access-Request messages to configured RADIUS servers using identity 'meraki_8021x_test' to ensure that the RADIUS servers are reachable.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "radiusTestingEnabled")]
	public bool? RadiusTestingEnabled { get; set; }

	/// <summary>
	/// Whether or not traffic should be directed to use specific VLANs. This param is only valid if the ipAssignmentMode is 'Bridge mode' or 'Layer 3 roaming'
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "useVlanTagging")]
	public bool? UseVlanTagging { get; set; }

	/// <summary>
	/// Boolean indicating whether APs should advertise or hide this SSID. APs will only broadcast this SSID if set to true
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "visible")]
	public bool? Visible { get; set; }

	/// <summary>
	/// Allow access to a configurable list of IP ranges, which users may access prior to sign-on.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "walledGardenEnabled")]
	public bool? WalledGardenEnabled { get; set; }

	/// <summary>
	/// The minimum bitrate in Mbps of this SSID in the default indoor RF profile. ('1', '2', '5.5', '6', '9', '11', '12', '18', '24', '36', '48' or '54')
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "minBitrate")]
	public double? MinBitrate { get; set; }

	/// <summary>
	/// Accepts a list of tags for this SSID. If availableOnAllAps is false, then the SSID will only be broadcast by APs with tags matching any of the tags in this list.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "availabilityTags")]
	public List<string>? AvailabilityTags { get; set; } = [];

	/// <summary>
	/// Array of valid sponsor email domains for sponsored guest splash type.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "splashGuestSponsorDomains")]
	public List<string>? SplashGuestSponsorDomains { get; set; }

	/// <summary>
	/// Specify your walled garden by entering an array of addresses, ranges using CIDR notation, domain names, and domain wildcards (e.g. '192.168.1.1/24', '192.168.37.10/32', 'www.yahoo.com', '*.google.com']). Meraki's splash page is automatically included in your walled garden.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "walledGardenRanges")]
	public List<string>? WalledGardenRanges { get; set; }

	/// <summary>
	/// Accepts a list of tags for this SSID. If availableOnAllAps is false, then the SSID will only be broadcast by APs with tags matching any of the tags in this list.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "activeDirectory")]
	public ActiveDirectory? ActiveDirectory { get; set; }

	/// <summary>
	/// DNS servers rewrite settings
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "dnsRewrite")]
	public DnsRewrite? DnsRewrite { get; set; }

	/// <summary>
	/// The current setting for Protected Management Frames (802.11w).
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "dot11w")]
	public Dot11w? Dot11w { get; set; }

	/// <summary>
	/// The current setting for 802.11r
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "dot11r")]
	public Dot11r? Dot11r { get; set; }

	/// <summary>
	/// Ethernet over GRE settings
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "gre")]
	public Gre? Gre { get; set; }

	/// <summary>
	/// The current setting for LDAP. Only valid if splashPage is 'Password-protected with LDAP'.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "ldap")]
	public Ldap? Ldap { get; set; }

	/// <summary>
	/// The current setting for Local Authentication, a built-in RADIUS server on the access point. Only valid if authMode is '8021x-localradius'.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "localRadius")]
	public LocalRadius? LocalRadius { get; set; }

	/// <summary>
	/// The OAuth settings of this SSID. Only valid if splashPage is 'Google OAuth'.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "oauth")]
	public Oauth? Oauth { get; set; }

	/// <summary>
	/// The list of tags and VLAN IDs used for VLAN tagging. This param is only valid when the ipAssignmentMode is 'Bridge mode' or 'Layer 3 roaming'
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "apTagsAndVlanIds")]
	public List<ApTagsAndVlanId>? ApTagsAndVlanIds { get; set; }

	/// <summary>
	/// The RADIUS accounting 802.1X servers to be used for authentication. This param is only valid if the authMode is 'open-with-radius', '8021x-radius' or 'ipsk-with-radius' and radiusAccountingEnabled is 'true'
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "radiusAccountingServers")]
	public List<RadiusAccountingServer>? RadiusAccountingServers { get; set; }

	/// <summary>
	/// The RADIUS 802.1X servers to be used for authentication. This param is only valid if the authMode is 'open-with-radius', '8021x-radius' or 'ipsk-with-radius'
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "radiusServers")]
	public List<SsidRadiusServer>? RadiusServers { get; set; }

	/// <summary>
	/// radiusEnabled
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "radiusEnabled")]
	public bool? RadiusEnabled { get; set; }

	/// <summary>
	/// splashTimeout
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "splashTimeout")]
	public string? SplashTimeout { get; set; }

	/// <summary>
	/// speedBurst settings
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "speedBurst")]
	public SpeedBurst? SpeedBurst { get; set; }

	/// <summary>
	/// localAuth
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "localAuth")]
	public bool? LocalAuth { get; set; }

	/// <summary>
	/// Named VLAN settings
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "namedVlans")]
	public SsidNamedVlans? NamedVlans { get; set; }

	/// <summary>
	/// Undocumented
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "wifiPersonalNetworkEnabled")]
	public object? WifiPersonalNetworkEnabled { get; set; }

	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "radiusDataCarrierDetect")]
	public SsidRadiusDataCarrierDetect? RadiusDataCarrierDetect { get; set; }
}
