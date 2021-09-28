using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// UpdateNetworkSwitchSettingsMulticast
	/// </summary>
	[DataContract]
	public class SwitchSettingsMulticastUpdateRequest
	{
		/// <summary>
		/// Gets or Sets DefaultSettings
		/// </summary>
		[DataMember(Name = "defaultSettings")]
		public DefaultSettings DefaultSettings { get; set; } = new();
		/// <summary>
		/// Array of paired switches/stacks/profiles and corresponding multicast settings. An empty array will clear the multicast settings.
		/// </summary>
		/// <value>Array of paired switches/stacks/profiles and corresponding multicast settings. An empty array will clear the multicast settings.</value>
		[DataMember(Name = "overrides")]
		public List<Override1> Overrides { get; set; } = new();
	}
}
