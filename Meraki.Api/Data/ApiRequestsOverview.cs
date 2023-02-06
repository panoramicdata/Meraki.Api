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
	[DataMember(Name = "startTs")]
	public DateTime StartTs { get; set; }

	/// <summary>
	/// endTs
	/// </summary>
	[DataMember(Name = "endTs")]
	public DateTime EndTs { get; set; }

	/// <summary>
	/// counts
	/// </summary>
	[DataMember(Name = "counts")]
	public List<ApiRequestsOverviewCount>? Counts { get; set; }
}
