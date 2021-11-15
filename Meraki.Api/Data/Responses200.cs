namespace Meraki.Api.Data;

/// <summary>
/// 200
/// </summary>
[DataContract]
public class Responses200
{
	/// <summary>
	/// Description
	/// </summary>
	[DataMember(Name = "description")]
	public string Description { get; set; } = string.Empty;

	/// <summary>
	/// Examples
	/// </summary>
	[DataMember(Name = "examples")]
	public Examples Examples { get; set; } = new();
}
