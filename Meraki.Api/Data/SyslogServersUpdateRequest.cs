using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// UpdateNetworkSyslogServers
	/// </summary>
	[DataContract]
	public partial class SyslogServersUpdateRequest
	{
		/// <summary>
		/// A list of the syslog servers for this network
		/// </summary>
		/// <value>A list of the syslog servers for this network</value>
		[DataMember(Name = "servers", EmitDefaultValue = false)]
		public List<ServerSettings> Servers { get; set; } = new();
	}
}
