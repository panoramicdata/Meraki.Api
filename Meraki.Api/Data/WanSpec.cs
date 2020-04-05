using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// WAN 1 settings
	/// </summary>
	[DataContract]
	public partial class Wan
	{
		/// <summary>
		/// Gets or Sets WanEnabled
		/// </summary>
		[DataMember(Name = "wanEnabled", EmitDefaultValue = false)]
		public WanEnabledStatus WanEnabledStatus { get; set; }

		/// <summary>
		/// Configue the interface to have static IP settings or use DHCP.
		/// </summary>
		/// <value>Configue the interface to have static IP settings or use DHCP.</value>
		[DataMember(Name = "usingStaticIp", EmitDefaultValue = false)]
		public bool? UsingStaticIp { get; set; }

		/// <summary>
		/// The IP the device should use on the WAN.
		/// </summary>
		/// <value>The IP the device should use on the WAN.</value>
		[DataMember(Name = "staticIp", EmitDefaultValue = false)]
		public string StaticIp { get; set; } = null!;

		/// <summary>
		/// The IP of the gateway on the WAN.
		/// </summary>
		/// <value>The IP of the gateway on the WAN.</value>
		[DataMember(Name = "staticGatewayIp", EmitDefaultValue = false)]
		public string StaticGatewayIp { get; set; } = null!;

		/// <summary>
		/// The subnet mask for the WAN.
		/// </summary>
		/// <value>The subnet mask for the WAN.</value>
		[DataMember(Name = "staticSubnetMask", EmitDefaultValue = false)]
		public string StaticSubnetMask { get; set; } = null!;

		/// <summary>
		/// Up to two DNS IPs.
		/// </summary>
		/// <value>Up to two DNS IPs.</value>
		[DataMember(Name = "staticDns", EmitDefaultValue = false)]
		public List<string> StaticDns { get; set; } = null!;

		/// <summary>
		/// The VLAN that management traffic should be tagged with. Applies whether usingStaticIp is true or false.
		/// </summary>
		/// <value>The VLAN that management traffic should be tagged with. Applies whether usingStaticIp is true or false.</value>
		[DataMember(Name = "vlan", EmitDefaultValue = false)]
		public int? Vlan { get; set; }
	}
}
