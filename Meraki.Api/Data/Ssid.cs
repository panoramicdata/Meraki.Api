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
	/// Whether or not the SSID is enabled, this will always be true or false when retrieving an SSID,
	/// but can be set to null when updating an SSID using the SsidUpdateRequest to allow not setting the value.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "enabled")]
	public new bool Enabled { get; set; }
}
