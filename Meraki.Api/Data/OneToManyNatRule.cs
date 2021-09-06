using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// Rule7
	/// </summary>
	[DataContract]
	public class OneToManyNatRule
	{
		/// <summary>
		/// The IP address that will be used to access the internal resource from the WAN
		/// </summary>
		/// <value>The IP address that will be used to access the internal resource from the WAN</value>
		[DataMember(Name = "publicIp", EmitDefaultValue = false)]
		public string PublicIp { get; set; } = null!;

		/// <summary>
		/// Gets or Sets Uplink
		/// </summary>
		[DataMember(Name = "uplink", EmitDefaultValue = false)]
		public WanUplink Uplink { get; set; }

		/// <summary>
		/// An array of associated forwarding rules
		/// </summary>
		/// <value>An array of associated forwarding rules</value>
		[DataMember(Name = "portRules", EmitDefaultValue = false)]
		public List<PortRule> PortRules { get; set; } = null!;
	}
}
