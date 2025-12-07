namespace Meraki.Api.Data;

/// <summary>
/// API response codes history aggregated by operation
/// </summary>
[DataContract]
public class ApiResponseCodesHistoryByOperation
{
	/// <summary>
	/// The ID of the operation to aggregate data for
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "operationId")]
	public string? OperationId { get; set; }

	/// <summary>
	/// Overall response code information
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "overall")]
	public ApiResponseCodeOverall? Overall { get; set; }
}
