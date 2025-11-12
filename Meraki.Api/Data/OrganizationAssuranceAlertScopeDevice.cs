namespace Meraki.Api.Data;

/// <summary>
/// Organization Assurance Alert Scope Device
/// </summary>
[DataContract]
public class OrganizationAssuranceAlertScopeDevice
{
	/// <summary>
	/// Order of affected device in array
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "order")]
	public int Order { get; set; }

	/// <summary>
	/// IMEI of affected device
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "imei")]
	public string Imei { get; set; } = string.Empty;

	/// <summary>
	/// MAC address of affected device
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "mac")]
	public string Mac { get; set; } = string.Empty;

	/// <summary>
	/// Name of affected device
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;

	/// <summary>
	/// Type of affected device
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "type")]
	public string Type { get; set; } = string.Empty;

	/// <summary>
	/// Serial of affected device
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "serial")]
	public string Serial { get; set; } = string.Empty;

	/// <summary>
	/// URL of affected device
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "url")]
	public string Url { get; set; } = string.Empty;

	/// <summary>
	/// Port of affected device
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "lldp")]
	public OrganizationAssuranceAlertScopeDeviceLldp Lldp { get; set; } = new();
}
