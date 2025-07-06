namespace Meraki.Api.Data;

/// <summary>
/// Number of packets matched by this ACL
/// </summary>
[DataContract]
public class LiveToolsAclHitCountGetResponseAclCounts
{
	/// <summary>
	/// Total number of matched IPv4 packets
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "ipv4")]
	public int Ipv4 { get; set; }

	/// <summary>
	/// Total number of matched IPv6 packets
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "ipv6")]
	public int Ipv6 { get; set; }

	/// <summary>
	/// Total number of matched packets across all IP versions
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "total")]
	public int Total { get; set; }
}