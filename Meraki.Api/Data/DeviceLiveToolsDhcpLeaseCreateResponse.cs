namespace Meraki.Api.Data;

/// <summary>
/// Device Live Tools DHCP Lease Create Response
/// </summary>
[DataContract]
public class DeviceLiveToolsDhcpLeaseCreateResponse
{
	/// <summary>
	/// Id of the DHCP leases request. Used to check the status of the request.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "dhcpLeasesId")]
	public string DhcpLeasesId { get; set; } = string.Empty;

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
	/// Information for callback used to send back results
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "callback")]
	public DeviceLiveToolsDhcpLeaseCreateResponseCallback Callback { get; set; } = new();

	/// <summary>
	/// DHCP leases request parameters
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "request")]
	public DeviceLiveToolsDhcpLeaseCreateResponseRequest Request { get; set; } = new();
}
