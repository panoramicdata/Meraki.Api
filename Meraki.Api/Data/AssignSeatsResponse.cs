namespace Meraki.Api.Data;

/// <summary>
/// Response
/// </summary>
[DataContract]
public class AssignSeatsResponse
{
	/// <summary>
	/// Resulting licenses
	/// </summary>
	[ApiAccess(ApiAccess.ReadCreate)]
	[DataMember(Name = "resultingLicenses")]
	public List<OrganizationLicense> ResultingLicenses { get; set; } = [];
}
