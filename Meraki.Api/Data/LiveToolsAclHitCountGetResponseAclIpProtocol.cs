namespace Meraki.Api.Data;

/// <summary>
/// IP Protocol for the rule. This allows the ACL to filter on specific protocols, such as TCP
/// </summary>
[DataContract]
public class LiveToolsAclHitCountGetResponseAclIpProtocol
{
	/// <summary>
	/// IP Protocol Number for the rule, if the type is "number". <para>See <a href='https://www.iana.org/assignments/protocol-numbers/protocol-numbers.txt.'></a></para>
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "number")]
	public int Number { get; set; }

	/// <summary>
	/// The object group for this protocol rule, if the type is "objectGroup"
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "objectGroup")]
	public string ObjectGroup { get; set; } = string.Empty;

	/// <summary>
	/// The type of protocol rule for this ACL
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "type")]
	public ProtocolRuleType Type { get; set; }
}
