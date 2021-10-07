using Meraki.Api.Attributes;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// WAN 1 settings
	/// </summary>
	[DataContract]
	public class Wan
	{
		/// <summary>
		/// Gets or Sets WanEnabled - Only for MX devices
		/// </summary>
		[ApiAccess(ApiAccess.ReadUpdate)]
		[DataMember(Name = "wanEnabled")]
		public WanEnabledStatus WanEnabledStatus { get; set; }

		/// <summary>
		/// Configue the interface to have static IP settings or use DHCP.
		/// </summary>
		/// <value>Configue the interface to have static IP settings or use DHCP.</value>
		[ApiAccess(ApiAccess.ReadUpdate)]
		[DataMember(Name = "usingStaticIp")]
		public bool UsingStaticIp { get; set; }

		/// <summary>
		/// The IP the device should use on the WAN.
		/// </summary>
		/// <value>The IP the device should use on the WAN.</value>
		[ApiAccess(ApiAccess.ReadUpdate)]
		[DataMember(Name = "staticIp")]
		public string? StaticIp { get; set; } = null!;

		/// <summary>
		/// The IP of the gateway on the WAN.
		/// </summary>
		/// <value>The IP of the gateway on the WAN.</value>
		[ApiAccess(ApiAccess.ReadUpdate)]
		[DataMember(Name = "staticGatewayIp")]
		public string? StaticGatewayIp { get; set; } = null!;

		/// <summary>
		/// The subnet mask for the WAN.
		/// </summary>
		/// <value>The subnet mask for the WAN.</value>
		[ApiAccess(ApiAccess.ReadUpdate)]
		[DataMember(Name = "staticSubnetMask")]
		public string? StaticSubnetMask { get; set; } = null!;

		/// <summary>
		/// Up to two DNS IPs.
		/// </summary>
		/// <value>Up to two DNS IPs.</value>
		[ApiAccess(ApiAccess.ReadUpdate)]
		[DataMember(Name = "staticDns")]
		public List<string> StaticDns { get; set; } = null!;

		/// <summary>
		/// The VLAN that management traffic should be tagged with. Applies whether usingStaticIp is true or false.
		/// </summary>
		/// <value>The VLAN that management traffic should be tagged with. Applies whether usingStaticIp is true or false.</value>
		[ApiAccess(ApiAccess.ReadUpdate)]
		[DataMember(Name = "vlan")]
		public int? Vlan { get; set; }
	}
}
