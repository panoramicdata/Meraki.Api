using Meraki.Api.Attributes;
using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// Network Switch Routing Multicast Rendezvous Points
	/// </summary>
	[DataContract]
	public class RendezvousPoint : RendezvousPointCreateUpdateRequest
	{
		/// <summary>
		/// RendezvousPointId
		/// </summary>
		[ApiKey]
		[ApiAccess(ApiAccess.Read)]
		[DataMember(Name = "rendezvousPointId")]
		public string RendezvousPointId { get; set; } = string.Empty;

		/// <summary>
		/// Serial
		/// </summary>
		[ApiAccess(ApiAccess.Read)]
		[DataMember(Name = "serial")]
		public string Serial { get; set; } = string.Empty;

		/// <summary>
		/// InterfaceName
		/// </summary>
		[ApiAccess(ApiAccess.Read)]
		[DataMember(Name = "interfaceName")]
		public string InterfaceName { get; set; } = string.Empty;
	}
}