using System.Runtime.Serialization;

namespace Meraki.Api.Data;

/// <summary>
/// UpdateNetworkDeviceWirelessRadioSettings
/// </summary>
[DataContract]
public class WirelessRadioSettingsUpdateRequest
{
	/// <summary>
	/// Serial
	/// </summary>
	[DataMember(Name = "serial")]
	public string? Serial { get; set; }

	/// <summary>
	/// The ID of an RF profile to assign to the device. If the value of this parameter is null, the appropriate basic RF profile     (indoor or outdoor) will be assigned to the device. Assigning an RF profile will clear ALL manually configured overrides     on the device (channel width, channel, power).
	/// </summary>
	/// <value>The ID of an RF profile to assign to the device. If the value of this parameter is null, the appropriate basic RF profile     (indoor or outdoor) will be assigned to the device. Assigning an RF profile will clear ALL manually configured overrides     on the device (channel width, channel, power).</value>
	[DataMember(Name = "rfProfileId")]
	public int? RfProfileId { get; set; }

	/// <summary>
	/// Manual radio settings for 5 GHz.
	/// </summary>
	[DataMember(Name = "fiveGhzSettings")]
	public RadioGhzSettings FiveGhzSettings { get; set; } = new();

	/// <summary>
	/// Manual radio settings for 2.4 GHz.
	/// </summary>
	[DataMember(Name = "twoFourGhzSettings")]
	public RadioGhzSettings TwoFourGhzSettings { get; set; } = new();
}
