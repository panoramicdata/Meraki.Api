using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// Subnet
	/// </summary>
	[DataContract]
	public class Subnet
	{
		/// <summary>
		/// The CIDR notation subnet used within the VPN
		/// </summary>
		/// <value>The CIDR notation subnet used within the VPN</value>
		[DataMember(Name = "localSubnet")]
		public string LocalSubnet { get; set; } = null!;

		/// <summary>
		/// Indicates the presence of the subnet in the VPN
		/// </summary>
		/// <value>Indicates the presence of the subnet in the VPN</value>
		[DataMember(Name = "useVpn")]
		public bool? UseVpn { get; set; }
	}
}
