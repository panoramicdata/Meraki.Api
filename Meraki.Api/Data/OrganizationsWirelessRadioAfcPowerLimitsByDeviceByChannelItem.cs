namespace Meraki.Api.Data;

/// <summary>
/// Power limit of a 6 GHz channel.
/// </summary>
[DataContract]
public class OrganizationsWirelessRadioAfcPowerLimitsByDeviceByChannelItem
{
	/// <summary>
	/// Wireless center channel number
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "channel")]
	public int Channel { get; set; }

	/// <summary>
	/// Channel width
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "channelWidth")]
	public int ChannelWidth { get; set; }

	/// <summary>
	/// Channel's power limit in decibel milliwats (dBm)
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "limit")]
	public int Limit { get; set; }
}
