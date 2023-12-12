namespace Meraki.Api.Data;

/// <summary>
/// CallbackStatusWebhookPayloadTemplate
/// </summary>
[DataContract]
public class CallbackStatusWebhookPayloadTemplate
{
	/// <summary>
	/// The ID of the payload template
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "id")]
	public string Id { get; set; } = string.Empty;
}
