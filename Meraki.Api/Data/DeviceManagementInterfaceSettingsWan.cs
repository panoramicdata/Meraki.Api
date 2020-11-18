using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// DeviceManagementInterfaceSettingsWan1
	/// </summary>
	[DataContract]
	public class DeviceManagementInterfaceSettingsWan
	{
		/// <summary>
		/// Is WAN enabled
		/// </summary>
		[DataMember(Name = "wanEnabled")]
		public bool WanEnabled { get; set; }

		/// <summary>
		/// Is WAN using static IP
		/// </summary>
		[DataMember(Name = "usingStaticIp")]
		public bool UsingStaticIp { get; set; }

		/// <summary>
		/// The static IP
		/// </summary>
		[DataMember(Name = "staticIp")]
		public string StaticIp { get; set; }

		/// <summary>
		/// The static subnet mask
		/// </summary>
		[DataMember(Name = "staticSubnetMask")]
		public string StaticSubnetMask { get; set; }

		/// <summary>
		/// The static gateway IP
		/// </summary>
		[DataMember(Name = "staticGatewayIp")]
		public string StaticGatewayIp { get; set; }

		/// <summary>
		/// The static DNS
		/// </summary>
		[DataMember(Name = "staticDns")]
		public List<string> StaticDns { get; set; }

		/// <summary>
		/// The VLAN
		/// </summary>
		[DataMember(Name = "vlan")]
		public string Vlan { get; set; }
	}
}