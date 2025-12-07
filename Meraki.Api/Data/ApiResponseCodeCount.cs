namespace Meraki.Api.Data;

/// <summary>
/// API response code count
/// </summary>
[DataContract]
public class ApiResponseCodeCount
{
	/// <summary>
	/// Response code
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "code")]
	public int Code { get; set; }

	/// <summary>
	/// Total counts per response code
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "total")]
	public int Total { get; set; }
}
