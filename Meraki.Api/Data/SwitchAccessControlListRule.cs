using Meraki.Api.Attributes;
using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// Rule12
	/// </summary>
	[DataContract]
	public class SwitchAccessControlListRule
	{
		/// <summary>
		/// Description of the rule (optional).
		/// </summary>
		/// <value>Description of the rule (optional).</value>
		[ApiAccess(ApiAccess.ReadUpdate)]
		[DataMember(Name = "comment")]
		public string Comment { get; set; } = null!;

		/// <summary>
		/// Gets or Sets Policy
		/// </summary>
		[ApiAccess(ApiAccess.ReadUpdate)]
		[DataMember(Name = "policy")]
		public AllowOrDeny Policy { get; set; }

		/// <summary>
		/// Gets or Sets IpVersion
		/// </summary>
		[ApiAccess(ApiAccess.ReadUpdate)]
		[DataMember(Name = "ipVersion")]
		public IpVersion IpVersion { get; set; }

		/// <summary>
		/// Gets or Sets Protocol
		/// </summary>
		[ApiAccess(ApiAccess.ReadUpdate)]
		[DataMember(Name = "protocol")]
		public TcpUdpAnyProtocol Protocol { get; set; }

		/// <summary>
		/// Source IP address (in IP or CIDR notation) or &#39;any&#39;.
		/// </summary>
		/// <value>Source IP address (in IP or CIDR notation) or &#39;any&#39;.</value>
		[ApiAccess(ApiAccess.ReadUpdate)]
		[DataMember(Name = "srcCidr")]
		public string SourceCidr { get; set; } = null!;

		/// <summary>
		/// Source port. Must be in the range  of 1-65535 or &#39;any&#39;. Default is &#39;any&#39;.
		/// </summary>
		/// <value>Source port. Must be in the range  of 1-65535 or &#39;any&#39;. Default is &#39;any&#39;.</value>
		[ApiAccess(ApiAccess.ReadUpdate)]
		[DataMember(Name = "srcPort")]
		public string SourcePort { get; set; } = null!;

		/// <summary>
		/// Destination IP address (in IP or CIDR notation) or &#39;any&#39;.
		/// </summary>
		/// <value>Destination IP address (in IP or CIDR notation) or &#39;any&#39;.</value>
		[ApiAccess(ApiAccess.ReadUpdate)]
		[DataMember(Name = "dstCidr")]
		public string DestinationCidr { get; set; } = null!;

		/// <summary>
		/// Destination port. Must be in the range of 1-65535 or &#39;any&#39;. Default is &#39;any&#39;.
		/// </summary>
		/// <value>Destination port. Must be in the range of 1-65535 or &#39;any&#39;. Default is &#39;any&#39;.</value>
		[ApiAccess(ApiAccess.ReadUpdate)]
		[DataMember(Name = "dstPort")]
		public string DestinationPort { get; set; } = null!;

		/// <summary>
		/// Incoming traffic VLAN. Must be in the range of 1-4095 or &#39;any&#39;. Default is &#39;any&#39;.
		/// </summary>
		/// <value>Incoming traffic VLAN. Must be in the range of 1-4095 or &#39;any&#39;. Default is &#39;any&#39;.</value>
		[ApiAccess(ApiAccess.ReadUpdate)]
		[DataMember(Name = "vlan")]
		public string Vlan { get; set; } = null!;
	}
}
