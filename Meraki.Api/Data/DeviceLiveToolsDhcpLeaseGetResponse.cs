namespace Meraki.Api.Data;

/// <summary>
/// Device Live Tools DHCP Lease Get Response
/// </summary>
[DataContract]
public class DeviceLiveToolsDhcpLeaseGetResponse
{
	/// <summary>
	/// Id of the DHCP leases request. Used to check the status of the request.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "dhcpLeasesId")]
	public string DhcpLeasesId { get; set; } = string.Empty;

	/// <summary>
	/// An error message for a failed execution
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "error")]
	public string Error { get; set; } = string.Empty;

	/// <summary>
	/// Status of the DHCP leases request. enum = ["complete", "failed", "new", "ready", "running", ...]
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "status")]
	public string Status { get; set; } = string.Empty;

	/// <summary>
	/// GET this url to check the status of your DHCP leases request.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "url")]
	public string Url { get; set; } = string.Empty;

	/// <summary>
	/// DHCP leases request parameters
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "request")]
	public DeviceLiveToolsDhcpLeaseGetResponseRequest Request { get; set; } = new();

	/// <summary>
	/// Results of the DHCP leases request
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "dhcpLeases")]
	public List<DeviceLiveToolsDhcpLeaseGetResponseDhcpLease> DhcpLeases { get; set; } = [];
}
