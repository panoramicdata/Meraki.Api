namespace Meraki.Api.Data;

/// <summary>
/// The profile the DNS record is associated with
/// </summary>
[DataContract]
public class OrganizationApplianceDnsLocalRecordsProfile
{
	/// <summary>
	/// Profile ID
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "id")]
	public string Id { get; set; } = string.Empty;
}