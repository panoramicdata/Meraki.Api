namespace Meraki.Api.Data;

/// <summary>
/// Settings related to 6Ghz band. Only applicable to networks with 6Ghz capable APs
/// </summary>
[DataContract]
public class SixGhzSettings
{
	/// <summary>
	/// Sets max power (dBm) of 6Ghz band. Can be integer between 2 and 30. Defaults to 30.
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "maxPower")]
	public int? MaxPower { get; set; }

	/// <summary>
	/// Sets min power (dBm) of 6Ghz band. Can be integer between 2 and 30. Defaults to 8.
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "minPower")]
	public int? MinPower { get; set; }

	/// <summary>
	/// Sets min bitrate (Mbps) of 6Ghz band. Can be one of '6', '9', '12', '18', '24', '36', '48' or '54'. Defaults to 12.
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "minBitrate")]
	public int? MinBitrate { get; set; }

	/// <summary>
	/// Sets valid auto channels for 6Ghz band. Can be one of '1', '5', '9', '13', '17', '21', '25', '29', '33', '37', '41', '45', '49', '53', '57', '61', '65', '69', '73', '77', '81', '85', '89', '93', '97', '101', '105', '109', '113', '117', '121', '125', '129', '133', '137', '141', '145', '149', '153', '157', '161', '165', '169', '173', '177', '181', '185', '189', '193', '197', '201', '205', '209', '213', '217', '221', '225', '229' or '233'. Defaults to auto.
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "validAutoChannels")]
	public List<int>? ValidAutoChannels { get; set; }

	/// <summary>
	/// Sets channel width (MHz) for 6Ghz band. Can be one of '0', '20', '40', '80' or '160'. Defaults to auto.
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "channelWidth")]
	public string? ChannelWidth { get; set; }

	/// <summary>
	/// The RX-SOP level controls the sensitivity of the radio. It is strongly recommended to use RX-SOP only after     consulting a wireless expert. RX-SOP can be configured in the range of -65 to -95 (dBm). A value of null will     reset this to the default.
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "rxsop")]
	public int? Rxsop { get; set; }

	/// <summary>
	/// afcEnabled - Undocumented
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "afcEnabled")]
	public bool AfcEnabled { get; set; }
}
