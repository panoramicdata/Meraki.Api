namespace Meraki.Api.Data;

/// <summary>
/// Trusted Server Update Request
/// </summary>
[DataContract]
public class TrustedServerUpdateRequest
{
	/// <summary>
	/// Mac
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "mac")]
	public string? Mac { get; set; }

	/// <summary>
	/// Vlan
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "vlan")]
	public int? Vlan { get; set; }

	/// <summary>
	/// Ipv4
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "ipv4")]
	public TrustedServerIpv4? Ipv4 { get; set; }
}
