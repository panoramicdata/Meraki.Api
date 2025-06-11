namespace Meraki.Api.Data;

/// <summary>
/// DHCP leases request parameters
/// </summary>
[DataContract]
public class DeviceLiveToolsDhcpLeaseGetResponseRequest
{
	/// <summary>
	/// Device serial number
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "serial")]
	public string Serial { get; set; } = string.Empty;
}