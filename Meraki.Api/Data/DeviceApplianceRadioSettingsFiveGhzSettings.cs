namespace Meraki.Api.Data;
/// <summary>
/// Manual radio settings for 5 GHz
/// </summary>
[DataContract]

public class DeviceApplianceRadioSettingsFiveGhzSettings
{
	/// <summary>
	/// Manual channel for 5 GHz
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "channel")]
	public int? Channel { get; set; }

	/// <summary>
	/// Manual channel width for 5 GHz
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "channelWidth")]
	public int? ChannelWidth { get; set; }

	/// <summary>
	/// Manual target power for 5 GHz
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "targetPower")]
	public int? TargetPower { get; set; }
}