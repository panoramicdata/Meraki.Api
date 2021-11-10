using Meraki.Api.Attributes;
using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// Create or Update Network Switch Routing Multicast Rendezvous Point
	/// </summary>
	[DataContract]
	public class RendezvousPointCreateUpdateRequest
	{
		/// <summary>
		/// The IP address of the interface where the RP needs to be created.
		/// </summary>
		[ApiAccess(ApiAccess.ReadWrite)]
		[DataMember(Name = "interfaceIp")]
		public string InterfaceIp { get; set; } = string.Empty;

		/// <summary>
		/// 'Any', or the IP address of a multicast group
		/// </summary>
		[ApiAccess(ApiAccess.ReadWrite)]
		[DataMember(Name = "multicastGroup")]
		public string MulticastGroup { get; set; } = string.Empty;
	}
}