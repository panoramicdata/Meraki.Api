using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// UpdateNetworkSyslogServers
	/// </summary>
	[DataContract]
	public class SyslogServers
	{
		/// <summary>
		/// A list of the syslog servers for this network
		/// </summary>
		/// <value>A list of the syslog servers for this network</value>
		[DataMember(Name = "servers")]
		public List<SyslogServer> Servers { get; set; } = new();
	}
}
