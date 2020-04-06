using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// UpdateNetworkSwitchSettings
	/// </summary>
	[DataContract]
	public partial class SwitchSettingsUpdateRequest
	{
		/// <summary>
		/// Management VLAN
		/// </summary>
		/// <value>Management VLAN</value>
		[DataMember(Name = "vlan", EmitDefaultValue = false)]
		public int? Vlan { get; set; }
		/// <summary>
		/// The use Combined Power as the default behavior of secondary power supplies on supported devices.
		/// </summary>
		/// <value>The use Combined Power as the default behavior of secondary power supplies on supported devices.</value>
		[DataMember(Name = "useCombinedPower", EmitDefaultValue = false)]
		public bool? UseCombinedPower { get; set; }
		/// <summary>
		/// Exceptions on a per switch basis to \&quot;useCombinedPower\&quot;
		/// </summary>
		/// <value>Exceptions on a per switch basis to \&quot;useCombinedPower\&quot;</value>
		[DataMember(Name = "powerExceptions", EmitDefaultValue = false)]
		public List<PowerException> PowerExceptions { get; set; }
	}
}
