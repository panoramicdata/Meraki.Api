namespace Meraki.Api.Data;

/// <summary>
/// SSID access control client IP assignment settings
/// </summary>
[DataContract]
public class SsidAccessControlClientIpAssignment
{
	/// <summary>
	/// The client IP assignment mode
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "mode")]
	public string? Mode { get; set; }
}
