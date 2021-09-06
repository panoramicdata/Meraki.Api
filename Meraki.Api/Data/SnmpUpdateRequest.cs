using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// UpdateOrganizationSnmp
	/// </summary>
	[DataContract]
	public class SnmpUpdateRequest
	{
		/// <summary>
		/// Boolean indicating whether SNMP version 2c is enabled for the organization.
		/// </summary>
		/// <value>Boolean indicating whether SNMP version 2c is enabled for the organization.</value>
		[DataMember(Name = "v2cEnabled")]
		public bool? V2cEnabled { get; set; }
		/// <summary>
		/// Boolean indicating whether SNMP version 3 is enabled for the organization.
		/// </summary>
		/// <value>Boolean indicating whether SNMP version 3 is enabled for the organization.</value>
		[DataMember(Name = "v3Enabled")]
		public bool? V3Enabled { get; set; }
		/// <summary>
		/// Gets or Sets V3AuthMode
		/// </summary>
		[DataMember(Name = "v3AuthMode")]
		public SnmpV3AuthMode V3AuthMode { get; set; }
		/// <summary>
		/// The SNMP version 3 authentication password. Must be at least 8 characters if specified.
		/// </summary>
		/// <value>The SNMP version 3 authentication password. Must be at least 8 characters if specified.</value>
		[DataMember(Name = "v3AuthPass")]
		public string V3AuthPass { get; set; } = string.Empty;
		/// <summary>
		/// Gets or Sets V3PrivMode
		/// </summary>
		[DataMember(Name = "v3PrivMode")]
		public SnmpV3PrivMode V3PrivMode { get; set; }
		/// <summary>
		/// The SNMP version 3 privacy password. Must be at least 8 characters if specified.
		/// </summary>
		/// <value>The SNMP version 3 privacy password. Must be at least 8 characters if specified.</value>
		[DataMember(Name = "v3PrivPass")]
		public string V3PrivPass { get; set; } = string.Empty;
		/// <summary>
		/// The IPs that are allowed to access the SNMP server. This list should be IPv4 addresses separated by semi-colons (ie. \&quot;1.2.3.4;2.3.4.5\&quot;).
		/// </summary>
		/// <value>The IPs that are allowed to access the SNMP server. This list should be IPv4 addresses separated by semi-colons (ie. \&quot;1.2.3.4;2.3.4.5\&quot;).</value>
		[DataMember(Name = "peerIps")]
		public List<string> PeerIps { get; set; } = new();
	}
}
