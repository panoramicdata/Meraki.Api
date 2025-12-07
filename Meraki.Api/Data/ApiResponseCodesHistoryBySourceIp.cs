namespace Meraki.Api.Data;

/// <summary>
/// API response codes history aggregated by source IP
/// </summary>
[DataContract]
public class ApiResponseCodesHistoryBySourceIp
{
	/// <summary>
	/// Public IP address from which the API request was made
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "sourceIp")]
	public string? SourceIp { get; set; }

	/// <summary>
	/// Overall response code information
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "overall")]
	public ApiResponseCodeOverall? Overall { get; set; }
}
