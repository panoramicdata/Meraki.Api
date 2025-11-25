namespace Meraki.Api.Sections.General.Organizations;

/// <summary>
/// Section for Push API operations
/// </summary>
public class OrganizationsApiPushSection
{
	/// <summary>
	/// Interface for Push API topics
	/// </summary>
	public IOrganizationsApiPushTopics Topics { get; internal set; } = null!;

	/// <summary>
	/// Section for Push API receiver operations
	/// </summary>
	public OrganizationsApiPushReceiversSection Receivers { get; internal set; } = new();

	/// <summary>
	/// Interface for Push API profiles
	/// </summary>
	public IOrganizationsApiPushProfiles Profiles { get; internal set; } = null!;
}
