namespace Meraki.Api.Data;
public class SmTargetGroup : NamedItem
{
	/// <summary>
	/// The scope and tag options of the target group. Comma separated values beginning with one of withAny, withAll, withoutAny, withoutAll, all, none, followed by tags. Default to none if empty.
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "scope")]
	public string Scope { get; set; } = string.Empty;

	/// <summary>
	/// Tags
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "tags")]
	public List<string> Tags { get; set; } = new();

	/// <summary>
	/// Type
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "type")]
	public string Type { get; set; } = string.Empty;
}
