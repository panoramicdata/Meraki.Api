namespace Meraki.Api.Data;

/// <summary>
/// Trusted Server Ipv4 Settings
/// </summary>
[DataContract]
public class TrustedServerIpv4
{
	/// <summary>
	/// Ipv4 Address
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "address")]
	public string? address { get; set; }
}
