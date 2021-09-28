using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// UpdateNetworkSwitchSettingsStp
	/// </summary>
	[DataContract]
	public class SwitchSettingsStpUpdateRequest
	{
		/// <summary>
		/// The spanning tree protocol status in network
		/// </summary>
		/// <value>The spanning tree protocol status in network</value>
		[DataMember(Name = "rstpEnabled")]
		public bool? RstpEnabled { get; set; }
		/// <summary>
		/// STP bridge priority for switches/stacks or switch profiles. An empty array will clear the STP bridge priority settings.
		/// </summary>
		/// <value>STP bridge priority for switches/stacks or switch profiles. An empty array will clear the STP bridge priority settings.</value>
		[DataMember(Name = "stpBridgePriority")]
		public List<StpBridgePriority> StpBridgePriority { get; set; } = new();
	}
}
