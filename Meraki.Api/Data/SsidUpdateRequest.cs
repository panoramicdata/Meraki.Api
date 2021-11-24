namespace Meraki.Api.Data;

/// <summary>
/// UpdateNetworkSsid
/// </summary>
[DataContract]
public class SsidUpdateRequest
{
	/// <summary>
	/// The name of the SSID
	/// </summary>
	/// <value>The name of the SSID</value>
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;

	/// <summary>
	/// Whether or not the SSID is enabled
	/// </summary>
	/// <value>Whether or not the SSID is enabled</value>
	[DataMember(Name = "enabled")]
	public bool? Enabled { get; set; }

	/// <summary>
	/// Gets or Sets AuthMode
	/// </summary>
	[DataMember(Name = "authMode")]
	public AuthMode AuthMode { get; set; }

	/// <summary>
	/// Gets or Sets EnterpriseAdminAccess
	/// </summary>
	[DataMember(Name = "enterpriseAdminAccess")]
	public EnterpriseAdminAccess EnterpriseAdminAccess { get; set; }

	/// <summary>
	/// Gets or Sets EncryptionMode
	/// </summary>
	[DataMember(Name = "encryptionMode")]
	public EncryptionMode EncryptionMode { get; set; }

	/// <summary>
	/// The passkey for the SSID. This param is only valid if the authMode is 'psk'
	/// </summary>
	/// <value>The passkey for the SSID. This param is only valid if the authMode is 'psk'</value>
	[DataMember(Name = "psk")]
	public string Psk { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets WpaEncryptionMode
	/// </summary>
	[DataMember(Name = "wpaEncryptionMode")]
	public WpaEncryptionMode WpaEncryptionMode { get; set; }

	/// <summary>
	/// Gets or Sets SplashPage
	/// </summary>
	[DataMember(Name = "splashPage")]
	public SplashPage SplashPage { get; set; }

	/// <summary>
	/// The RADIUS 802.1X servers to be used for authentication. This param is only valid if the authMode is 'open-with-radius', '8021x-radius' or 'ipsk-with-radius'
	/// </summary>
	/// <value>The RADIUS 802.1X servers to be used for authentication. This param is only valid if the authMode is 'open-with-radius', '8021x-radius' or 'ipsk-with-radius'</value>
	[DataMember(Name = "radiusServers")]
	public List<SsidRadiusServer> RadiusServers { get; set; } = new();

	/// <summary>
	/// If true, Meraki devices will act as a RADIUS Dynamic Authorization Server and will respond to RADIUS Change-of-Authorization and Disconnect messages sent by the RADIUS server.
	/// </summary>
	/// <value>If true, Meraki devices will act as a RADIUS Dynamic Authorization Server and will respond to RADIUS Change-of-Authorization and Disconnect messages sent by the RADIUS server.</value>
	[DataMember(Name = "radiusCoaEnabled")]
	public bool? RadiusCoaEnabled { get; set; }

	/// <summary>
	/// Gets or Sets RadiusFailoverPolicy
	/// </summary>
	[DataMember(Name = "radiusFailoverPolicy")]
	public RadiusFailoverPolicy RadiusFailoverPolicy { get; set; }

	/// <summary>
	/// Gets or Sets RadiusLoadBalancingPolicy
	/// </summary>
	[DataMember(Name = "radiusLoadBalancingPolicy")]
	public RadiusLoadBalancingPolicy RadiusLoadBalancingPolicy { get; set; }

	/// <summary>
	/// Whether or not RADIUS accounting is enabled. This param is only valid if the authMode is 'open-with-radius', '8021x-radius' or 'ipsk-with-radius'
	/// </summary>
	/// <value>Whether or not RADIUS accounting is enabled. This param is only valid if the authMode is 'open-with-radius', '8021x-radius' or 'ipsk-with-radius'</value>
	[DataMember(Name = "radiusAccountingEnabled")]
	public bool? RadiusAccountingEnabled { get; set; }

	/// <summary>
	/// The RADIUS accounting 802.1X servers to be used for authentication. This param is only valid if the authMode is 'open-with-radius', '8021x-radius' or 'ipsk-with-radius' and radiusAccountingEnabled is 'true'
	/// </summary>
	/// <value>The RADIUS accounting 802.1X servers to be used for authentication. This param is only valid if the authMode is 'open-with-radius', '8021x-radius' or 'ipsk-with-radius' and radiusAccountingEnabled is 'true'</value>
	[DataMember(Name = "radiusAccountingServers")]
	public List<RadiusAccountingServer> RadiusAccountingServers { get; set; } = new();

	/// <summary>
	/// Specify the RADIUS attribute used to look up group policies ('Filter-Id', 'Reply-Message', 'Airespace-ACL-Name' or 'Aruba-User-Role'). Access points must receive this attribute in the RADIUS Access-Accept message
	/// </summary>
	/// <value>Specify the RADIUS attribute used to look up group policies ('Filter-Id', 'Reply-Message', 'Airespace-ACL-Name' or 'Aruba-User-Role'). Access points must receive this attribute in the RADIUS Access-Accept message</value>
	[DataMember(Name = "radiusAttributeForGroupPolicies")]
	public string RadiusAttributeForGroupPolicies { get; set; } = string.Empty;

	/// <summary>
	/// The client IP assignment mode ('NAT mode', 'Bridge mode', 'Layer 3 roaming', 'Layer 3 roaming with a concentrator' or 'VPN')
	/// </summary>
	/// <value>The client IP assignment mode ('NAT mode', 'Bridge mode', 'Layer 3 roaming', 'Layer 3 roaming with a concentrator' or 'VPN')</value>
	[DataMember(Name = "ipAssignmentMode")]
	public string IpAssignmentMode { get; set; } = string.Empty;

	/// <summary>
	/// Whether or not traffic should be directed to use specific VLANs. This param is only valid if the ipAssignmentMode is 'Bridge mode' or 'Layer 3 roaming'
	/// </summary>
	/// <value>Whether or not traffic should be directed to use specific VLANs. This param is only valid if the ipAssignmentMode is 'Bridge mode' or 'Layer 3 roaming'</value>
	[DataMember(Name = "useVlanTagging")]
	public bool? UseVlanTagging { get; set; }

	/// <summary>
	/// The concentrator to use when the ipAssignmentMode is 'Layer 3 roaming with a concentrator' or 'VPN'.
	/// </summary>
	/// <value>The concentrator to use when the ipAssignmentMode is 'Layer 3 roaming with a concentrator' or 'VPN'.</value>
	[DataMember(Name = "concentratorNetworkId")]
	public string ConcentratorNetworkId { get; set; } = string.Empty;

	/// <summary>
	/// The VLAN ID used for VLAN tagging. This param is only valid when the ipAssignmentMode is 'Layer 3 roaming with a concentrator' or 'VPN'
	/// </summary>
	/// <value>The VLAN ID used for VLAN tagging. This param is only valid when the ipAssignmentMode is 'Layer 3 roaming with a concentrator' or 'VPN'</value>
	[DataMember(Name = "vlanId")]
	public int? VlanId { get; set; }

	/// <summary>
	/// The default VLAN ID used for 'all other APs'. This param is only valid when the ipAssignmentMode is 'Bridge mode' or 'Layer 3 roaming'
	/// </summary>
	/// <value>The default VLAN ID used for 'all other APs'. This param is only valid when the ipAssignmentMode is 'Bridge mode' or 'Layer 3 roaming'</value>
	[DataMember(Name = "defaultVlanId")]
	public int? DefaultVlanId { get; set; }

	/// <summary>
	/// The list of tags and VLAN IDs used for VLAN tagging. This param is only valid when the ipAssignmentMode is 'Bridge mode' or 'Layer 3 roaming'
	/// </summary>
	/// <value>The list of tags and VLAN IDs used for VLAN tagging. This param is only valid when the ipAssignmentMode is 'Bridge mode' or 'Layer 3 roaming'</value>
	[DataMember(Name = "apTagsAndVlanIds")]
	public List<ApTagsAndVlanId> ApTagsAndVlanIds { get; set; } = new();

	/// <summary>
	/// Allow access to a configurable list of IP ranges, which users may access prior to sign-on.
	/// </summary>
	/// <value>Allow access to a configurable list of IP ranges, which users may access prior to sign-on.</value>
	[DataMember(Name = "walledGardenEnabled")]
	public bool? WalledGardenEnabled { get; set; }

	/// <summary>
	/// Specify your walled garden by entering space-separated addresses, ranges using CIDR notation, domain names, and domain wildcards (e.g. 192.168.1.1/24 192.168.37.10/32 www.yahoo.com *.google.com). Meraki's splash page is automatically included in your walled garden.
	/// </summary>
	/// <value>Specify your walled garden by entering space-separated addresses, ranges using CIDR notation, domain names, and domain wildcards (e.g. 192.168.1.1/24 192.168.37.10/32 www.yahoo.com *.google.com). Meraki's splash page is automatically included in your walled garden.</value>
	[DataMember(Name = "walledGardenRanges")]
	public string WalledGardenRanges { get; set; } = string.Empty;

	/// <summary>
	/// If true, the RADIUS response can override VLAN tag. This is not valid when ipAssignmentMode is 'NAT mode'.
	/// </summary>
	/// <value>If true, the RADIUS response can override VLAN tag. This is not valid when ipAssignmentMode is 'NAT mode'.</value>
	[DataMember(Name = "radiusOverride")]
	public bool? RadiusOverride { get; set; }

	/// <summary>
	/// The minimum bitrate in Mbps. ('1', '2', '5.5', '6', '9', '11', '12', '18', '24', '36', '48' or '54')
	/// </summary>
	/// <value>The minimum bitrate in Mbps. ('1', '2', '5.5', '6', '9', '11', '12', '18', '24', '36', '48' or '54')</value>
	[DataMember(Name = "minBitrate")]
	public double? MinBitrate { get; set; }

	/// <summary>
	/// The client-serving radio frequencies. ('Dual band operation', '5 GHz band only' or 'Dual band operation with Band Steering')
	/// </summary>
	/// <value>The client-serving radio frequencies. ('Dual band operation', '5 GHz band only' or 'Dual band operation with Band Steering')</value>
	[DataMember(Name = "bandSelection")]
	public string BandSelection { get; set; } = string.Empty;

	/// <summary>
	/// The upload bandwidth limit in Kbps. (0 represents no limit.)
	/// </summary>
	/// <value>The upload bandwidth limit in Kbps. (0 represents no limit.)</value>
	[DataMember(Name = "perClientBandwidthLimitUp")]
	public int? PerClientBandwidthLimitUp { get; set; }

	/// <summary>
	/// The download bandwidth limit in Kbps. (0 represents no limit.)
	/// </summary>
	/// <value>The download bandwidth limit in Kbps. (0 represents no limit.)</value>
	[DataMember(Name = "perClientBandwidthLimitDown")]
	public int? PerClientBandwidthLimitDown { get; set; }

	/// <summary>
	/// Boolean indicating whether Layer 2 LAN isolation should be enabled or disabled. Only configurable when ipAssignmentMode is 'Bridge mode'.
	/// </summary>
	/// <value>Boolean indicating whether Layer 2 LAN isolation should be enabled or disabled. Only configurable when ipAssignmentMode is 'Bridge mode'.</value>
	[DataMember(Name = "lanIsolationEnabled")]
	public bool? LanIsolationEnabled { get; set; }

	/// <summary>
	/// If true, Mandatory DHCP will enforce that clients connecting to this SSID must use the IP address assigned by the DHCP server. Clients who use a static IP address won't be able to associate.
	/// </summary>
	/// <value>If true, Mandatory DHCP will enforce that clients connecting to this SSID must use the IP address assigned by the DHCP server. Clients who use a static IP address won't be able to associate.</value>
	[DataMember(Name = "mandatoryDhcpEnabled")]
	public bool? MandatoryDhcpEnabled { get; set; }

	/// <summary>
	/// The current setting for Protected Management Frames (802.11w).
	/// </summary>
	[DataMember(Name = "dot11w")]
	public Dot11w? Dot11w { get; set; }

	/// <summary>
	/// The current setting for 802.11r
	/// </summary>
	[DataMember(Name = "dot11r")]
	public Dot11r? Dot11r { get; set; }

	/// <summary>
	/// Array of valid sponsor email domains for sponsored guest splash type.
	/// </summary>
	[DataMember(Name = "splashGuestSponsorDomains")]
	public List<string>? SplashGuestSponsorDomains { get; set; }

	/// <summary>
	/// The current setting for LDAP. Only valid if splashPage is 'Password-protected with LDAP'.
	/// </summary>
	[DataMember(Name = "ldap")]
	public Ldap? Ldap { get; set; }

	/// <summary>
	/// The current setting for Active Directory. Only valid if splashPage is 'Password-protected with Active Directory'
	/// </summary>
	[DataMember(Name = "activeDirectory")]

	public ActiveDirectory? ActiveDirectory { get; set; }

	/// <summary>
	/// If true, Meraki devices will periodically send Access-Request messages to configured RADIUS servers using identity 'meraki_8021x_test' to ensure that the RADIUS servers are reachable.
	/// </summary>
	[DataMember(Name = "radiusTestingEnabled")]
	public bool? RadiusTestingEnabled { get; set; }

	/// <summary>
	/// The template of the called station identifier to be used for RADIUS (ex. $NODE_MAC$:$VAP_NUM$).
	/// </summary>
	[DataMember(Name = "radiusCalledStationId")]
	public string? RadiusCalledStationId { get; set; }

	/// <summary>
	/// The template of the NAS identifier to be used for RADIUS authentication (ex. $NODE_MAC$:$VAP_NUM$).
	/// </summary>
	[DataMember(Name = "radiusAuthenticationNasId")]
	public string? RadiusAuthenticationNasId { get; set; }

	/// <summary>
	/// The amount of time for which a RADIUS client waits for a reply from the RADIUS server (must be between 1-10 seconds).
	/// </summary>
	[DataMember(Name = "radiusServerTimeout")]
	public int? RadiusServerTimeout { get; set; }

	/// <summary>
	/// The maximum number of transmit attempts after which a RADIUS server is failed over (must be between 1-5).
	/// </summary>
	[DataMember(Name = "radiusServerAttemptsLimit")]
	public int? RadiusServerAttemptsLimit { get; set; }

	/// <summary>
	/// Whether or not higher priority RADIUS servers should be retried after 60 seconds.
	/// </summary>
	[DataMember(Name = "radiusFallbackEnabled")]
	public bool? RadiusFallbackEnabled { get; set; }

	/// <summary>
	/// The interval (in seconds) in which accounting information is updated and sent to the RADIUS accounting server.
	/// </summary>
	[DataMember(Name = "radiusAccountingInterimInterval")]
	public int? RadiusAccountingInterimInterval { get; set; }

	/// <summary>
	/// The OAuth settings of this SSID. Only valid if splashPage is 'Google OAuth'.
	/// </summary>
	[DataMember(Name = "oauth")]
	public Oauth? Oauth { get; set; }

	/// <summary>
	/// The current setting for Local Authentication, a built-in RADIUS server on the access point. Only valid if authMode is '8021x-localradius'.
	/// </summary>
	[DataMember(Name = "localRadius")]
	public LocalRadius? LocalRadius { get; set; }

	/// <summary>
	/// Boolean indicating whether or not adult content will be blocked
	/// </summary>
	[DataMember(Name = "adultContentFilteringEnabled")]
	public bool? AdultContentFilteringEnabled { get; set; }

	/// <summary>
	/// DNS servers rewrite settings
	/// </summary>
	[DataMember(Name = "dnsRewrite")]
	public DnsRewrite? DnsRewrite { get; set; }
}
