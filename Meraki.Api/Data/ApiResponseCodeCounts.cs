namespace Meraki.Api.Data;

/// <summary>
/// API response code counts information
/// </summary>
[DataContract]
public class ApiResponseCodeCounts
{
	/// <summary>
	/// Aggregated response code counts
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "byCode")]
	public List<ApiResponseCodeCount>? ByCode { get; set; }

	/// <summary>
	/// Total number of requests
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "total")]
	public int Total { get; set; }
}
