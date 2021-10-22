using Meraki.Api.Attributes;
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
		[ApiAccess(ApiAccess.ReadUpdate)]
		[DataMember(Name = "name")]
		public string Name { get; set; } = string.Empty;

		/// <summary>
		/// The IP address that will be used to access the internal resource from the WAN
		/// </summary>
		[ApiAccess(ApiAccess.ReadUpdate)]
		[DataMember(Name = "publicIp")]
		public string PublicIp { get; set; } = string.Empty;

		/// <summary>
		/// The IP address of the server or device that hosts the internal resource that you wish to make available on the WAN
		/// </summary>
		[ApiAccess(ApiAccess.ReadUpdate)]
		[DataMember(Name = "lanIp")]
		public string LanIp { get; set; } = string.Empty;

		/// <summary>
		/// Gets or Sets Uplink
		/// </summary>
		[ApiAccess(ApiAccess.ReadUpdate)]
		[DataMember(Name = "uplink")]
		public WanUplink Uplink { get; set; }

		/// <summary>
		/// The ports this mapping will provide access on, and the remote IPs that will be allowed access to the resource
		/// </summary>
		[ApiAccess(ApiAccess.ReadUpdate)]
		[DataMember(Name = "allowedInbound")]
		public List<AllowedInbound> AllowedInbounds { get; set; } = new();
	}
}
