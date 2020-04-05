using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// CreateNetworkSwitchSettingsQosRule
	/// </summary>
	[DataContract]
	public partial class CreateNetworkSwitchSettingsQosRule
	{
		/// <summary>
		/// The VLAN of the incoming packet. A null value will match any VLAN.
		/// </summary>
		/// <value>The VLAN of the incoming packet. A null value will match any VLAN.</value>
		[DataMember(Name = "vlan", EmitDefaultValue = false)]
		public int? Vlan { get; set; }
		/// <summary>
		/// Gets or Sets Protocol
		/// </summary>
		[DataMember(Name = "protocol", EmitDefaultValue = false)]
		public Protocol8 Protocol { get; set; }
		/// <summary>
		/// The source port of the incoming packet. Applicable only if protocol is TCP or UDP.
		/// </summary>
		/// <value>The source port of the incoming packet. Applicable only if protocol is TCP or UDP.</value>
		[DataMember(Name = "srcPort", EmitDefaultValue = false)]
		public int? SourcePort { get; set; }
		/// <summary>
		/// The source port range of the incoming packet. Applicable only if protocol is set to TCP or UDP. Example: 70-80
		/// </summary>
		/// <value>The source port range of the incoming packet. Applicable only if protocol is set to TCP or UDP. Example: 70-80</value>
		[DataMember(Name = "srcPortRange", EmitDefaultValue = false)]
		public string SrcPortRange { get; set; }
		/// <summary>
		/// The destination port of the incoming packet. Applicable only if protocol is TCP or UDP.
		/// </summary>
		/// <value>The destination port of the incoming packet. Applicable only if protocol is TCP or UDP.</value>
		[DataMember(Name = "dstPort", EmitDefaultValue = false)]
		public int? DestinationPort { get; set; }
		/// <summary>
		/// The destination port range of the incoming packet. Applicable only if protocol is set to TCP or UDP. Example: 70-80
		/// </summary>
		/// <value>The destination port range of the incoming packet. Applicable only if protocol is set to TCP or UDP. Example: 70-80</value>
		[DataMember(Name = "dstPortRange", EmitDefaultValue = false)]
		public string DstPortRange { get; set; }
		/// <summary>
		/// DSCP tag. Set this to -1 to trust incoming DSCP. Default value is 0
		/// </summary>
		/// <value>DSCP tag. Set this to -1 to trust incoming DSCP. Default value is 0</value>
		[DataMember(Name = "dscp", EmitDefaultValue = false)]
		public int? Dscp { get; set; }
	}
}
