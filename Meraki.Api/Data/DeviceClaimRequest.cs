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
	public List<string> Serials { get; set; } = new List<string>();
}
