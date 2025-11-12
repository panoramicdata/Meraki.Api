namespace Meraki.Api.Sections.General.Organizations;

/// <summary>
/// Provides access to organizations appliance dns split API endpoints
/// </summary>
public class OrganizationsApplianceDnsSplitSection
{
	/// <summary>
	/// Fetch the split DNS profiles used in the organization
	/// </summary>

	public IOrganizationsApplianceDnsSplitProfiles Profiles { get; internal set; } = null!;
}
