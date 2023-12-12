namespace Meraki.Api.Data;

[DataContract]
public class OrganizationAlertRecipients
{
	/// <summary>
	/// A list of emails that will receive information about the alert
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "emails")]
	public List<string> Emails { get; set; } = [];

	/// <summary>
	/// A list base64 encoded urls of webhook endpoints that will receive information about the alert
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "httpServerIds")]
	public List<string> HttpServerIds { get; set; } = [];
}
