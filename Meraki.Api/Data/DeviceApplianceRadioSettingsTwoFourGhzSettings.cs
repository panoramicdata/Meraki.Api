namespace Meraki.Api.Data;
/// <summary>
/// Manual radio settings for 2.4 GHz
/// </summary>
[DataContract]

public class DeviceApplianceRadioSettingsTwoFourGhzSettings
{
	/// <summary>
	/// Manual channel for 2.4 GHz
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "channel")]
	public int? Channel { get; set; }

	/// <summary>
	/// Manual target power for 2.4 GHz
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "targetPower")]
	public int? TargetPower { get; set; }
}