using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// Peers
	/// </summary>
	[DataContract]
	public class ThirdPartyVpnPeersUpdateRequest
	{
		/// <summary>
		/// The list of VPN peers
		/// </summary>
		/// <value>The list of VPN peers</value>
		[DataMember(Name = "peers")]
		public List<ThirdPartyVpnPeer> Peers { get; set; } = new List<ThirdPartyVpnPeer>();
	}
}
