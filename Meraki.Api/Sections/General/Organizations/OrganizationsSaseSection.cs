namespace Meraki.Api.Sections.General.Organizations;
/// <summary>
/// Provides access to organizations sase API endpoints
/// </summary>
public class OrganizationsSaseSection
{
	/// <summary>
	/// List of MX networks or templates that can be enrolled into Secure Access
	/// </summary>

	public IOrganizationsSaseConnectivity Connectivity { get; internal set; } = null!;
}
