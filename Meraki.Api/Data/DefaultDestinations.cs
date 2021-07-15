using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// The network-wide destinations for all alerts on the network.
	/// </summary>
	[DataContract]
	public partial class DefaultDestinations
	{
		/// <summary>
		/// A list of emails that will recieve the alert(s).
		/// </summary>
		/// <value>A list of emails that will recieve the alert(s).</value>
		[DataMember(Name = "emails", EmitDefaultValue = false)]
		public List<string> Emails { get; set; } = new();
		/// <summary>
		/// If true, then all network admins will receive emails.
		/// </summary>
		/// <value>If true, then all network admins will receive emails.</value>
		[DataMember(Name = "allAdmins", EmitDefaultValue = false)]
		public bool? AllAdmins { get; set; }
		/// <summary>
		/// If true, then an SNMP trap will be sent if there is an SNMP trap server configured for this network.
		/// </summary>
		/// <value>If true, then an SNMP trap will be sent if there is an SNMP trap server configured for this network.</value>
		[DataMember(Name = "snmp", EmitDefaultValue = false)]
		public bool? Snmp { get; set; }
		/// <summary>
		/// A list of HTTP server IDs to send a Webhook to
		/// </summary>
		/// <value>A list of HTTP server IDs to send a Webhook to</value>
		[DataMember(Name = "httpServerIds", EmitDefaultValue = false)]
		public List<string> HttpServerIds { get; set; } = new();
	}
}
