namespace Meraki.Api.Data;

/// <summary>
/// Result of an ACL hit count request
/// </summary>
[DataContract]
public class LiveToolsAclHitCountGetResponseAcl
{
	/// <summary>
	/// IP Version for the rule, or "any"
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "ipVersion")]
	public IpVersion IpVersion { get; set; }

	/// <summary>
	/// Action to be taken on packets matching the rule
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "policy")]
	public AclPolicy Policy { get; set; }

	/// <summary>
	/// Number of packets matched by this ACL
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "counts")]
	public LiveToolsAclHitCountGetResponseAclCounts Counts { get; set; } = new();

	/// <summary>
	/// Destination address and port configuration for the rule
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "destination")]
	public LiveToolsAclHitCountGetResponseAclDestination Destination { get; set; } = new();

	/// <summary>
	/// IP Protocol for the rule. This allows the ACL to filter on specific protocols, such as TCP
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "ipProtocol")]
	public LiveToolsAclHitCountGetResponseAclIpProtocol IpProtocol { get; set; } = new();

	/// <summary>
	/// Source address and port configuration for the rule
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "source")]
	public LiveToolsAclHitCountGetResponseAclSource Source { get; set; } = new();
}
