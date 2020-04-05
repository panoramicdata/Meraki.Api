using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// Settings related to 5Ghz band
	/// </summary>
	[DataContract]
	public partial class FiveGhzSettings
	{
		/// <summary>
		/// Sets max power (dBm) of 5Ghz band. Can be integer between 8 and 30. Defaults to 30.
		/// </summary>
		/// <value>Sets max power (dBm) of 5Ghz band. Can be integer between 8 and 30. Defaults to 30.</value>
		[DataMember(Name = "maxPower", EmitDefaultValue = false)]
		public int? MaxPower { get; set; }
		/// <summary>
		/// Sets min power (dBm) of 5Ghz band. Can be integer between 8 and 30. Defaults to 8.
		/// </summary>
		/// <value>Sets min power (dBm) of 5Ghz band. Can be integer between 8 and 30. Defaults to 8.</value>
		[DataMember(Name = "minPower", EmitDefaultValue = false)]
		public int? MinPower { get; set; }
		/// <summary>
		/// Sets min bitrate (Mbps) of 5Ghz band. Can be one of &#39;6&#39;, &#39;9&#39;, &#39;12&#39;, &#39;18&#39;, &#39;24&#39;, &#39;36&#39;, &#39;48&#39; or &#39;54&#39;. Defaults to 12.
		/// </summary>
		/// <value>Sets min bitrate (Mbps) of 5Ghz band. Can be one of &#39;6&#39;, &#39;9&#39;, &#39;12&#39;, &#39;18&#39;, &#39;24&#39;, &#39;36&#39;, &#39;48&#39; or &#39;54&#39;. Defaults to 12.</value>
		[DataMember(Name = "minBitrate", EmitDefaultValue = false)]
		public int? MinBitrate { get; set; }
		/// <summary>
		/// Sets valid auto channels for 5Ghz band. Can be one of &#39;36&#39;, &#39;40&#39;, &#39;44&#39;, &#39;48&#39;, &#39;52&#39;, &#39;56&#39;, &#39;60&#39;, &#39;64&#39;, &#39;100&#39;, &#39;104&#39;, &#39;108&#39;, &#39;112&#39;, &#39;116&#39;, &#39;120&#39;, &#39;124&#39;, &#39;128&#39;, &#39;132&#39;, &#39;136&#39;, &#39;140&#39;, &#39;144&#39;, &#39;149&#39;, &#39;153&#39;, &#39;157&#39;, &#39;161&#39; or &#39;165&#39;.Defaults to [36, 40, 44, 48, 52, 56, 60, 64, 100, 104, 108, 112, 116, 120, 124, 128, 132, 136, 140, 144, 149, 153, 157, 161, 165].
		/// </summary>
		/// <value>Sets valid auto channels for 5Ghz band. Can be one of &#39;36&#39;, &#39;40&#39;, &#39;44&#39;, &#39;48&#39;, &#39;52&#39;, &#39;56&#39;, &#39;60&#39;, &#39;64&#39;, &#39;100&#39;, &#39;104&#39;, &#39;108&#39;, &#39;112&#39;, &#39;116&#39;, &#39;120&#39;, &#39;124&#39;, &#39;128&#39;, &#39;132&#39;, &#39;136&#39;, &#39;140&#39;, &#39;144&#39;, &#39;149&#39;, &#39;153&#39;, &#39;157&#39;, &#39;161&#39; or &#39;165&#39;.Defaults to [36, 40, 44, 48, 52, 56, 60, 64, 100, 104, 108, 112, 116, 120, 124, 128, 132, 136, 140, 144, 149, 153, 157, 161, 165].</value>
		[DataMember(Name = "validAutoChannels", EmitDefaultValue = false)]
		public List<int?> ValidAutoChannels { get; set; }
		/// <summary>
		/// Sets channel width (MHz) for 5Ghz band. Can be one of &#39;auto&#39;, &#39;20&#39;, &#39;40&#39; or &#39;80&#39;. Defaults to auto.
		/// </summary>
		/// <value>Sets channel width (MHz) for 5Ghz band. Can be one of &#39;auto&#39;, &#39;20&#39;, &#39;40&#39; or &#39;80&#39;. Defaults to auto.</value>
		[DataMember(Name = "channelWidth", EmitDefaultValue = false)]
		public string ChannelWidth { get; set; }
		/// <summary>
		/// The RX-SOP level controls the sensitivity of the radio. It is strongly recommended to use RX-SOP only after     consulting a wireless expert. RX-SOP can be configured in the range of -65 to -95 (dBm). A value of null will     reset this to the default.
		/// </summary>
		/// <value>The RX-SOP level controls the sensitivity of the radio. It is strongly recommended to use RX-SOP only after     consulting a wireless expert. RX-SOP can be configured in the range of -65 to -95 (dBm). A value of null will     reset this to the default.</value>
		[DataMember(Name = "rxsop", EmitDefaultValue = false)]
		public int? Rxsop { get; set; }
	}
}
