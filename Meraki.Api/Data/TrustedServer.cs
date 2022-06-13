namespace Meraki.Api.Data;

/// <summary>
/// Trusted Server
/// </summary>
[DataContract]
public class TrustedServer
{
	/// <summary>
	/// Trusted Server ID
	/// </summary>
	[ApiKey]
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "trustedServerId")]
	public string TrustedServerId { get; set; } = null!;

	/// <summary>
	/// Mac
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "mac")]
	public string Mac { get; set; } = null!;

	/// <summary>
	/// Vlan
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "vlan")]
	public int Vlan { get; set; } = null!;

	/// <summary>
	/// Ipv4
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "ipv4")]
	public TrustedServerIpv4? Ipv4 { get; set; }
}
