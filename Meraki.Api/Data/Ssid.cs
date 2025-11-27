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
}
