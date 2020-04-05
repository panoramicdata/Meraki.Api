using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// WhitelistedRule
	/// </summary>
	[DataContract]
	public partial class WhitelistedRule
	{
		/// <summary>
		/// A rule identifier of the format meraki:intrusion/snort/GID/&lt;gid&gt;/SID/&lt;sid&gt;. gid and sid can be obtained from either https://www.snort.org/rule-docs or as ruleIds from the security events in /organization/[orgId]/securityEvents
		/// </summary>
		/// <value>A rule identifier of the format meraki:intrusion/snort/GID/&lt;gid&gt;/SID/&lt;sid&gt;. gid and sid can be obtained from either https://www.snort.org/rule-docs or as ruleIds from the security events in /organization/[orgId]/securityEvents</value>
		[DataMember(Name = "ruleId", EmitDefaultValue = false)]
		public string RuleId { get; set; } = null!;

		/// <summary>
		/// Message is optional and is ignored on a PUT call. It is allowed in order for PUT to be compatible with GET
		/// </summary>
		/// <value>Message is optional and is ignored on a PUT call. It is allowed in order for PUT to be compatible with GET</value>
		[DataMember(Name = "message", EmitDefaultValue = false)]
		public string Message { get; set; } = null!;
	}
}
