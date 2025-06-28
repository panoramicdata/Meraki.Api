namespace Meraki.Api.Data;

/// <summary>
/// Information for callback used to send back results
/// </summary>
[DataContract]
public class DeviceLiveToolsCyclePortCreateResponseCallback
{
	/// <summary>
	/// The ID of the callback. To check the status of the callback, use this ID in a request to /webhooks/callbacks/statuses/{id}
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "id")]
	public string Id { get; set; } = string.Empty;

	/// <summary>
	/// The callback URL for the webhook target. This was either provided in the original request or comes from a configured webhook receiver
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "url")]
	public string Url { get; set; } = string.Empty;

	/// <summary>
	/// The status of the callback
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "status")]
	public string Status { get; set; } = string.Empty;
}
