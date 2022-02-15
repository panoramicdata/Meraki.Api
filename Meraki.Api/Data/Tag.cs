namespace Meraki.Api.Data;

/// <summary>
/// Tag
/// </summary>
[DataContract]
public class Tag
{
	/// <summary>
	/// The name of the tag
	/// </summary>
	/// <value>The name of the tag</value>
	[DataMember(Name = "tag")]
	public string TagText { get; set; } = string.Empty;

	/// <summary>
	/// The privilege of the dashboard administrator on the tag
	/// </summary>
	/// <value>The privilege of the dashboard administrator on the tag</value>
	[DataMember(Name = "access")]
	public AccessPrivilege Access { get; set; }
}
