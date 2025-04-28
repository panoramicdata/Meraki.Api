namespace Meraki.Api.Data;

/// <summary>
/// SmRebootResponse
/// </summary>
public class SmRebootResponse
{
	/// <summary>
	/// The Meraki Ids of the set of endpoints
	/// </summary>
	[DataMember(Name = "ids")]
	public List<string>? Ids { get; set; }
}
