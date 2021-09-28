using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// ThirdPartyVpnPeerResponse
	/// </summary>
	[DataContract]
	public class ThirdPartyVpnPeerResponse
	{
		/// <summary>
		/// The list of VPN peers
		/// </summary>
		[DataMember(Name = "peers")]
		public List<ThirdPartyVpnPeer> Peers { get; set; } = new();
	}
}