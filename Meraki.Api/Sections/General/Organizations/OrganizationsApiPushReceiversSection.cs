namespace Meraki.Api.Sections.General.Organizations;

/// <summary>
/// Section for Push API receiver operations
/// </summary>
public class OrganizationsApiPushReceiversSection
{
	/// <summary>
	/// Interface for Push API receiver profiles
	/// </summary>
	public IOrganizationsApiPushReceiversProfiles Profiles { get; internal set; } = null!;
}
