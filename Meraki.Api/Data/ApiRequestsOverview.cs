namespace Meraki.Api.Data;

/// <summary>
/// An API requests overview
/// </summary>
[DataContract]
public class ApiRequestsOverview
{
	/// <summary>
	/// startTs
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "startTs")]
	public DateTime StartTs { get; set; }

	/// <summary>
	/// endTs
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "endTs")]
	public DateTime EndTs { get; set; }

	/// <summary>
	/// counts
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "counts")]
	public List<ApiRequestsOverviewCount>? Counts { get; set; }
}
