namespace Meraki.Api.Data;

/// <summary>
/// Ssids Statuses By Device Item Basic Service Set Radio
/// </summary>
[DataContract]
public class SsidsStatusesByDeviceItemBasicServiceSetRadio
{
	/// <summary>
	/// Frequency channel used for wireless communication.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "channel")]
	public int Channel { get; set; }

	/// <summary>
	/// Width of frequency channel used for wireless communication.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "channelWidth")]
	public int ChannelWidth { get; set; }

	/// <summary>
	/// Strength of wireless signal.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "power")]
	public int Power { get; set; }

	/// <summary>
	/// Frequency range used for wireless communication.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "band")]
	public Band Band { get; set; }

	/// <summary>
	/// Indicates whether or not this radio is currently broadcasting.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "isBroadcasting")]
	public bool IsBroadcasting { get; set; }
}
