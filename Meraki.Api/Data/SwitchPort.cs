using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// SwitchPort
	/// </summary>
	[DataContract]
	public partial class SwitchPort
	{
		/// <summary>
		/// Serial number of the switch.
		/// </summary>
		/// <value>Serial number of the switch.</value>
		[DataMember(Name = "serial", EmitDefaultValue = false)]
		public string Serial { get; set; } = null!;

		/// <summary>
		/// Port identifier of switch port. For modules, the identifier is \&quot;SlotNumber_ModuleType_PortNumber\&quot; (Ex: “1_8X10G_1”), otherwise it is just the port number (Ex: \&quot;8\&quot;).
		/// </summary>
		/// <value>Port identifier of switch port. For modules, the identifier is \&quot;SlotNumber_ModuleType_PortNumber\&quot; (Ex: “1_8X10G_1”), otherwise it is just the port number (Ex: \&quot;8\&quot;).</value>
		[DataMember(Name = "portId", EmitDefaultValue = false)]
		public string PortId { get; set; } = null!;
	}
}
