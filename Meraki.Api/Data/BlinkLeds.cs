using Meraki.Api.Attributes;
using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// BlinkNetworkDeviceLeds
	/// </summary>
	[DataContract]
	public class BlinkLeds
	{
		/// <summary>
		/// The duration in seconds. Must be between 5 and 120. Default is 20 seconds
		/// </summary>
		[ApiAccess(ApiAccess.Create)]
		[DataMember(Name = "duration")]

		public int? Duration { get; set; }
		/// <summary>
		/// The period in milliseconds. Must be between 100 and 1000. Default is 160 milliseconds
		/// </summary>
		[ApiAccess(ApiAccess.Create)]
		[DataMember(Name = "period")]
		public int? Period { get; set; }

		/// <summary>
		/// The duty cycle as the percent active. Must be between 10 and 90. Default is 50.
		/// </summary>
		[ApiAccess(ApiAccess.Create)]
		[DataMember(Name = "duty")]
		public int? Duty { get; set; }
	}
}