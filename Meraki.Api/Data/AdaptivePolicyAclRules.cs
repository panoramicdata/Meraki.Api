using Meraki.Api.Attributes;
using System.Runtime.Serialization;

namespace Meraki.Api.Data;

/// <summary>
/// Rules
/// </summary>
[DataContract]
public class AdaptivePolicyAclRules
{
	/// <summary>
	/// Policy
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "policy")]
	public string Policy { get; set; } = string.Empty;

	/// <summary>
	/// Protocol
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "protocol")]
	public string Protocol { get; set; } = string.Empty;

	/// <summary>
	/// Src port
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "srcPort")]
	public string SrcPort { get; set; } = string.Empty;

	/// <summary>
	/// Dst port
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "dstPort")]
	public string DstPort { get; set; } = string.Empty;
}
