namespace Meraki.Api.Data;

/// <summary>
/// Live Tools Cable Test Create Callback
/// </summary>
[DataContract]

public class LiveToolsCableTestCreateCallback
{
	/// <summary>
	/// A shared secret that will be included in the requests sent to the callback URL. It can be used to verify that the request was sent by Meraki. If using this field, please also specify an url.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "sharedSecret")]
	public string? SharedSecret { get; set; }

	/// <summary>
	/// The callback URL for the webhook target. If using this field, please also specify a sharedSecret.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "url")]
	public string? Url { get; set; }

	/// <summary>
	/// The webhook receiver used for the callback webhook.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "httpServer")]
	public LiveToolsCableTestCreateCallbackHttpServer? HttpServer { get; set; }

	/// <summary>
	/// The payload template of the webhook used for the callback
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "payloadTemplate")]
	public LiveToolsCableTestCreateCallbackPayloadTemplate? PayloadTemplate { get; set; }
}
