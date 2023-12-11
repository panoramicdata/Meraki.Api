namespace Meraki.Api.Data;

/// <summary>
/// Details for the callback. Please include either an httpServerId OR url and sharedSecret
/// </summary>
[DataContract]

public class LiveToolPingCreateCallback
{
	/// <summary>
	/// The callback URL for the webhook target. If using this field, please also specify a sharedSecret.
	/// </summary>
	[DataMember(Name = "url")]
	public string? Url { get; set; } = string.Empty;

	/// <summary>
	/// A shared secret that will be included in the requests sent to the callback URL. It can be used to verify that the request was sent by Meraki. If using this field, please also specify an url.
	/// </summary>
	[DataMember(Name = "sharedSecret")]
	public string? SharedSecret { get; set; } = string.Empty;

	/// <summary>
	/// The webhook receiver used for the callback webhook.
	/// </summary>
	[DataMember(Name = "httpServer")]
	public LiveToolPingCallBackHttpServer? httpServer { get; set; } = new();

	/// <summary>
	/// The ID of the payload template. Defaults to 'wpt_00005' for the Callback (included) template.
	/// </summary>
	[DataMember(Name = "payloadTemplate")]
	public string? PayloadTemplate { get; set; } = string.Empty;
}
