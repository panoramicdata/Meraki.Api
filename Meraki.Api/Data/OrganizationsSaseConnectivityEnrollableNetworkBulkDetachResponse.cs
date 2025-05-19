namespace Meraki.Api.Data;

/// <summary>
/// Organizations Sase Connectivity Enrollable Network Bulk Detach Response
/// </summary>
[DataContract]
public class OrganizationsSaseConnectivityEnrollableNetworkBulkDetachResponse
{
	/// <summary>
	/// Action performed by the job
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "action")]
	public string? Action { get; set; }

	/// <summary>
	/// Message from the job. Can either be a success message or an error if there is a failure.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "message")]
	public string? Message { get; set; }

	/// <summary>
	/// Status of the job
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "status")]
	public string? Status { get; set; }

	/// <summary>
	/// Information for callback used to send back results
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "callback")]
	public OrganizationsSaseConnectivityEnrollableNetworkBulkDetachCallback? Callback { get; set; }

	/// <summary>
	/// Request that was sent to the job
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "request")]
	public OrganizationsSaseConnectivityEnrollableNetworkBulkDetachResponseRequest? Request { get; set; }
}
