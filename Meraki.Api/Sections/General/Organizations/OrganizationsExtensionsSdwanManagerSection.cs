namespace Meraki.Api.Sections.General.Organizations;

/// <summary>
/// Provides access to organizations extensions sdwan manager API endpoints
/// </summary>
public class OrganizationsExtensionsSdwanManagerSection
{
	/// <summary>
	/// Update name and status of an Interconnect
	/// </summary>

	public IOrganizationsExtensionsSdwanManagerInterconnects Interconnects { get; internal set; } = null!;
}
