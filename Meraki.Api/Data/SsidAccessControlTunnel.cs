namespace Meraki.Api.Data;

/// <summary>
/// SSID access control tunnel settings
/// </summary>
[DataContract]
public class SsidAccessControlTunnel
{
	/// <summary>
	/// Whether tunneling is enabled
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "enabled")]
	public bool? Enabled { get; set; }

	/// <summary>
	/// Summary of the tunnel status
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "summary")]
	public string? Summary { get; set; }
}
