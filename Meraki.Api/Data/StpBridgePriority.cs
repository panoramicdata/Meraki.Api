using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// StpBridgePriority
	/// </summary>
	[DataContract]
	public partial class StpBridgePriority
	{
		/// <summary>
		/// List of switch profile IDs
		/// </summary>
		/// <value>List of switch profile IDs</value>
		[DataMember(Name = "switchProfiles", EmitDefaultValue = false)]
		public List<string>? SwitchProfiles { get; set; }

		/// <summary>
		/// List of switch serial numbers
		/// </summary>
		/// <value>List of switch serial numbers</value>
		[DataMember(Name = "switches", EmitDefaultValue = false)]
		public List<string>? Switches { get; set; }

		/// <summary>
		/// List of stack IDs
		/// </summary>
		/// <value>List of stack IDs</value>
		[DataMember(Name = "stacks", EmitDefaultValue = false)]
		public List<string>? Stacks { get; set; }

		/// <summary>
		/// STP priority for switch, stacks, or switch profiles
		/// </summary>
		/// <value>STP priority for switch, stacks, or switch profiles</value>
		[DataMember(Name = "stpPriority", EmitDefaultValue = false)]
		public int? StpPriority { get; set; }
	}
}
