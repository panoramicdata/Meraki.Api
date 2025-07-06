namespace Meraki.Api.Data;

/// <summary>
/// Organization appliance DNS local records create request
/// </summary>
[DataContract]
public class OrganizationApplianceDnsLocalRecordsCreateRequest
{
	/// <summary>
	/// IP for the DNS record
	/// </summary>
	[DataMember(Name = "address")]
	public string Address { get; set; } = string.Empty;

	/// <summary>
	/// Hostname for the DNS record
	/// </summary>
	[DataMember(Name = "hostname")]
	public string Hostname { get; set; } = string.Empty;

	/// <summary>
	/// The profile the DNS record is associated with
	/// </summary>
	[DataMember(Name = "profile")]
	public OrganizationApplianceDnsLocalRecordsProfile Profile { get; set; } = new();
}
