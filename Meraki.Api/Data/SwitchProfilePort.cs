using Meraki.Api.Attributes;
using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// SwitchProfilePort
	/// </summary>
	[DataContract]
	public class SwitchProfilePort
	{
		/// <summary>
		/// Profile identifier.
		/// </summary>
		[ApiAccess(ApiAccess.ReadWrite)]
		[DataMember(Name = "profile")]
		public string Profile { get; set; } = string.Empty;

		/// <summary>
		/// Port identifier of switch port. For modules, the identifier is "SlotNumber_ModuleType_PortNumber" (Ex: "1_8X10G_1"), otherwise it is just the port number (Ex: "8").
		/// </summary>
		[ApiAccess(ApiAccess.ReadWrite)]
		[DataMember(Name = "portId")]
		public string PortId { get; set; } = string.Empty;
	}
}
