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
	/// Source port
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "srcPort")]
	public string SrcPort { get; set; } = string.Empty;

	/// <summary>
	/// Destination port
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "dstPort")]
	public string DstPort { get; set; } = string.Empty;

	/// <summary>
	/// If enabled, means TCP connection with this node must be established.
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "tcpEstablished")]
	public bool TcpEstablished { get; set; }

	/// <summary>
	/// If enabled, when this rule is hit an entry will be logged to the event log
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "log")]
	public bool Log { get; set; }
}
