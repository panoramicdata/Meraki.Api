using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// Third party vpn peers
	/// </summary>
	[DataContract]
	public class ThirdPartyVpnPeers
	{
		/// <summary>
		/// The list of VPN peers
		/// </summary>
		[DataMember(Name = "peers")]
		public List<ThirdPartyVpnPeer> Peers { get; set; } = new();
	}
}
