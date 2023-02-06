namespace Meraki.Api.Data;

/// <summary>
/// An API requests overview count
/// </summary>
[DataContract]
public class ApiRequestsOverviewCount
{
	/// <summary>
	/// code
	/// </summary>
	[DataMember(Name = "code")]
	public int Code { get; set; }

	/// <summary>
	/// count
	/// </summary>
	[DataMember(Name = "count")]
	public int Count { get; set; }
}
