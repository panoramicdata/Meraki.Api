using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// Rule3
	/// </summary>
	[DataContract]
	public partial class BonjourForwardingRule
	{
		/// <summary>
		/// A description for your Bonjour forwarding rule. Optional.
		/// </summary>
		/// <value>A description for your Bonjour forwarding rule. Optional.</value>
		[DataMember(Name = "description", EmitDefaultValue = false)]
		public string Description { get; set; } = null!;

		/// <summary>
		/// The ID of the service VLAN. Required.
		/// </summary>
		/// <value>The ID of the service VLAN. Required.</value>
		[DataMember(Name = "vlanId", EmitDefaultValue = false)]
		public string VlanId { get; set; } = null!;

		/// <summary>
		/// A list of Bonjour services. At least one service must be specified. Available services are &#39;All Services&#39;, &#39;AirPlay&#39;, &#39;AFP&#39;, &#39;BitTorrent&#39;, &#39;FTP&#39;, &#39;iChat&#39;, &#39;iTunes&#39;, &#39;Printers&#39;, &#39;Samba&#39;, &#39;Scanners&#39; and &#39;SSH&#39;
		/// </summary>
		/// <value>A list of Bonjour services. At least one service must be specified. Available services are &#39;All Services&#39;, &#39;AirPlay&#39;, &#39;AFP&#39;, &#39;BitTorrent&#39;, &#39;FTP&#39;, &#39;iChat&#39;, &#39;iTunes&#39;, &#39;Printers&#39;, &#39;Samba&#39;, &#39;Scanners&#39; and &#39;SSH&#39;</value>
		[DataMember(Name = "services", EmitDefaultValue = false)]
		public List<string> Services { get; set; } = new();
	}
}
