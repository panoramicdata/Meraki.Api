namespace Meraki.Api.Data;

/// <summary>
/// Settings related to 2.4Ghz band
/// </summary>
[DataContract]
public class TwoPointFourGhzSettings
{
	/// <summary>
	/// Sets max power (dBm) of 2.4Ghz band. Can be integer between 5 and 30. Defaults to 30.
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "maxPower")]
	public int? MaxPower { get; set; }

	/// <summary>
	/// Sets min power (dBm) of 2.4Ghz band. Can be integer between 5 and 30. Defaults to 5.
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "minPower")]
	public int? MinPower { get; set; }

	/// <summary>
	/// Sets min bitrate (Mbps) of 2.4Ghz band. Can be one of '1', '2', '5.5', '6', '9', '11', '12', '18', '24', '36', '48' or '54'. Defaults to 11.
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "minBitrate")]
	public double? MinBitrate { get; set; }

	/// <summary>
	/// Sets valid auto channels for 2.4Ghz band. Can be one of '1', '6' or '11'. Defaults to [1, 6, 11].
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "validAutoChannels")]
	public List<int?> ValidAutoChannels { get; set; } = [];

	/// <summary>
	/// Determines whether ax radio on 2.4Ghz band is on or off. Can be either true or false. If false, we highly recommend disabling band steering. Defaults to true.
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "axEnabled")]
	public bool? AxEnabled { get; set; }

	/// <summary>
	/// The RX-SOP level controls the sensitivity of the radio. It is strongly recommended to use RX-SOP only after     consulting a wireless expert. RX-SOP can be configured in the range of -65 to -95 (dBm). A value of null will     reset this to the default.
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "rxsop")]
	public int? Rxsop { get; set; }
}
