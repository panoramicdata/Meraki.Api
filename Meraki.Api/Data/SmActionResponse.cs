namespace Meraki.Api.Data;

/// <summary>
/// SmActionResponse
/// </summary>
public class SmActionResponse
{
	/// <summary>
	/// The Meraki Ids of the set of endpoints
	/// </summary>
	[DataMember(Name = "ids")]
	public List<string>? Ids { get; set; }
}
