using Meraki.Api.Attributes;
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
		[ApiAccess(ApiAccess.ReadUpdate)]
		[DataMember(Name = "publicIp")]
		public string PublicIp { get; set; } = null!;

		/// <summary>
		/// Gets or Sets Uplink
		/// </summary>
		[ApiAccess(ApiAccess.ReadUpdate)]
		[DataMember(Name = "uplink")]
		public WanUplink Uplink { get; set; }

		/// <summary>
		/// An array of associated forwarding rules
		/// </summary>
		[ApiAccess(ApiAccess.ReadUpdate)]
		[DataMember(Name = "portRules")]
		public List<PortRule> PortRules { get; set; } = null!;
	}
}
