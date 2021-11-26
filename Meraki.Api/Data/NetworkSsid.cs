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
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "number")]
	public int Number { get; set; }

	/// <summary>
	/// The name of the SSID
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;

	/// <summary>
	/// enabled
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "enabled")]
	public bool Enabled { get; set; }

	/// <summary>
	/// splashPage
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "splashPage")]
	public string SplashPage { get; set; } = string.Empty;

	/// <summary>
	/// ssidAdminAccessible
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "ssidAdminAccessible")]
	public bool SsidAdminAccessible { get; set; }

	/// <summary>
	/// authMode
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "authMode")]
	public string AuthMode { get; set; } = string.Empty;

	/// <summary>
	/// encryptionMode
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "encryptionMode")]
	public string EncryptionMode { get; set; } = string.Empty;

	/// <summary>
	/// wpaEncryptionMode
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "wpaEncryptionMode")]
	public string WpaEncryptionMode { get; set; } = string.Empty;

	/// <summary>
	/// radiusServers
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "radiusServers")]
	public List<SsidRadiusServer> RadiusServers { get; set; } = new List<SsidRadiusServer>();

	/// <summary>
	/// radiusAccountingEnabled
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "radiusAccountingEnabled")]
	public bool RadiusAccountingEnabled { get; set; }

	/// <summary>
	/// radiusEnabled
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "radiusEnabled")]
	public bool RadiusEnabled { get; set; }

	/// <summary>
	/// radiusAttributeForGroupPolicies
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "radiusAttributeForGroupPolicies")]
	public string RadiusAttributeForGroupPolicies { get; set; } = string.Empty;

	/// <summary>
	/// radiusFailoverPolicy
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "radiusFailoverPolicy")]
	public string RadiusFailoverPolicy { get; set; } = string.Empty;

	/// <summary>
	/// radiusLoadBalancingPolicy
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "radiusLoadBalancingPolicy")]
	public string RadiusLoadBalancingPolicy { get; set; } = string.Empty;

	/// <summary>
	/// ipAssignmentMode
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "ipAssignmentMode")]
	public string IpAssignmentMode { get; set; } = string.Empty;

	/// <summary>
	/// adminSplashUrl
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "adminSplashUrl")]
	public string AdminSplashUrl { get; set; } = string.Empty;

	/// <summary>
	/// splashTimeout
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "splashTimeout")]
	public string SplashTimeout { get; set; } = string.Empty;

	/// <summary>
	/// walledGardenEnabled
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "walledGardenEnabled")]
	public bool WalledGardenEnabled { get; set; }

	/// <summary>
	/// walledGardenRanges
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "walledGardenRanges")]
	public string WalledGardenRanges { get; set; } = string.Empty;

	/// <summary>
	/// minBitrate
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "minBitrate")]
	public int? MinBitrate { get; set; }

	/// <summary>
	/// bandSelection
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "bandSelection")]
	public string BandSelection { get; set; } = string.Empty;

	/// <summary>
	/// perClientBandwidthLimitUp
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "perClientBandwidthLimitUp")]
	public int PerClientBandwidthLimitUp { get; set; }

	/// <summary>
	/// perClientBandwidthLimitDown
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "perClientBandwidthLimitDown")]
	public int PerClientBandwidthLimitDown { get; set; }
}
