namespace Meraki.Api.Data;

/// <summary>
/// A hash of destinations for this specific alert
/// </summary>
[DataContract]
public class AlertDestinations
{
	/// <summary>
	/// A list of emails that will receive information about the alert
	/// </summary>
	/// <value>A list of emails that will receive information about the alert</value>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "emails")]
	public List<string>? Emails { get; set; }

	/// <summary>
	/// smsNumbers - Undocumented - This is an array of something so a strong possibility it will be a list of string. Not populated as of 2024-02-29
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "smsNumbers")]
	public List<string>? SmsNumbers { get; set; }

	/// <summary>
	/// If true, then all network admins will receive emails for this alert
	/// </summary>
	/// <value>If true, then all network admins will receive emails for this alert</value>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "allAdmins")]
	public bool? AllAdmins { get; set; }

	/// <summary>
	/// If true, then an SNMP trap will be sent for this alert if there is an SNMP trap server configured for this network
	/// </summary>
	/// <value>If true, then an SNMP trap will be sent for this alert if there is an SNMP trap server configured for this network</value>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "snmp")]
	public bool? Snmp { get; set; }

	/// <summary>
	/// A list of HTTP server IDs to send a Webhook to for this alert
	/// </summary>
	/// <value>A list of HTTP server IDs to send a Webhook to for this alert</value>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "httpServerIds")]
	public List<string>? HttpServerIds { get; set; }
}
