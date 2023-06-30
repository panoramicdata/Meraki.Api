namespace Meraki.Api.Data;
/// <summary>
/// Update the radio settings of an appliance
/// </summary>
[DataContract]

public class DeviceApplianceRadioSettingsUpdate
{
	/// <summary>
	/// RF Profile ID
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "rfProfileId")]
	public string? RfProfileId { get; set; }

	/// <summary>
	/// Manual radio settings for 5 GHz
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "fiveGhzSettings")]
	public DeviceApplianceRadioSettingsFiveGhzSettings? FiveGhzSettings { get; set; }

	/// <summary>
	/// Manual radio settings for 2.4 GHz
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "twoFourGhzSettings")]
	public DeviceApplianceRadioSettingsTwoFourGhzSettings? TwoFourGhzSettings { get; set; }
}