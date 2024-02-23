namespace Meraki.Api.Data;

/// <summary>
/// Live Tools Cable Test Callback
/// </summary>
[DataContract]

public class LiveToolsCableTestCallback
{
	/// <summary>
	/// The ID of the callback. To check the status of the callback, use this ID in a request to /webhooks/callbacks/statuses/{id}
	/// </summary>
	[DataMember(Name = "id")]
	public string Id { get; set; } = string.Empty;

	/// <summary>
	/// Status of the callback
	/// </summary>
	[DataMember(Name = "status")]
	public string Status { get; set; } = string.Empty;

	/// <summary>
	/// The callback URL for the webhook target. This was either provided in the original request or comes from a configured webhook receiver.
	/// </summary>
	[DataMember(Name = "url")]
	public string Url { get; set; } = string.Empty;
}
