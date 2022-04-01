namespace Meraki.Api.Data;

/// <summary>
/// CreateNetworkSmTargetGroup
/// </summary>
[DataContract]
public class SmTargetGroupCreateUpdateRequest
{
	/// <summary>
	/// The name of this target group
	/// </summary>
	[ApiAccess(ApiAccess.CreateUpdate)]
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;

	/// <summary>
	/// The scope and tag options of the target group. Comma separated values beginning with one of withAny, withAll, withoutAny, withoutAll, all, none, followed by tags. Default to none if empty.
	/// </summary>
	[ApiAccess(ApiAccess.CreateUpdate)]
	[DataMember(Name = "scope")]
	public string Scope { get; set; } = string.Empty;
}
