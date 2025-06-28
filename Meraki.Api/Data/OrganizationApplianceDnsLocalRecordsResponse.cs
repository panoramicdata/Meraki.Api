namespace Meraki.Api.Data;

/// <summary>
/// Organization Appliance Dns Local Records Response
/// </summary>
[DataContract]
public class OrganizationApplianceDnsLocalRecordsResponse
{
	/// <summary>
	/// IP for the DNS record
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "address")]
	public string Address { get; set; } = string.Empty;

	/// <summary>
	/// Hostname for the DNS record
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "hostname")]
	public string Hostname { get; set; } = string.Empty;

	/// <summary>
	/// Record ID
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "recordId")]
	public string RecordId { get; set; } = string.Empty;

	/// <summary>
	/// The profile the DNS record is associated with
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "profile")]
	public OrganizationApplianceDnsLocalRecordsProfile Profile { get; set; } = new();
}
