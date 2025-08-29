namespace Meraki.Api.Data;

/// <summary>
/// ClaimNetworkDevices
/// </summary>
[DataContract]
public class DeviceClaimRequest
{
	/// <summary>
	/// A list of serials of devices to claim
	/// </summary>
	/// <value>A list of serials of devices to claim</value>
	[DataMember(Name = "serials")]
	public List<string> Serials { get; set; } = [];

	/// <summary>
	/// Optional details for claimed devices (currently only used for Catalyst devices)
	/// </summary>
	[DataMember(Name = "detailsByDevice")]
	public List<DeviceClaimRequestDeviceDetails>? DetailsByDevice { get; set; }
}
