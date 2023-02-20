namespace Meraki.Api.Data;

/// <summary>
/// UpdateNetworkDeviceWirelessRadioSettings
/// </summary>
[DataContract]
public class WirelessRadioSettings
{
	/// <summary>
	/// Serial
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "serial")]
	public string? Serial { get; set; }

	/// <summary>
	/// The ID of an RF profile to assign to the device. If the value of this parameter is null, the appropriate basic RF profile     (indoor or outdoor) will be assigned to the device. Assigning an RF profile will clear ALL manually configured overrides     on the device (channel width, channel, power).
	/// </summary>
	[ApiForeignKey(typeof(WirelessRfProfile))]
	[JsonProperty(NullValueHandling = NullValueHandling.Include)]
	[DataMember(Name = "rfProfileId")]
	public string? RfProfileId { get; set; }

	/// <summary>
	/// Manual radio settings for 5 GHz.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "fiveGhzSettings")]
	public WirelessRadioFiveGhzSettings FiveGhzSettings { get; set; } = new();

	/// <summary>
	/// Manual radio settings for 2.4 GHz.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "twoFourGhzSettings")]
	public WirelessRadioTwoFourGhzSettings TwoFourGhzSettings { get; set; } = new();
}
