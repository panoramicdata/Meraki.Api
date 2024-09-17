namespace Meraki.Api.Data;

/// <summary>
///  Esims Service Providers Item Logo
/// </summary>
[DataContract]
public class EsimsServiceProvidersItemLogo
{
	/// <summary>
	/// URL of service provider's logo.
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "logo")]
	public string? Logo { get; set; }

}
