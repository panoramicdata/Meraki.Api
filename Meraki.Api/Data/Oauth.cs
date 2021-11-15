namespace Meraki.Api.Data;

/// <summary>
/// The OAuth settings of this SSID. Only valid if splashPage is 'Google OAuth'.
/// </summary>
public class Oauth
{
	/// <summary>
	/// (Optional) The list of domains allowed access to the network.
	/// </summary>
	[DataMember(Name = "allowedDomains")]
	public List<string>? AllowedDomains { get; set; }
}
