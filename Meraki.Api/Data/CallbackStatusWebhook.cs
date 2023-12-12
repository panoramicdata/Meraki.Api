namespace Meraki.Api.Data;

/// <summary>
/// CallbackStatusWebhook
/// </summary>
[DataContract]
public class CallbackStatusWebhook
{
	/// <summary>
	/// The timestamp the callback was sent to the webhook receiver
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "sentAt")]
	public string SentAt { get; set; } = string.Empty;

	/// <summary>
	/// The webhook receiver URL where the callback will be sent
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "url")]
	public string Url { get; set; } = string.Empty;

	/// <summary>
	/// The webhook receiver used for the callback webhook
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "httpServer")]
	public CallbackStatusWebhookHttpServer HttpServer { get; set; } = new();

	/// <summary>
	/// The payload template of the webhook used for the callback
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "payloadTemplate")]
	public CallbackStatusWebhookPayloadTemplate PayloadTemplate { get; set; } = new();
}
