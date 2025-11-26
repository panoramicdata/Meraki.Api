namespace Meraki.Api.Data;

/// <summary>
/// Device Claim Response
/// </summary>
[ApiAccessReadOnlyClass]
[DataContract]
public class DeviceClaimResponse
{
	/// <summary>
	/// List of serial numbers that were successfully claimed
	/// </summary>
	[DataMember(Name = "serials")]
	public List<string> Serials { get; set; } = [];

	/// <summary>
	/// List of errors for devices that failed to be claimed
	/// </summary>
	[DataMember(Name = "errors")]
	public List<DeviceClaimError> Errors { get; set; } = [];
}
