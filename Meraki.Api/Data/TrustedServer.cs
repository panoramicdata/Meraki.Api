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
	public string TrustedServerId { get; set; } = string.Empty;

	/// <summary>
	/// The mac address of the trusted server being added
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "mac")]
	public string Mac { get; set; } = string.Empty;

	/// <summary>
	/// The VLAN of the trusted server being added. It must be between 1 and 4094
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "vlan")]
	public int Vlan { get; set; }

	/// <summary>
	/// The IPv4 attributes of the trusted server being added
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "ipv4")]
	public TrustedServerIpv4? Ipv4 { get; set; }
}
