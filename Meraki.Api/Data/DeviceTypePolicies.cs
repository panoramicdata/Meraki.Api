using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Meraki.Api.Data
{
	/// <summary>
	/// Device type policies
	/// </summary>
	[DataContract]
	public partial class DeviceTypePolicies
	{
		/// <summary>
		/// Device type
		/// </summary>
		[DataMember(Name = "deviceType")]
		public string DeviceType { get; set; } = string.Empty;

		/// <summary>
		/// Device policy
		/// </summary>
		[DataMember(Name = "devicePolicy")]
		public string DevicePolicy { get; set; } = string.Empty;

		/// <summary>
		/// Device type
		/// </summary>
		[DataMember(Name = "groupPolicyId")]
		public int? GroupPolicyId { get; set; }
	}
}
