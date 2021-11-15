namespace Meraki.Api.Data;

/// <summary>
/// Rules
/// </summary>
[DataContract]
public class Rules
{
	/// <summary>
	/// Policy
	/// </summary>
	[DataMember(Name = "policy")]
	public string Policy { get; set; } = string.Empty;

	/// <summary>
	/// Type
	/// </summary>
	[DataMember(Name = "type")]
	public string Type { get; set; } = string.Empty;

	/// <summary>
	/// Value
	/// </summary>
	[DataMember(Name = "value")]
	public Value Value { get; set; } = new();
}
