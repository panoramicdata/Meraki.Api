using System.Runtime.Serialization;

namespace Meraki.Api.Data;

/// <summary>
/// UpdateNetworkSmTargetGroup
/// </summary>
[DataContract]
public class SmTargetGroupUpdateRequest
{
	/// <summary>
	/// The name of this target group
	/// </summary>
	/// <value>The name of this target group</value>
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;
	/// <summary>
	/// The scope and tag options of the target group. Comma separated values beginning with one of withAny, withAll, withoutAny, withoutAll, all, none, followed by tags. Default to none if empty.
	/// </summary>
	/// <value>The scope and tag options of the target group. Comma separated values beginning with one of withAny, withAll, withoutAny, withoutAll, all, none, followed by tags. Default to none if empty.</value>
	[DataMember(Name = "scope")]
	public string Scope { get; set; } = string.Empty;
}
