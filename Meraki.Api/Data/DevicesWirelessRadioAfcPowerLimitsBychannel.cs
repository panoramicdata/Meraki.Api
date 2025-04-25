namespace Meraki.Api.Data;

/// <summary>
/// Power limits of each 6 GHz channel
/// </summary>
public class DevicesWirelessRadioAfcPowerLimitsBychannel
{
	/// <summary>
	/// Wireless center channel number
	/// </summary>
	[DataMember(Name = "channel")]
	public int Channel { get; set; }

	/// <summary>
	/// Channel width
	/// </summary>
	[DataMember(Name = "channelWidth")]
	public int ChannelWidth { get; set; }

	/// <summary>
	/// Channel's power limit in decibel milliwats (dBm)
	/// </summary>
	[DataMember(Name = "limit")]
	public int Limit { get; set; }
}
