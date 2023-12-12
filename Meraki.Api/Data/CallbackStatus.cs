namespace Meraki.Api.Data;

/// <summary>
/// The status of an API callback
/// </summary>
[DataContract]
public class CallbackStatus
{
	/// <summary>
	/// The ID of the callback
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "callbackId")]
	public string CallbackId { get; set; } = string.Empty;

	/// <summary>
	/// The status of the callback
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "status")]
	public string Status { get; set; } = string.Empty;

	/// <summary>
	/// The errors returned by the callback
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "errors")]
	public List<string> Errors { get; set; } = new();

	/// <summary>
	/// Information around who initiated the callback
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "createdBy")]
	public CallbackStatusCreatedBy? CreatedBy { get; set; }

	/// <summary>
	/// The webhook receiver used by the callback to send results
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "webhook")]
	public CallbackStatusWebhook? Webhook { get; set; }
}
