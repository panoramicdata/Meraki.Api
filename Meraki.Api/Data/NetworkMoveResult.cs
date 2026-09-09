namespace Meraki.Api.Data;

/// <summary>
/// Result of a network move operation
/// </summary>
[DataContract]
public class NetworkMoveResult
{
	/// <summary>
	/// Current status of the network move operation. Possible values are pending, in progress, failed, completed, and invalidated
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "status")]
	public string? Status { get; set; }

	/// <summary>
	/// More information about the status of the network move operation
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "reason")]
	public string? Reason { get; set; }
}
