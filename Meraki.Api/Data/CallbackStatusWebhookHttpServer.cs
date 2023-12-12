namespace Meraki.Api.Data;

/// <summary>
/// CallbackStatusWebhookHttpServer
/// </summary>
[DataContract]
public class CallbackStatusWebhookHttpServer
{
	/// <summary>
	/// The webhook receiver ID that will receive information
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "id")]
	public string Id { get; set; } = string.Empty;
}
