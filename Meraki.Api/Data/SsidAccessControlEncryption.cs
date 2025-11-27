namespace Meraki.Api.Data;

/// <summary>
/// SSID access control encryption settings
/// </summary>
[DataContract]
public class SsidAccessControlEncryption
{
	/// <summary>
	/// The encryption mode
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "mode")]
	public string? Mode { get; set; }
}
