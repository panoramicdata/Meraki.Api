using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// Rule12
	/// </summary>
	[DataContract]
	public partial class SwitchAccessControlListRule
	{
		/// <summary>
		/// Description of the rule (optional).
		/// </summary>
		/// <value>Description of the rule (optional).</value>
		[DataMember(Name = "comment", EmitDefaultValue = false)]
		public string Comment { get; set; } = null!;

		/// <summary>
		/// Gets or Sets Policy
		/// </summary>
		[DataMember(Name = "policy", EmitDefaultValue = false)]
		public AllowOrDeny Policy { get; set; }

		/// <summary>
		/// Gets or Sets IpVersion
		/// </summary>
		[DataMember(Name = "ipVersion", EmitDefaultValue = false)]
		public IpVersion IpVersion { get; set; }

		/// <summary>
		/// Gets or Sets Protocol
		/// </summary>
		[DataMember(Name = "protocol", EmitDefaultValue = false)]
		public TcpUdpAnyProtocol Protocol { get; set; }

		/// <summary>
		/// Source IP address (in IP or CIDR notation) or &#39;any&#39;.
		/// </summary>
		/// <value>Source IP address (in IP or CIDR notation) or &#39;any&#39;.</value>
		[DataMember(Name = "srcCidr", EmitDefaultValue = false)]
		public string SourceCidr { get; set; } = null!;

		/// <summary>
		/// Source port. Must be in the range  of 1-65535 or &#39;any&#39;. Default is &#39;any&#39;.
		/// </summary>
		/// <value>Source port. Must be in the range  of 1-65535 or &#39;any&#39;. Default is &#39;any&#39;.</value>
		[DataMember(Name = "srcPort", EmitDefaultValue = false)]
		public string SourcePort { get; set; } = null!;

		/// <summary>
		/// Destination IP address (in IP or CIDR notation) or &#39;any&#39;.
		/// </summary>
		/// <value>Destination IP address (in IP or CIDR notation) or &#39;any&#39;.</value>
		[DataMember(Name = "dstCidr", EmitDefaultValue = false)]
		public string DestinationCidr { get; set; } = null!;

		/// <summary>
		/// Destination port. Must be in the range of 1-65535 or &#39;any&#39;. Default is &#39;any&#39;.
		/// </summary>
		/// <value>Destination port. Must be in the range of 1-65535 or &#39;any&#39;. Default is &#39;any&#39;.</value>
		[DataMember(Name = "dstPort", EmitDefaultValue = false)]
		public string DestinationPort { get; set; } = null!;

		/// <summary>
		/// Incoming traffic VLAN. Must be in the range of 1-4095 or &#39;any&#39;. Default is &#39;any&#39;.
		/// </summary>
		/// <value>Incoming traffic VLAN. Must be in the range of 1-4095 or &#39;any&#39;. Default is &#39;any&#39;.</value>
		[DataMember(Name = "vlan", EmitDefaultValue = false)]
		public string Vlan { get; set; } = null!;
	}
}
