namespace Meraki.Api.Data;

/// <summary>
/// Device Claim Error
/// </summary>
[DataContract]
public class DeviceClaimError
{
	/// <summary>
	/// The serial number of the device that failed to be claimed
	/// </summary>
	[DataMember(Name = "serial")]
	public string Serial { get; set; } = string.Empty;

	/// <summary>
	/// List of error messages for this device
	/// </summary>
	[DataMember(Name = "errors")]
	public List<string> Errors { get; set; } = [];
}
