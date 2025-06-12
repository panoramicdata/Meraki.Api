namespace Meraki.Api.Data;

/// <summary>
/// Organization Webhook Test
/// </summary>
[DataContract]
public class OrganizationWebhookTest
{
	/// <summary>
	/// Webhook delivery identifier
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "id")]
	public string Id { get; set; } = string.Empty;

	/// <summary>
	/// Current status of the webhook delivery
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "status")]
	public TestStatus Status { get; set; }

	/// <summary>
	/// URL where the webhook was delivered
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "url")]
	public string Url { get; set; } = string.Empty;
}
