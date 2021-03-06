using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// UpdateNetworkSsid
	/// </summary>
	[DataContract]
	public partial class SsidUpdateRequest
	{
		/// <summary>
		/// The name of the SSID
		/// </summary>
		/// <value>The name of the SSID</value>
		[DataMember(Name = "name", EmitDefaultValue = false)]
		public string Name { get; set; }

		/// <summary>
		/// Whether or not the SSID is enabled
		/// </summary>
		/// <value>Whether or not the SSID is enabled</value>
		[DataMember(Name = "enabled", EmitDefaultValue = false)]
		public bool? Enabled { get; set; }

		/// <summary>
		/// Gets or Sets AuthMode
		/// </summary>
		[DataMember(Name = "authMode", EmitDefaultValue = false)]
		public AuthMode AuthMode { get; set; }

		/// <summary>
		/// Gets or Sets EnterpriseAdminAccess
		/// </summary>
		[DataMember(Name = "enterpriseAdminAccess", EmitDefaultValue = false)]
		public EnterpriseAdminAccess EnterpriseAdminAccess { get; set; }

		/// <summary>
		/// Gets or Sets EncryptionMode
		/// </summary>
		[DataMember(Name = "encryptionMode", EmitDefaultValue = false)]
		public EncryptionMode EncryptionMode { get; set; }

		/// <summary>
		/// The passkey for the SSID. This param is only valid if the authMode is &#39;psk&#39;
		/// </summary>
		/// <value>The passkey for the SSID. This param is only valid if the authMode is &#39;psk&#39;</value>
		[DataMember(Name = "psk", EmitDefaultValue = false)]
		public string Psk { get; set; }

		/// <summary>
		/// Gets or Sets WpaEncryptionMode
		/// </summary>
		[DataMember(Name = "wpaEncryptionMode", EmitDefaultValue = false)]
		public WpaEncryptionMode WpaEncryptionMode { get; set; }

		/// <summary>
		/// Gets or Sets SplashPage
		/// </summary>
		[DataMember(Name = "splashPage", EmitDefaultValue = false)]
		public SplashPage SplashPage { get; set; }

		/// <summary>
		/// The RADIUS 802.1X servers to be used for authentication. This param is only valid if the authMode is &#39;open-with-radius&#39;, &#39;8021x-radius&#39; or &#39;ipsk-with-radius&#39;
		/// </summary>
		/// <value>The RADIUS 802.1X servers to be used for authentication. This param is only valid if the authMode is &#39;open-with-radius&#39;, &#39;8021x-radius&#39; or &#39;ipsk-with-radius&#39;</value>
		[DataMember(Name = "radiusServers", EmitDefaultValue = false)]
		public List<RadiusServer> RadiusServers { get; set; }

		/// <summary>
		/// If true, Meraki devices will act as a RADIUS Dynamic Authorization Server and will respond to RADIUS Change-of-Authorization and Disconnect messages sent by the RADIUS server.
		/// </summary>
		/// <value>If true, Meraki devices will act as a RADIUS Dynamic Authorization Server and will respond to RADIUS Change-of-Authorization and Disconnect messages sent by the RADIUS server.</value>
		[DataMember(Name = "radiusCoaEnabled", EmitDefaultValue = false)]
		public bool? RadiusCoaEnabled { get; set; }

		/// <summary>
		/// Gets or Sets RadiusFailoverPolicy
		/// </summary>
		[DataMember(Name = "radiusFailoverPolicy", EmitDefaultValue = false)]
		public RadiusFailoverPolicy RadiusFailoverPolicy { get; set; }

		/// <summary>
		/// Gets or Sets RadiusLoadBalancingPolicy
		/// </summary>
		[DataMember(Name = "radiusLoadBalancingPolicy", EmitDefaultValue = false)]
		public RadiusLoadBalancingPolicy RadiusLoadBalancingPolicy { get; set; }

		/// <summary>
		/// Whether or not RADIUS accounting is enabled. This param is only valid if the authMode is &#39;open-with-radius&#39;, &#39;8021x-radius&#39; or &#39;ipsk-with-radius&#39;
		/// </summary>
		/// <value>Whether or not RADIUS accounting is enabled. This param is only valid if the authMode is &#39;open-with-radius&#39;, &#39;8021x-radius&#39; or &#39;ipsk-with-radius&#39;</value>
		[DataMember(Name = "radiusAccountingEnabled", EmitDefaultValue = false)]
		public bool? RadiusAccountingEnabled { get; set; }

		/// <summary>
		/// The RADIUS accounting 802.1X servers to be used for authentication. This param is only valid if the authMode is &#39;open-with-radius&#39;, &#39;8021x-radius&#39; or &#39;ipsk-with-radius&#39; and radiusAccountingEnabled is &#39;true&#39;
		/// </summary>
		/// <value>The RADIUS accounting 802.1X servers to be used for authentication. This param is only valid if the authMode is &#39;open-with-radius&#39;, &#39;8021x-radius&#39; or &#39;ipsk-with-radius&#39; and radiusAccountingEnabled is &#39;true&#39;</value>
		[DataMember(Name = "radiusAccountingServers", EmitDefaultValue = false)]
		public List<RadiusAccountingServer> RadiusAccountingServers { get; set; }

		/// <summary>
		/// Specify the RADIUS attribute used to look up group policies (&#39;Filter-Id&#39;, &#39;Reply-Message&#39;, &#39;Airespace-ACL-Name&#39; or &#39;Aruba-User-Role&#39;). Access points must receive this attribute in the RADIUS Access-Accept message
		/// </summary>
		/// <value>Specify the RADIUS attribute used to look up group policies (&#39;Filter-Id&#39;, &#39;Reply-Message&#39;, &#39;Airespace-ACL-Name&#39; or &#39;Aruba-User-Role&#39;). Access points must receive this attribute in the RADIUS Access-Accept message</value>
		[DataMember(Name = "radiusAttributeForGroupPolicies", EmitDefaultValue = false)]
		public string RadiusAttributeForGroupPolicies { get; set; }

		/// <summary>
		/// The client IP assignment mode (&#39;NAT mode&#39;, &#39;Bridge mode&#39;, &#39;Layer 3 roaming&#39;, &#39;Layer 3 roaming with a concentrator&#39; or &#39;VPN&#39;)
		/// </summary>
		/// <value>The client IP assignment mode (&#39;NAT mode&#39;, &#39;Bridge mode&#39;, &#39;Layer 3 roaming&#39;, &#39;Layer 3 roaming with a concentrator&#39; or &#39;VPN&#39;)</value>
		[DataMember(Name = "ipAssignmentMode", EmitDefaultValue = false)]
		public string IpAssignmentMode { get; set; }

		/// <summary>
		/// Whether or not traffic should be directed to use specific VLANs. This param is only valid if the ipAssignmentMode is &#39;Bridge mode&#39; or &#39;Layer 3 roaming&#39;
		/// </summary>
		/// <value>Whether or not traffic should be directed to use specific VLANs. This param is only valid if the ipAssignmentMode is &#39;Bridge mode&#39; or &#39;Layer 3 roaming&#39;</value>
		[DataMember(Name = "useVlanTagging", EmitDefaultValue = false)]
		public bool? UseVlanTagging { get; set; }

		/// <summary>
		/// The concentrator to use when the ipAssignmentMode is &#39;Layer 3 roaming with a concentrator&#39; or &#39;VPN&#39;.
		/// </summary>
		/// <value>The concentrator to use when the ipAssignmentMode is &#39;Layer 3 roaming with a concentrator&#39; or &#39;VPN&#39;.</value>
		[DataMember(Name = "concentratorNetworkId", EmitDefaultValue = false)]
		public string ConcentratorNetworkId { get; set; }

		/// <summary>
		/// The VLAN ID used for VLAN tagging. This param is only valid when the ipAssignmentMode is &#39;Layer 3 roaming with a concentrator&#39; or &#39;VPN&#39;
		/// </summary>
		/// <value>The VLAN ID used for VLAN tagging. This param is only valid when the ipAssignmentMode is &#39;Layer 3 roaming with a concentrator&#39; or &#39;VPN&#39;</value>
		[DataMember(Name = "vlanId", EmitDefaultValue = false)]
		public int? VlanId { get; set; }

		/// <summary>
		/// The default VLAN ID used for &#39;all other APs&#39;. This param is only valid when the ipAssignmentMode is &#39;Bridge mode&#39; or &#39;Layer 3 roaming&#39;
		/// </summary>
		/// <value>The default VLAN ID used for &#39;all other APs&#39;. This param is only valid when the ipAssignmentMode is &#39;Bridge mode&#39; or &#39;Layer 3 roaming&#39;</value>
		[DataMember(Name = "defaultVlanId", EmitDefaultValue = false)]
		public int? DefaultVlanId { get; set; }

		/// <summary>
		/// The list of tags and VLAN IDs used for VLAN tagging. This param is only valid when the ipAssignmentMode is &#39;Bridge mode&#39; or &#39;Layer 3 roaming&#39;
		/// </summary>
		/// <value>The list of tags and VLAN IDs used for VLAN tagging. This param is only valid when the ipAssignmentMode is &#39;Bridge mode&#39; or &#39;Layer 3 roaming&#39;</value>
		[DataMember(Name = "apTagsAndVlanIds", EmitDefaultValue = false)]
		public List<ApTagsAndVlanId> ApTagsAndVlanIds { get; set; }

		/// <summary>
		/// Allow access to a configurable list of IP ranges, which users may access prior to sign-on.
		/// </summary>
		/// <value>Allow access to a configurable list of IP ranges, which users may access prior to sign-on.</value>
		[DataMember(Name = "walledGardenEnabled", EmitDefaultValue = false)]
		public bool? WalledGardenEnabled { get; set; }

		/// <summary>
		/// Specify your walled garden by entering space-separated addresses, ranges using CIDR notation, domain names, and domain wildcards (e.g. 192.168.1.1/24 192.168.37.10/32 www.yahoo.com *.google.com). Meraki&#39;s splash page is automatically included in your walled garden.
		/// </summary>
		/// <value>Specify your walled garden by entering space-separated addresses, ranges using CIDR notation, domain names, and domain wildcards (e.g. 192.168.1.1/24 192.168.37.10/32 www.yahoo.com *.google.com). Meraki&#39;s splash page is automatically included in your walled garden.</value>
		[DataMember(Name = "walledGardenRanges", EmitDefaultValue = false)]
		public string WalledGardenRanges { get; set; }

		/// <summary>
		/// If true, the RADIUS response can override VLAN tag. This is not valid when ipAssignmentMode is &#39;NAT mode&#39;.
		/// </summary>
		/// <value>If true, the RADIUS response can override VLAN tag. This is not valid when ipAssignmentMode is &#39;NAT mode&#39;.</value>
		[DataMember(Name = "radiusOverride", EmitDefaultValue = false)]
		public bool? RadiusOverride { get; set; }

		/// <summary>
		/// The minimum bitrate in Mbps. (&#39;1&#39;, &#39;2&#39;, &#39;5.5&#39;, &#39;6&#39;, &#39;9&#39;, &#39;11&#39;, &#39;12&#39;, &#39;18&#39;, &#39;24&#39;, &#39;36&#39;, &#39;48&#39; or &#39;54&#39;)
		/// </summary>
		/// <value>The minimum bitrate in Mbps. (&#39;1&#39;, &#39;2&#39;, &#39;5.5&#39;, &#39;6&#39;, &#39;9&#39;, &#39;11&#39;, &#39;12&#39;, &#39;18&#39;, &#39;24&#39;, &#39;36&#39;, &#39;48&#39; or &#39;54&#39;)</value>
		[DataMember(Name = "minBitrate", EmitDefaultValue = false)]
		public double? MinBitrate { get; set; }

		/// <summary>
		/// The client-serving radio frequencies. (&#39;Dual band operation&#39;, &#39;5 GHz band only&#39; or &#39;Dual band operation with Band Steering&#39;)
		/// </summary>
		/// <value>The client-serving radio frequencies. (&#39;Dual band operation&#39;, &#39;5 GHz band only&#39; or &#39;Dual band operation with Band Steering&#39;)</value>
		[DataMember(Name = "bandSelection", EmitDefaultValue = false)]
		public string BandSelection { get; set; }

		/// <summary>
		/// The upload bandwidth limit in Kbps. (0 represents no limit.)
		/// </summary>
		/// <value>The upload bandwidth limit in Kbps. (0 represents no limit.)</value>
		[DataMember(Name = "perClientBandwidthLimitUp", EmitDefaultValue = false)]
		public int? PerClientBandwidthLimitUp { get; set; }

		/// <summary>
		/// The download bandwidth limit in Kbps. (0 represents no limit.)
		/// </summary>
		/// <value>The download bandwidth limit in Kbps. (0 represents no limit.)</value>
		[DataMember(Name = "perClientBandwidthLimitDown", EmitDefaultValue = false)]
		public int? PerClientBandwidthLimitDown { get; set; }

		/// <summary>
		/// Boolean indicating whether Layer 2 LAN isolation should be enabled or disabled. Only configurable when ipAssignmentMode is &#39;Bridge mode&#39;.
		/// </summary>
		/// <value>Boolean indicating whether Layer 2 LAN isolation should be enabled or disabled. Only configurable when ipAssignmentMode is &#39;Bridge mode&#39;.</value>
		[DataMember(Name = "lanIsolationEnabled", EmitDefaultValue = false)]
		public bool? LanIsolationEnabled { get; set; }
	}
}
