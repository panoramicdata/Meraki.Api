namespace Meraki.Api.Data;

/// <summary>
/// Secure Connect site create response
/// </summary>
[DataContract]
public class SecureConnectSiteCreateResponse
{
	/// <summary>
	/// Action performed by the job
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "action")]
	public string Action { get; set; } = string.Empty;

	/// <summary>
	/// Message from the job. Can either be a success message or an error if there is a failure.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "message")]
	public string Message { get; set; } = string.Empty;

	/// <summary>
	/// Status of the job
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "status")]
	public string Status { get; set; } = string.Empty;

	/// <summary>
	/// Information for callback used to send back results
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "callback")]
	public SecureConnectSiteCreateResponseCallback Callback { get; set; } = new();

	/// <summary>
	/// Request that was sent to the job
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "request")]
	public SecureConnectSiteCreateResponseRequest Request { get; set; } = new();
}
