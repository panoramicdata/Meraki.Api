namespace Meraki.Api.Data;

/// <summary>
/// SSID access control bandwidth settings
/// </summary>
[DataContract]
public class SsidAccessControlBandwidth
{
	/// <summary>
	/// The bandwidth limit
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "limit")]
	public string? Limit { get; set; }
}
