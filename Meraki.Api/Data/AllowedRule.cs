namespace Meraki.Api.Data;

/// <summary>
/// WhitelistedRule
/// </summary>
[DataContract]
public class AllowedRule
{
	/// <summary>
	/// A rule identifier of the format meraki:intrusion/snort/GID/<gid>/SID/<sid>. gid and sid can be obtained from either https://www.snort.org/rule-docs or as ruleIds from the security events in /organization/[orgId]/securityEvents
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "ruleId")]
	public string RuleId { get; set; } = string.Empty;

	/// <summary>
	/// Message is optional and is ignored on a PUT call. It is allowed in order for PUT to be compatible with GET
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "message")]
	public string Message { get; set; } = string.Empty;
}
