using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	[DataContract]
	public class SwitchPortSchedule : NamedIdentifiedItem
	{
		[DataMember(Name = "networkId")]
		public string NetworkId { get; set; } = string.Empty;

		[DataMember(Name = "portSchedule")]
		public PortSchedule PortSchedule { get; set; } = new();
	}
}