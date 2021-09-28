using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// UpdateNetworkSwitchSettingsQosRule
	/// </summary>
	[DataContract]
	public class SwitchSettingsQosRuleUpdateRequest
	{
		/// <summary>
		/// The VLAN of the incoming packet. A null value will match any VLAN.
		/// </summary>
		/// <value>The VLAN of the incoming packet. A null value will match any VLAN.</value>
		[DataMember(Name = "vlan")]
		public int? Vlan { get; set; }
		/// <summary>
		/// Gets or Sets Protocol
		/// </summary>
		[DataMember(Name = "protocol")]
		public TcpUdpAnyCapsProtocol Protocol { get; set; }
		/// <summary>
		/// The source port of the incoming packet. Applicable only if protocol is TCP or UDP.
		/// </summary>
		/// <value>The source port of the incoming packet. Applicable only if protocol is TCP or UDP.</value>
		[DataMember(Name = "srcPort")]
		public int? SourcePort { get; set; }
		/// <summary>
		/// The source port range of the incoming packet. Applicable only if protocol is set to TCP or UDP. Example: 70-80
		/// </summary>
		/// <value>The source port range of the incoming packet. Applicable only if protocol is set to TCP or UDP. Example: 70-80</value>
		[DataMember(Name = "srcPortRange")]
		public string SrcPortRange { get; set; } = string.Empty;
		/// <summary>
		/// The destination port of the incoming packet. Applicable only if protocol is TCP or UDP.
		/// </summary>
		/// <value>The destination port of the incoming packet. Applicable only if protocol is TCP or UDP.</value>
		[DataMember(Name = "dstPort")]
		public int? DestinationPort { get; set; }
		/// <summary>
		/// The destination port range of the incoming packet. Applicable only if protocol is set to TCP or UDP. Example: 70-80
		/// </summary>
		/// <value>The destination port range of the incoming packet. Applicable only if protocol is set to TCP or UDP. Example: 70-80</value>
		[DataMember(Name = "dstPortRange")]
		public string DstPortRange { get; set; } = string.Empty;
		/// <summary>
		/// DSCP tag that should be assigned to incoming packet. Set this to -1 to trust incoming DSCP. Default value is 0.
		/// </summary>
		/// <value>DSCP tag that should be assigned to incoming packet. Set this to -1 to trust incoming DSCP. Default value is 0.</value>
		[DataMember(Name = "dscp")]
		public int? Dscp { get; set; }
	}
}
