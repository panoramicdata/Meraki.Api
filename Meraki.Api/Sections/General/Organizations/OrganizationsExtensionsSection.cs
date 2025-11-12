namespace Meraki.Api.Sections.General.Organizations;
/// <summary>
/// Provides access to organizations extensions API endpoints
/// </summary>
public class OrganizationsExtensionsSection
{
	/// <summary>
	/// Gets the sdwan manager
	/// </summary>

	public OrganizationsExtensionsSdwanManagerSection SdwanManager { get; internal set; } = new();

	/// <summary>
	/// List the ThousandEyes agent configurations under this organization. Only valid for networks with access to Meraki Insight. Organization must have a ThousandEyes account connected to perform this action.
	/// </summary>

	public IOrganizationsExtensionsThousandEyes ThousandEyes { get; internal set; } = null!;
}
