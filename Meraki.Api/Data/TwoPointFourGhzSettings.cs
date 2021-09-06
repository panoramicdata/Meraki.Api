using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// Settings related to 2.4Ghz band
	/// </summary>
	[DataContract]
	public class TwoPointFourGhzSettings
	{
		/// <summary>
		/// Sets max power (dBm) of 2.4Ghz band. Can be integer between 5 and 30. Defaults to 30.
		/// </summary>
		/// <value>Sets max power (dBm) of 2.4Ghz band. Can be integer between 5 and 30. Defaults to 30.</value>
		[DataMember(Name = "maxPower", EmitDefaultValue = false)]
		public int? MaxPower { get; set; }

		/// <summary>
		/// Sets min power (dBm) of 2.4Ghz band. Can be integer between 5 and 30. Defaults to 5.
		/// </summary>
		/// <value>Sets min power (dBm) of 2.4Ghz band. Can be integer between 5 and 30. Defaults to 5.</value>
		[DataMember(Name = "minPower", EmitDefaultValue = false)]
		public int? MinPower { get; set; }

		/// <summary>
		/// Sets min bitrate (Mbps) of 2.4Ghz band. Can be one of &#39;1&#39;, &#39;2&#39;, &#39;5.5&#39;, &#39;6&#39;, &#39;9&#39;, &#39;11&#39;, &#39;12&#39;, &#39;18&#39;, &#39;24&#39;, &#39;36&#39;, &#39;48&#39; or &#39;54&#39;. Defaults to 11.
		/// </summary>
		/// <value>Sets min bitrate (Mbps) of 2.4Ghz band. Can be one of &#39;1&#39;, &#39;2&#39;, &#39;5.5&#39;, &#39;6&#39;, &#39;9&#39;, &#39;11&#39;, &#39;12&#39;, &#39;18&#39;, &#39;24&#39;, &#39;36&#39;, &#39;48&#39; or &#39;54&#39;. Defaults to 11.</value>
		[DataMember(Name = "minBitrate", EmitDefaultValue = false)]
		public double? MinBitrate { get; set; }

		/// <summary>
		/// Sets valid auto channels for 2.4Ghz band. Can be one of &#39;1&#39;, &#39;6&#39; or &#39;11&#39;. Defaults to [1, 6, 11].
		/// </summary>
		/// <value>Sets valid auto channels for 2.4Ghz band. Can be one of &#39;1&#39;, &#39;6&#39; or &#39;11&#39;. Defaults to [1, 6, 11].</value>
		[DataMember(Name = "validAutoChannels", EmitDefaultValue = false)]
		public List<int?> ValidAutoChannels { get; set; } = null!;

		/// <summary>
		/// Determines whether ax radio on 2.4Ghz band is on or off. Can be either true or false. If false, we highly recommend disabling band steering. Defaults to true.
		/// </summary>
		/// <value>Determines whether ax radio on 2.4Ghz band is on or off. Can be either true or false. If false, we highly recommend disabling band steering. Defaults to true.</value>
		[DataMember(Name = "axEnabled", EmitDefaultValue = false)]
		public bool? AxEnabled { get; set; }

		/// <summary>
		/// The RX-SOP level controls the sensitivity of the radio. It is strongly recommended to use RX-SOP only after     consulting a wireless expert. RX-SOP can be configured in the range of -65 to -95 (dBm). A value of null will     reset this to the default.
		/// </summary>
		/// <value>The RX-SOP level controls the sensitivity of the radio. It is strongly recommended to use RX-SOP only after     consulting a wireless expert. RX-SOP can be configured in the range of -65 to -95 (dBm). A value of null will     reset this to the default.</value>
		[DataMember(Name = "rxsop", EmitDefaultValue = false)]
		public int? Rxsop { get; set; }
	}
}
