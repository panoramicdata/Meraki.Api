namespace Meraki.Api.Data;

/// <summary>
/// SmActionResponse
/// </summary>
[DataContract]
public class SmActionResponse
{
	/// <summary>
	/// The Meraki Ids of the set of endpoints
	/// </summary>
	[DataMember(Name = "ids")]
	[ApiAccess(ApiAccess.Read)]
	public List<string> Ids { get; set; } = [];
}
