using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// Peers
	/// </summary>
	[DataContract]
	public partial class ThirdPartyVpnPeersUpdateRequest
	{
		/// <summary>
		/// The list of VPN peers
		/// </summary>
		/// <value>The list of VPN peers</value>
		[DataMember(Name = "peers", EmitDefaultValue = false)]
		public List<ThirdPartyVpnPeer> Peers { get; set; } = new List<ThirdPartyVpnPeer>();
	}
}
