namespace Meraki.Api.Data;

/// <summary>
/// Details for the callback. Please include either an httpServerId OR url and sharedSecret
/// </summary>
[DataContract]
public class DeviceLiveToolsTraceRouteCreateRequestCallback
{
	/// <summary>
	/// A shared secret that will be included in the requests sent to the callback URL. It can be used to verify that the request was sent by Meraki. If using this field, please also specify an url.
	/// </summary>
	[DataMember(Name = "sharedSecret")]
	public string? SharedSecret { get; set; }

	/// <summary>
	/// The callback URL for the webhook target. If using this field, please also specify a sharedSecret.
	/// </summary>
	[DataMember(Name = "url")]
	public string? Url { get; set; }

	/// <summary>
	/// The webhook receiver used for the callback webhook.
	/// </summary>
	[DataMember(Name = "httpServer")]
	public DeviceLiveToolsTraceRouteCreateRequestCallbackHttpServer? HttpServer { get; set; }

	/// <summary>
	/// The payload template of the webhook used for the callback
	/// </summary>
	[DataMember(Name = "payloadTemplate")]
	public DeviceLiveToolsTraceRouteCreateRequestCallbackPayloadTemplate? PayloadTemplate { get; set; }
}