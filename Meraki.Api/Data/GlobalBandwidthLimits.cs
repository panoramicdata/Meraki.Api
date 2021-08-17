using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// Global bandwidth limits
	/// </summary>
	[DataContract]
	public class GlobalBandwidthLimits
	{
		/// <summary>
		/// Limit up
		/// </summary>
		[DataMember(Name = "limitUp")]
		public int LimitUp { get; set; } = 0;

		/// <summary>
		/// Limit down
		/// </summary>
		[DataMember(Name = "limitDown")]
		public int LimitDown { get; set; } = 0;
	}
}
