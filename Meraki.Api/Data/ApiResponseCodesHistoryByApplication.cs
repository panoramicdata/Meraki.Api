namespace Meraki.Api.Data;

/// <summary>
/// API response codes history aggregated by application
/// </summary>
[DataContract]
public class ApiResponseCodesHistoryByApplication
{
	/// <summary>
	/// User agent string of the application
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "userAgentString")]
	public string? UserAgentString { get; set; }

	/// <summary>
	/// Application name
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "name")]
	public string? Name { get; set; }

	/// <summary>
	/// Overall response code information
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "overall")]
	public ApiResponseCodeOverall? Overall { get; set; }
}
