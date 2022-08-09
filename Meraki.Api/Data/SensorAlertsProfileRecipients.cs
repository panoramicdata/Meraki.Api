namespace Meraki.Api.Data;
/// <summary>
/// A List of recipients that will receive the alert
/// </summary>
[DataContract]
public class SensorAlertsProfileRecipients
{
	/// <summary>
	/// A list of emails that will receive information about the alert
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "emails")]
	public List<string>? Emails { get; set; }

	/// <summary>
	/// A list of webhook endpoint IDs that will receive information abou the alert
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "httpServerIds")]
	public List<string>? HttpServerIds { get; set; }

	/// <summary>
	/// A list of SMS numbers that will receive information about the alert
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "smsNumbers")]
	public List<string>? SmsNumbers { get; set; }
}