namespace Meraki.Api.Data;

/// <summary>
/// Device Live Tools DHCP Lease Create Request
/// </summary>
[DataContract]
public class DeviceLiveToolsDhcpLeaseCreateRequest
{
	/// <summary>
	/// Details for the callback. Please include either an httpServerId OR url and sharedSecret
	/// </summary>
	[DataMember(Name = "callback")]
	public DeviceLiveToolsDhcpLeaseCreateRequestCallback? Callback { get; set; }
}
