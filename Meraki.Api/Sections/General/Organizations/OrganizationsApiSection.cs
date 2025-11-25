namespace Meraki.Api.Sections.General.Organizations;

/// <summary>
/// Section for organization API operations
/// </summary>
public class OrganizationsApiSection
{
	/// <summary>
	/// Section for Push API operations
	/// </summary>
	public OrganizationsApiPushSection Push { get; internal set; } = new();
}
