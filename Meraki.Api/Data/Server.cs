using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// Server
	/// </summary>
	[DataContract]
	public partial class Server
	{
		/// <summary>
		/// The IP address of the syslog server
		/// </summary>
		/// <value>The IP address of the syslog server</value>
		[DataMember(Name = "host", EmitDefaultValue = false)]
		public string Host { get; set; } = null!;

		/// <summary>
		/// The port of the syslog server
		/// </summary>
		/// <value>The port of the syslog server</value>
		[DataMember(Name = "port", EmitDefaultValue = false)]
		public int? Port { get; set; }

		/// <summary>
		/// A list of roles for the syslog server. Options (case-insensitive): &#39;Wireless event log&#39;, &#39;Appliance event log&#39;, &#39;Switch event log&#39;, &#39;Air Marshal events&#39;, &#39;Flows&#39;, &#39;URLs&#39;, &#39;IDS alerts&#39;, &#39;Security events&#39;
		/// </summary>
		/// <value>A list of roles for the syslog server. Options (case-insensitive): &#39;Wireless event log&#39;, &#39;Appliance event log&#39;, &#39;Switch event log&#39;, &#39;Air Marshal events&#39;, &#39;Flows&#39;, &#39;URLs&#39;, &#39;IDS alerts&#39;, &#39;Security events&#39;</value>
		[DataMember(Name = "roles", EmitDefaultValue = false)]
		public List<string> Roles { get; set; } = null!;
	}
}
