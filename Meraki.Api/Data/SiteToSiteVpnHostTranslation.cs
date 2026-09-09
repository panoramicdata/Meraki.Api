namespace Meraki.Api.Data;

/// <summary>
/// A VPN host translation. Host translations are supported starting from MX firmware version 26.1.2
/// </summary>
[DataContract]
public class SiteToSiteVpnHostTranslation
{
	/// <summary>
	/// Name of the host translation
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "name")]
	public string? Name { get; set; }

	/// <summary>
	/// Configuration of the local address of the translated host.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "local")]
	public SiteToSiteVpnHostTranslationAddress? Local { get; set; }

	/// <summary>
	/// Configuration of the remote address of the translated host.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "remote")]
	public SiteToSiteVpnHostTranslationAddress? Remote { get; set; }
}
