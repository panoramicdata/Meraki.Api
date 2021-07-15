using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// UpdateNetworkSwitchSettingsDhcpServerPolicy
	/// </summary>
	[DataContract]
	public partial class SwitchSettingsDhcpServerPolicyUpdateRequest
	{
		/// <summary>
		/// Gets or Sets DefaultPolicy
		/// </summary>
		[DataMember(Name = "defaultPolicy", EmitDefaultValue = false)]
		public DefaultPolicy DefaultPolicy { get; set; }
		/// <summary>
		/// List the MAC addresses of DHCP servers to permit on the network. Applicable only if defaultPolicy is set to block. An empty array will clear the entries.
		/// </summary>
		/// <value>List the MAC addresses of DHCP servers to permit on the network. Applicable only if defaultPolicy is set to block. An empty array will clear the entries.</value>
		[DataMember(Name = "allowedServers", EmitDefaultValue = false)]
		public List<string> AllowedServers { get; set; } = new();
		/// <summary>
		/// List the MAC addresses of DHCP servers to block on the network. Applicable only if defaultPolicy is set to allow. An empty array will clear the entries.
		/// </summary>
		/// <value>List the MAC addresses of DHCP servers to block on the network. Applicable only if defaultPolicy is set to allow. An empty array will clear the entries.</value>
		[DataMember(Name = "blockedServers", EmitDefaultValue = false)]
		public List<string> BlockedServers { get; set; } = new();
	}
}
