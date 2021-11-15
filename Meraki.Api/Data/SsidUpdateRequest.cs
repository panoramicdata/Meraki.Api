using System.Collections.Generic;
using System.Runtime.Serialization;

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
	/// The passkey for the SSID. This param is only valid if the authMode is &#39;psk&#39;
	/// </summary>
	/// <value>The passkey for the SSID. This param is only valid if the authMode is &#39;psk&#39;</value>
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
	/// The RADIUS 802.1X servers to be used for authentication. This param is only valid if the authMode is &#39;open-with-radius&#39;, &#39;8021x-radius&#39; or &#39;ipsk-with-radius&#39;
	/// </summary>
	/// <value>The RADIUS 802.1X servers to be used for authentication. This param is only valid if the authMode is &#39;open-with-radius&#39;, &#39;8021x-radius&#39; or &#39;ipsk-with-radius&#39;</value>
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
	/// Whether or not RADIUS accounting is enabled. This param is only valid if the authMode is &#39;open-with-radius&#39;, &#39;8021x-radius&#39; or &#39;ipsk-with-radius&#39;
	/// </summary>
	/// <value>Whether or not RADIUS accounting is enabled. This param is only valid if the authMode is &#39;open-with-radius&#39;, &#39;8021x-radius&#39; or &#39;ipsk-with-radius&#39;</value>
	[DataMember(Name = "radiusAccountingEnabled")]
	public bool? RadiusAccountingEnabled { get; set; }

	/// <summary>
	/// The RADIUS accounting 802.1X servers to be used for authentication. This param is only valid if the authMode is &#39;open-with-radius&#39;, &#39;8021x-radius&#39; or &#39;ipsk-with-radius&#39; and radiusAccountingEnabled is &#39;true&#39;
	/// </summary>
	/// <value>The RADIUS accounting 802.1X servers to be used for authentication. This param is only valid if the authMode is &#39;open-with-radius&#39;, &#39;8021x-radius&#39; or &#39;ipsk-with-radius&#39; and radiusAccountingEnabled is &#39;true&#39;</value>
	[DataMember(Name = "radiusAccountingServers")]
	public List<RadiusAccountingServer> RadiusAccountingServers { get; set; } = new();

	/// <summary>
	/// Specify the RADIUS attribute used to look up group policies (&#39;Filter-Id&#39;, &#39;Reply-Message&#39;, &#39;Airespace-ACL-Name&#39; or &#39;Aruba-User-Role&#39;). Access points must receive this attribute in the RADIUS Access-Accept message
	/// </summary>
	/// <value>Specify the RADIUS attribute used to look up group policies (&#39;Filter-Id&#39;, &#39;Reply-Message&#39;, &#39;Airespace-ACL-Name&#39; or &#39;Aruba-User-Role&#39;). Access points must receive this attribute in the RADIUS Access-Accept message</value>
	[DataMember(Name = "radiusAttributeForGroupPolicies")]
	public string RadiusAttributeForGroupPolicies { get; set; } = string.Empty;

	/// <summary>
	/// The client IP assignment mode (&#39;NAT mode&#39;, &#39;Bridge mode&#39;, &#39;Layer 3 roaming&#39;, &#39;Layer 3 roaming with a concentrator&#39; or &#39;VPN&#39;)
	/// </summary>
	/// <value>The client IP assignment mode (&#39;NAT mode&#39;, &#39;Bridge mode&#39;, &#39;Layer 3 roaming&#39;, &#39;Layer 3 roaming with a concentrator&#39; or &#39;VPN&#39;)</value>
	[DataMember(Name = "ipAssignmentMode")]
	public string IpAssignmentMode { get; set; } = string.Empty;

	/// <summary>
	/// Whether or not traffic should be directed to use specific VLANs. This param is only valid if the ipAssignmentMode is &#39;Bridge mode&#39; or &#39;Layer 3 roaming&#39;
	/// </summary>
	/// <value>Whether or not traffic should be directed to use specific VLANs. This param is only valid if the ipAssignmentMode is &#39;Bridge mode&#39; or &#39;Layer 3 roaming&#39;</value>
	[DataMember(Name = "useVlanTagging")]
	public bool? UseVlanTagging { get; set; }

	/// <summary>
	/// The concentrator to use when the ipAssignmentMode is &#39;Layer 3 roaming with a concentrator&#39; or &#39;VPN&#39;.
	/// </summary>
	/// <value>The concentrator to use when the ipAssignmentMode is &#39;Layer 3 roaming with a concentrator&#39; or &#39;VPN&#39;.</value>
	[DataMember(Name = "concentratorNetworkId")]
	public string ConcentratorNetworkId { get; set; } = string.Empty;

	/// <summary>
	/// The VLAN ID used for VLAN tagging. This param is only valid when the ipAssignmentMode is &#39;Layer 3 roaming with a concentrator&#39; or &#39;VPN&#39;
	/// </summary>
	/// <value>The VLAN ID used for VLAN tagging. This param is only valid when the ipAssignmentMode is &#39;Layer 3 roaming with a concentrator&#39; or &#39;VPN&#39;</value>
	[DataMember(Name = "vlanId")]
	public int? VlanId { get; set; }

	/// <summary>
	/// The default VLAN ID used for &#39;all other APs&#39;. This param is only valid when the ipAssignmentMode is &#39;Bridge mode&#39; or &#39;Layer 3 roaming&#39;
	/// </summary>
	/// <value>The default VLAN ID used for &#39;all other APs&#39;. This param is only valid when the ipAssignmentMode is &#39;Bridge mode&#39; or &#39;Layer 3 roaming&#39;</value>
	[DataMember(Name = "defaultVlanId")]
	public int? DefaultVlanId { get; set; }

	/// <summary>
	/// The list of tags and VLAN IDs used for VLAN tagging. This param is only valid when the ipAssignmentMode is &#39;Bridge mode&#39; or &#39;Layer 3 roaming&#39;
	/// </summary>
	/// <value>The list of tags and VLAN IDs used for VLAN tagging. This param is only valid when the ipAssignmentMode is &#39;Bridge mode&#39; or &#39;Layer 3 roaming&#39;</value>
	[DataMember(Name = "apTagsAndVlanIds")]
	public List<ApTagsAndVlanId> ApTagsAndVlanIds { get; set; } = new();

	/// <summary>
	/// Allow access to a configurable list of IP ranges, which users may access prior to sign-on.
	/// </summary>
	/// <value>Allow access to a configurable list of IP ranges, which users may access prior to sign-on.</value>
	[DataMember(Name = "walledGardenEnabled")]
	public bool? WalledGardenEnabled { get; set; }

	/// <summary>
	/// Specify your walled garden by entering space-separated addresses, ranges using CIDR notation, domain names, and domain wildcards (e.g. 192.168.1.1/24 192.168.37.10/32 www.yahoo.com *.google.com). Meraki&#39;s splash page is automatically included in your walled garden.
	/// </summary>
	/// <value>Specify your walled garden by entering space-separated addresses, ranges using CIDR notation, domain names, and domain wildcards (e.g. 192.168.1.1/24 192.168.37.10/32 www.yahoo.com *.google.com). Meraki&#39;s splash page is automatically included in your walled garden.</value>
	[DataMember(Name = "walledGardenRanges")]
	public string WalledGardenRanges { get; set; } = string.Empty;

	/// <summary>
	/// If true, the RADIUS response can override VLAN tag. This is not valid when ipAssignmentMode is &#39;NAT mode&#39;.
	/// </summary>
	/// <value>If true, the RADIUS response can override VLAN tag. This is not valid when ipAssignmentMode is &#39;NAT mode&#39;.</value>
	[DataMember(Name = "radiusOverride")]
	public bool? RadiusOverride { get; set; }

	/// <summary>
	/// The minimum bitrate in Mbps. (&#39;1&#39;, &#39;2&#39;, &#39;5.5&#39;, &#39;6&#39;, &#39;9&#39;, &#39;11&#39;, &#39;12&#39;, &#39;18&#39;, &#39;24&#39;, &#39;36&#39;, &#39;48&#39; or &#39;54&#39;)
	/// </summary>
	/// <value>The minimum bitrate in Mbps. (&#39;1&#39;, &#39;2&#39;, &#39;5.5&#39;, &#39;6&#39;, &#39;9&#39;, &#39;11&#39;, &#39;12&#39;, &#39;18&#39;, &#39;24&#39;, &#39;36&#39;, &#39;48&#39; or &#39;54&#39;)</value>
	[DataMember(Name = "minBitrate")]
	public double? MinBitrate { get; set; }

	/// <summary>
	/// The client-serving radio frequencies. (&#39;Dual band operation&#39;, &#39;5 GHz band only&#39; or &#39;Dual band operation with Band Steering&#39;)
	/// </summary>
	/// <value>The client-serving radio frequencies. (&#39;Dual band operation&#39;, &#39;5 GHz band only&#39; or &#39;Dual band operation with Band Steering&#39;)</value>
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
	/// Boolean indicating whether Layer 2 LAN isolation should be enabled or disabled. Only configurable when ipAssignmentMode is &#39;Bridge mode&#39;.
	/// </summary>
	/// <value>Boolean indicating whether Layer 2 LAN isolation should be enabled or disabled. Only configurable when ipAssignmentMode is &#39;Bridge mode&#39;.</value>
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
