using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// ModelOverride
	/// </summary>
	[DataContract]
	public class ModelOverride
	{
		/// <summary>
		/// List of switch serials. Applicable only for switch network.
		/// </summary>
		/// <value>List of switch serials. Applicable only for switch network.</value>
		[DataMember(Name = "switches", EmitDefaultValue = false)]
		public List<string> Switches { get; set; } = null!;

		/// <summary>
		/// List of switch profile IDs. Applicable only for template network.
		/// </summary>
		/// <value>List of switch profile IDs. Applicable only for template network.</value>
		[DataMember(Name = "switchProfiles", EmitDefaultValue = false)]
		public List<string> SwitchProfiles { get; set; } = null!;

		/// <summary>
		/// MTU size for the switches or switch profiles.
		/// </summary>
		/// <value>MTU size for the switches or switch profiles.</value>
		[DataMember(Name = "mtuSize", EmitDefaultValue = false)]
		public int? MtuSize { get; set; }
	}
}
