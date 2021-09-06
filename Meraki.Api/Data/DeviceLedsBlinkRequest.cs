using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// BlinkNetworkDeviceLeds
	/// </summary>
	[DataContract]
	public class DeviceLedsBlinkRequest
	{
		/// <summary>
		/// The duration in seconds. Must be between 5 and 120. Default is 20 seconds
		/// </summary>
		/// <value>The duration in seconds. Must be between 5 and 120. Default is 20 seconds</value>
		[DataMember(Name = "duration", EmitDefaultValue = false)]

		public int? Duration { get; set; }
		/// <summary>
		/// The period in milliseconds. Must be between 100 and 1000. Default is 160 milliseconds
		/// </summary>
		/// <value>The period in milliseconds. Must be between 100 and 1000. Default is 160 milliseconds</value>
		[DataMember(Name = "period", EmitDefaultValue = false)]
		public int? Period { get; set; }

		/// <summary>
		/// The duty cycle as the percent active. Must be between 10 and 90. Default is 50.
		/// </summary>
		/// <value>The duty cycle as the percent active. Must be between 10 and 90. Default is 50.</value>
		[DataMember(Name = "duty", EmitDefaultValue = false)]
		public int? Duty { get; set; }
	}
}