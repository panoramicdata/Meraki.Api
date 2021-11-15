using System.Runtime.Serialization;

namespace Meraki.Api.Data;

/// <summary>
/// Event type
/// </summary>
[DataContract]
public class EventType
{
	/// <summary>
	/// Category
	/// </summary>
	[DataMember(Name = "category")]
	public string Category { get; set; } = string.Empty;

	/// <summary>
	/// Type
	/// </summary>
	[DataMember(Name = "type")]
	public string Type { get; set; } = string.Empty;

	/// <summary>
	/// Description
	/// </summary>
	[DataMember(Name = "description")]
	public string Description { get; set; } = string.Empty;
}
