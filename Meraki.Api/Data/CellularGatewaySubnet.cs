using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Meraki.Api.Data
{
	/// <summary>
	/// Subnet
	/// </summary>
	[DataContract]
	public class CellularGatewaySubnet
	{
		/// <summary>
		/// Serial
		/// </summary>
		[DataMember(Name = "serial")]
		public string Serial { get; set; } = string.Empty;

		/// <summary>
		/// Name
		/// </summary>
		[DataMember(Name = "name")]
		public string Name { get; set; } = string.Empty;

		/// <summary>
		/// Appliance ip
		/// </summary>
		[DataMember(Name = "applianceIp")]
		public string ApplianceIp { get; set; } = string.Empty;

		/// <summary>
		/// Subnet
		/// </summary>
		[DataMember(Name = "subnet")]
		public string Subnet { get; set; } = string.Empty;
	}
}
