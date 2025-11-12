namespace Meraki.Api.Sections.General.Organizations;
/// <summary>
/// Provides access to organizations appliance dns API endpoints
/// </summary>
public class OrganizationsApplianceDnsSection
{
	/// <summary>
	/// Gets the local
	/// </summary>

	public OrganizationsApplianceDnsLocalSection Local { get; internal set; } = new();

	/// <summary>
	/// Gets the split
	/// </summary>

	public OrganizationsApplianceDnsSplitSection Split { get; internal set; } = new();
}
