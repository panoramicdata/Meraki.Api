namespace Meraki.Api.Data;

/// <summary>
/// A network SSID
/// </summary>
[DataContract]
public class Ssid : SsidUpdateRequest
{
	/// <summary>
	/// number
	/// </summary>
	[ApiKey]
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "number")]
	public int Number { get; set; }

	/// <summary>
	/// ssidAdminAccessible
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "ssidAdminAccessible")]
	public bool SsidAdminAccessible { get; set; }

	/// <summary>
	/// adminSplashUrl
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "adminSplashUrl")]
	public string AdminSplashUrl { get; set; } = string.Empty;

	/// <summary>
	/// Access control settings for the SSID
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "accessControl")]
	public SsidAccessControl? AccessControl { get; set; }

	/// <summary>
	/// Security settings for the SSID
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "security")]
	public SsidSecurity? Security { get; set; }

	/// <summary>
	/// Campus gateway settings. Only present when ipAssignmentMode is 'Campus Gateway'.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "campusGateway")]
	public SsidCampusGateway? CampusGateway { get; set; }

	/// <summary>
	/// WLAN identifier for the SSID. Only present for Meraki admin users.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "wlanIdentifier")]
	public int? WlanIdentifier { get; set; }
}
