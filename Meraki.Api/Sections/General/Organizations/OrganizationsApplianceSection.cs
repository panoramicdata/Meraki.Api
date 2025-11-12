namespace Meraki.Api.Sections.General.Organizations;

/// <summary>
/// Provides access to organizations appliance API endpoints
/// </summary>
public class OrganizationsApplianceSection
{
	/// <summary>
	/// Gets the dns
	/// </summary>

	public OrganizationsApplianceDnsSection Dns { get; internal set; } = new();

	/// <summary>
	/// Get the SDWAN internet traffic preferences for an MX network
	/// </summary>

	public IOrganizationsApplianceSdwan Sdwan { get; internal set; } = null!;

	/// <summary>
	/// Gets the uplinks
	/// </summary>

	public OrganizationsApplianceUplinksSection Uplinks { get; internal set; } = new();

	/// <summary>
	/// List the VLANs for an Organization
	/// </summary>

	public IOrganizationsApplianceVlans Vlans { get; internal set; } = null!;

	/// <summary>
	/// Gets the vpn
	/// </summary>

	public OrganizationsVpnSection Vpn { get; set; } = new();
}
