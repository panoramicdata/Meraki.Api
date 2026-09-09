namespace Meraki.Api.Data;

/// <summary>
/// One side of a VPN host translation
/// </summary>
[DataContract]
public class SiteToSiteVpnHostTranslationAddress
{
	/// <summary>
	/// The IP address of the translated host on this side
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "address")]
	public string? Address { get; set; }
}
