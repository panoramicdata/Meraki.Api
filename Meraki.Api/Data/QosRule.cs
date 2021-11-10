using Meraki.Api.Attributes;
using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// CreateNetworkSwitchSettingsQosRule
	/// </summary>
	[DataContract]
	public class QosRule : IdentifiedItem
	{
		/// <summary>
		/// The VLAN of the incoming packet. A null value will match any VLAN.
		/// </summary>
		[ApiAccess(ApiAccess.ReadWrite)]
		[DataMember(Name = "vlan")]
		public int? Vlan { get; set; }

		/// <summary>
		/// Gets or Sets Protocol
		/// </summary>
		[ApiAccess(ApiAccess.ReadWrite)]
		[DataMember(Name = "protocol")]
		public TcpUdpAnyCapsProtocol Protocol { get; set; }

		/// <summary>
		/// The source port of the incoming packet. Applicable only if protocol is TCP or UDP.
		/// </summary>
		[ApiAccess(ApiAccess.ReadWrite)]
		[DataMember(Name = "srcPort")]
		public int? SourcePort { get; set; }

		/// <summary>
		/// The source port range of the incoming packet. Applicable only if protocol is set to TCP or UDP. Example: 70-80
		/// </summary>
		[ApiAccess(ApiAccess.ReadWrite)]
		[DataMember(Name = "srcPortRange")]
		public string SourcePortRange { get; set; } = string.Empty!;

		/// <summary>
		/// The destination port of the incoming packet. Applicable only if protocol is TCP or UDP.
		/// </summary>
		[ApiAccess(ApiAccess.ReadWrite)]
		[DataMember(Name = "dstPort")]
		public int? DestinationPort { get; set; }

		/// <summary>
		/// The destination port range of the incoming packet. Applicable only if protocol is set to TCP or UDP. Example: 70-80
		/// </summary>
		[ApiAccess(ApiAccess.ReadWrite)]
		[DataMember(Name = "dstPortRange")]
		public string DestinationPortRange { get; set; } = string.Empty!;

		/// <summary>
		/// DSCP tag. Set this to -1 to trust incoming DSCP. Default value is 0
		/// </summary>
		[ApiAccess(ApiAccess.ReadWrite)]
		[DataMember(Name = "dscp")]
		public int? Dscp { get; set; }
	}
}
