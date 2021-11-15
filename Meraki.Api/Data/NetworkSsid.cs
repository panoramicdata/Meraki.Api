using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Meraki.Api.Data;

/// <summary>
/// A network SSID
/// </summary>
[DataContract]
public class NetworkSsid
{
	/// <summary>
	/// number
	/// </summary>
	[DataMember(Name = "number")]
	public int Number { get; set; }

	/// <summary>
	/// name
	/// </summary>
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;

	/// <summary>
	/// enabled
	/// </summary>
	[DataMember(Name = "enabled")]
	public bool Enabled { get; set; }

	/// <summary>
	/// splashPage
	/// </summary>
	[DataMember(Name = "splashPage")]
	public string SplashPage { get; set; } = string.Empty;

	/// <summary>
	/// ssidAdminAccessible
	/// </summary>
	[DataMember(Name = "ssidAdminAccessible")]
	public bool SsidAdminAccessible { get; set; }

	/// <summary>
	/// authMode
	/// </summary>
	[DataMember(Name = "authMode")]
	public string AuthMode { get; set; } = string.Empty;

	/// <summary>
	/// encryptionMode
	/// </summary>
	[DataMember(Name = "encryptionMode")]
	public string EncryptionMode { get; set; } = string.Empty;

	/// <summary>
	/// wpaEncryptionMode
	/// </summary>
	[DataMember(Name = "wpaEncryptionMode")]
	public string WpaEncryptionMode { get; set; } = string.Empty;

	/// <summary>
	/// radiusServers
	/// </summary>
	[DataMember(Name = "radiusServers")]
	public List<SsidRadiusServer> RadiusServers { get; set; } = new List<SsidRadiusServer>();

	/// <summary>
	/// radiusAccountingEnabled
	/// </summary>
	[DataMember(Name = "radiusAccountingEnabled")]
	public bool RadiusAccountingEnabled { get; set; }

	/// <summary>
	/// radiusEnabled
	/// </summary>
	[DataMember(Name = "radiusEnabled")]
	public bool RadiusEnabled { get; set; }

	/// <summary>
	/// radiusAttributeForGroupPolicies
	/// </summary>
	[DataMember(Name = "radiusAttributeForGroupPolicies")]
	public string RadiusAttributeForGroupPolicies { get; set; } = string.Empty;

	/// <summary>
	/// radiusFailoverPolicy
	/// </summary>
	[DataMember(Name = "radiusFailoverPolicy")]
	public string RadiusFailoverPolicy { get; set; } = string.Empty;

	/// <summary>
	/// radiusLoadBalancingPolicy
	/// </summary>
	[DataMember(Name = "radiusLoadBalancingPolicy")]
	public string RadiusLoadBalancingPolicy { get; set; } = string.Empty;

	/// <summary>
	/// ipAssignmentMode
	/// </summary>
	[DataMember(Name = "ipAssignmentMode")]
	public string IpAssignmentMode { get; set; } = string.Empty;

	/// <summary>
	/// adminSplashUrl
	/// </summary>
	[DataMember(Name = "adminSplashUrl")]
	public string AdminSplashUrl { get; set; } = string.Empty;

	/// <summary>
	/// splashTimeout
	/// </summary>
	[DataMember(Name = "splashTimeout")]
	public string SplashTimeout { get; set; } = string.Empty;

	/// <summary>
	/// walledGardenEnabled
	/// </summary>
	[DataMember(Name = "walledGardenEnabled")]
	public bool WalledGardenEnabled { get; set; }

	/// <summary>
	/// walledGardenRanges
	/// </summary>
	[DataMember(Name = "walledGardenRanges")]
	public string WalledGardenRanges { get; set; } = string.Empty;

	/// <summary>
	/// minBitrate
	/// </summary>
	[DataMember(Name = "minBitrate")]
	public int? MinBitrate { get; set; }

	/// <summary>
	/// bandSelection
	/// </summary>
	[DataMember(Name = "bandSelection")]
	public string BandSelection { get; set; } = string.Empty;

	/// <summary>
	/// perClientBandwidthLimitUp
	/// </summary>
	[DataMember(Name = "perClientBandwidthLimitUp")]
	public int PerClientBandwidthLimitUp { get; set; }

	/// <summary>
	/// perClientBandwidthLimitDown
	/// </summary>
	[DataMember(Name = "perClientBandwidthLimitDown")]
	public int PerClientBandwidthLimitDown { get; set; }
}
