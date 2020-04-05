using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// UpdateNetworkSwitchPortSchedule
	/// </summary>
	[DataContract]
	public partial class UpdateNetworkSwitchPortSchedule
	{
		/// <summary>
		/// The name for your port schedule.
		/// </summary>
		/// <value>The name for your port schedule.</value>
		[DataMember(Name = "name", EmitDefaultValue = false)]
		public string Name { get; set; }
		/// <summary>
		/// Gets or Sets PortSchedule
		/// </summary>
		[DataMember(Name = "portSchedule", EmitDefaultValue = false)]
		public PortSchedule PortSchedule { get; set; }
	}
}
