namespace Meraki.Api.Data;

/// <summary>
/// Organization Appliance Dns Local Records Update Request
/// </summary>
[DataContract]
public class OrganizationApplianceDnsLocalRecordsUpdateRequest
{
	/// <summary>
	/// IP for the DNS record
	/// </summary>
	[DataMember(Name = "address")]
	public string? Address { get; set; }

	/// <summary>
	/// Hostname for the DNS record
	/// </summary>
	[DataMember(Name = "hostname")]
	public string? Hostname { get; set; }

	/// <summary>
	/// The profile the DNS record is associated with
	/// </summary>
	[DataMember(Name = "profile")]
	public OrganizationApplianceDnsLocalRecordsProfile? Profile { get; set; }
}
