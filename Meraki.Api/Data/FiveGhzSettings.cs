namespace Meraki.Api.Data;

/// <summary>
/// Settings related to 5Ghz band
/// </summary>
[DataContract]
public class FiveGhzSettings
{
	/// <summary>
	/// Sets max power (dBm) of 5Ghz band. Can be integer between 8 and 30. Defaults to 30.
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "maxPower")]
	public int? MaxPower { get; set; }

	/// <summary>
	/// Sets min power (dBm) of 5Ghz band. Can be integer between 8 and 30. Defaults to 8.
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "minPower")]
	public int? MinPower { get; set; }

	/// <summary>
	/// Sets min bitrate (Mbps) of 5Ghz band. Can be one of '6', '9', '12', '18', '24', '36', '48' or '54'. Defaults to 12.
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "minBitrate")]
	public int? MinBitrate { get; set; }

	/// <summary>
	/// Sets valid auto channels for 5Ghz band. Can be one of '36', '40', '44', '48', '52', '56', '60', '64', '100', '104', '108', '112', '116', '120', '124', '128', '132', '136', '140', '144', '149', '153', '157', '161' or '165'.Defaults to [36, 40, 44, 48, 52, 56, 60, 64, 100, 104, 108, 112, 116, 120, 124, 128, 132, 136, 140, 144, 149, 153, 157, 161, 165].
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "validAutoChannels")]
	public List<int?> ValidAutoChannels { get; set; } = [];

	/// <summary>
	/// Sets channel width (MHz) for 5Ghz band. Can be one of 'auto', '20', '40' or '80'. Defaults to auto.
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "channelWidth")]
	public string ChannelWidth { get; set; } = string.Empty;

	/// <summary>
	/// The RX-SOP level controls the sensitivity of the radio. It is strongly recommended to use RX-SOP only after     consulting a wireless expert. RX-SOP can be configured in the range of -65 to -95 (dBm). A value of null will     reset this to the default.
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "rxsop")]
	public int? Rxsop { get; set; }

	/// <summary>
	/// Undocumented setting
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "channelPuncturing")]
	public FiveGhzChannelPuncturingSettings? ChannelPuncturing { get; set; }

	/// <summary>
	/// Determines whether 802.11ax is enabled. Undocumented property.
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "axEnabled")]
	public bool? AxEnabled { get; set; }
}
