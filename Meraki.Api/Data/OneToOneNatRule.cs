using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// Rule8
	/// </summary>
	[DataContract]
	public class OneToOneNatRule
	{
		/// <summary>
		/// A descriptive name for the rule
		/// </summary>
		/// <value>A descriptive name for the rule</value>
		[DataMember(Name = "name")]
		public string Name { get; set; } = null!;

		/// <summary>
		/// The IP address that will be used to access the internal resource from the WAN
		/// </summary>
		/// <value>The IP address that will be used to access the internal resource from the WAN</value>
		[DataMember(Name = "publicIp")]
		public string PublicIp { get; set; } = null!;

		/// <summary>
		/// The IP address of the server or device that hosts the internal resource that you wish to make available on the WAN
		/// </summary>
		/// <value>The IP address of the server or device that hosts the internal resource that you wish to make available on the WAN</value>
		[DataMember(Name = "lanIp")]
		public string LanIp { get; set; } = null!;

		/// <summary>
		/// Gets or Sets Uplink
		/// </summary>
		[DataMember(Name = "uplink")]
		public WanUplink Uplink { get; set; }

		/// <summary>
		/// The ports this mapping will provide access on, and the remote IPs that will be allowed access to the resource
		/// </summary>
		/// <value>The ports this mapping will provide access on, and the remote IPs that will be allowed access to the resource</value>
		[DataMember(Name = "allowedInbound")]
		public List<AllowedInbound> AllowedInbound { get; set; } = null!;
	}
}
