using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Meraki.Api.Data
{
	/// <summary>
	/// Uplink bandwidth
	/// </summary>
	[DataContract]
	public class UplinkBandwidth
	{
		/// <summary>
		/// Bandwidth limits
		/// </summary>
		[DataMember(Name = "bandwidthLimits")]
		public BandwidthLimits7 BandwidthLimits { get; set; } = new();
	}
}
