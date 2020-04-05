using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// UpdateNetworkSiteToSiteVpn
	/// </summary>
	[DataContract]
	public partial class UpdateNetworkSiteToSiteVpn
	{
		/// <summary>
		/// Gets or Sets Mode
		/// </summary>
		[DataMember(Name = "mode", EmitDefaultValue = false)]
		public Mode2 Mode { get; set; }
		/// <summary>
		/// The list of VPN hubs, in order of preference. In spoke mode, at least 1 hub is required.
		/// </summary>
		/// <value>The list of VPN hubs, in order of preference. In spoke mode, at least 1 hub is required.</value>
		[DataMember(Name = "hubs", EmitDefaultValue = false)]
		public List<Hub> Hubs { get; set; }
		/// <summary>
		/// The list of subnets and their VPN presence.
		/// </summary>
		/// <value>The list of subnets and their VPN presence.</value>
		[DataMember(Name = "subnets", EmitDefaultValue = false)]
		public List<Subnet> Subnets { get; set; }
	}
}
