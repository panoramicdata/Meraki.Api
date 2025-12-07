namespace Meraki.Api.Data;

/// <summary>
/// Overall response code information
/// </summary>
[DataContract]
public class ApiResponseCodeOverall
{
	/// <summary>
	/// Response code count information
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "counts")]
	public ApiResponseCodeCounts? Counts { get; set; }
}
