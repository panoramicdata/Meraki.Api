using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// SwitchPort
	/// </summary>
	[DataContract]
	public class LinkAggregationSwitchPort
	{
		/// <summary>
		/// Serial number of the switch.
		/// </summary>
		[DataMember(Name = "serial")]
		public string Serial { get; set; } = null!;

		/// <summary>
		/// Port identifier of switch port. For modules, the identifier is \&quot;SlotNumber_ModuleType_PortNumber\&quot; (Ex: “1_8X10G_1”), otherwise it is just the port number (Ex: \&quot;8\&quot;).
		/// </summary>
		[DataMember(Name = "portId")]
		public string PortId { get; set; } = null!;
	}
}
