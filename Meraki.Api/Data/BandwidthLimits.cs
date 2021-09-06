using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// The bandwidth settings for the &#39;cellular&#39; uplink
	/// </summary>
	[DataContract]
	public class BandwidthLimits
	{
		/// <summary>
		/// The maximum upload limit (integer, in Kbps). null indicates no limit
		/// </summary>
		/// <value>The maximum upload limit (integer, in Kbps). null indicates no limit</value>
		[DataMember(Name = "limitUp")]
		public int? LimitUp { get; set; }
		/// <summary>
		/// The maximum download limit (integer, in Kbps). null indicates no limit
		/// </summary>
		/// <value>The maximum download limit (integer, in Kbps). null indicates no limit</value>
		[DataMember(Name = "limitDown")]
		public int? LimitDown { get; set; }
	}
}
