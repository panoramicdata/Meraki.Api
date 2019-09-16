using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// A third party VPN peer
	/// </summary>
	[DataContract]
	public class ThirdPartyVpnPeer : NamedItem
	{
		/// <summary>
		/// The public IP
		/// </summary>
		[DataMember(Name = "publicIp")]
		public string PublicIp { get; set; } = string.Empty;

		/// <summary>
		/// The private subnets
		/// </summary>
		[DataMember(Name = "privateSubnets")]
		public List<string> PrivateSubnets { get; set; } = new List<string>();

		/// <summary>
		/// The secret
		/// </summary>
		[DataMember(Name = "secret")]
		public string Secret { get; set; } = string.Empty;

		/// <summary>
		/// The IPSEc policies
		/// </summary>
		[DataMember(Name = "ipsecPolicies")]
		public IpsecPolicies IpsecPolicies { get; set; } = new IpsecPolicies();
	}
}