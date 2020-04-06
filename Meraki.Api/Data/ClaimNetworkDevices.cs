using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// ClaimNetworkDevices
	/// </summary>
	[DataContract]
	public partial class DeviceClaimRequest
	{
		/// <summary>
		/// A list of serials of devices to claim
		/// </summary>
		/// <value>A list of serials of devices to claim</value>
		[DataMember(Name = "serials", EmitDefaultValue = false)]
		public List<string> Serials { get; set; } = new List<string>();
	}
}
