namespace Meraki.Api.Data;

/// <summary>
/// Trusted Server Ipv4 Settings
/// </summary>
[DataContract]
public class TrustedServerIpv4
{
	/// <summary>
	/// The IPv4 address of the trusted server being added
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "address")]
	public string? address { get; set; }
}
