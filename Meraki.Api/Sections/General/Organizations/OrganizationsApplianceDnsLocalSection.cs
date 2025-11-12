namespace Meraki.Api.Sections.General.Organizations;

/// <summary>
/// Provides access to organizations appliance dns local API endpoints
/// </summary>
public class OrganizationsApplianceDnsLocalSection
{
	/// <summary>
	/// Fetch the local DNS profile assignments in the organization
	/// </summary>

	public IOrganizationsApplianceDnsLocalProfiles Profiles { get; internal set; } = null!;

	/// <summary>
	/// Gets the records
	/// </summary>

	public IOrganizationsApplianceDnsLocalRecord Records { get; set; } = null!;
}
