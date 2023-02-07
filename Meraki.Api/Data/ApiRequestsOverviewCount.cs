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
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "code")]
	public int Code { get; set; }

	/// <summary>
	/// count
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "count")]
	public int Count { get; set; }
}
