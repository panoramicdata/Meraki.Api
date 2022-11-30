namespace Meraki.Api.Data;

/// <summary>
/// The network-wide destinations for all alerts on the network.
/// </summary>
[DataContract]
public class DefaultDestinations
{
	/// <summary>
	/// A list of emails that will receive the alert(s).
	/// </summary>
	/// <value>A list of emails that will receive the alert(s).</value>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "emails")]
	public List<string> Emails { get; set; } = new();

	/// <summary>
	/// If true, then all network admins will receive emails.
	/// </summary>
	/// <value>If true, then all network admins will receive emails.</value>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "allAdmins")]
	public bool? AllAdmins { get; set; }
	/// <summary>
	/// If true, then an SNMP trap will be sent if there is an SNMP trap server configured for this network.
	/// </summary>
	/// <value>If true, then an SNMP trap will be sent if there is an SNMP trap server configured for this network.</value>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "snmp")]
	public bool? Snmp { get; set; }
	/// <summary>
	/// A list of HTTP server IDs to send a Webhook to
	/// </summary>
	/// <value>A list of HTTP server IDs to send a Webhook to</value>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "httpServerIds")]
	public List<string> HttpServerIds { get; set; } = new();
}
