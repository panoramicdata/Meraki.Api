using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// CreateNetworkSwitchPortSchedule
	/// </summary>
	[DataContract]
	public partial class SwitchPortScheduleCreationRequest
	{
		/// <summary>
		/// The name for your port schedule. Required
		/// </summary>
		/// <value>The name for your port schedule. Required</value>
		[DataMember(Name = "name", EmitDefaultValue = false)]
		public string Name { get; set; } = null!;

		/// <summary>
		/// Gets or Sets PortSchedule
		/// </summary>
		[DataMember(Name = "portSchedule", EmitDefaultValue = false)]
		public PortSchedule PortSchedule { get; set; } = null!;
	}
}
