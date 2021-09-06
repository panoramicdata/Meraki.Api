using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
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
		[DataMember(Name = "emails", EmitDefaultValue = false)]
		public List<string>? Emails { get; set; }

		/// <summary>
		/// If true, then all network admins will receive emails for this alert
		/// </summary>
		/// <value>If true, then all network admins will receive emails for this alert</value>
		[DataMember(Name = "allAdmins", EmitDefaultValue = false)]
		public bool? AllAdmins { get; set; }

		/// <summary>
		/// If true, then an SNMP trap will be sent for this alert if there is an SNMP trap server configured for this network
		/// </summary>
		/// <value>If true, then an SNMP trap will be sent for this alert if there is an SNMP trap server configured for this network</value>
		[DataMember(Name = "snmp", EmitDefaultValue = false)]
		public bool? Snmp { get; set; }

		/// <summary>
		/// A list of HTTP server IDs to send a Webhook to for this alert
		/// </summary>
		/// <value>A list of HTTP server IDs to send a Webhook to for this alert</value>
		[DataMember(Name = "httpServerIds", EmitDefaultValue = false)]
		public List<string>? HttpServerIds { get; set; }
	}
}