namespace Meraki.Api.Data;

/// <summary>
/// Sm profiles
/// </summary>
[DataContract]
public class SmProfile : NamedIdentifiedItem
{
	/// <summary>
	/// Description
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "description")]
	public string Desription { get; set; } = string.Empty;

	/// <summary>
	/// Scope
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "scope")]
	public string Scope { get; set; } = string.Empty;

	/// <summary>
	/// Tags
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "tags")]
	public List<string> Tags { get; set; } = [];

	/// <summary>
	/// TargetGroupId
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "targetGroupId")]
	public string? TargetGroupId { get; set; }
}
