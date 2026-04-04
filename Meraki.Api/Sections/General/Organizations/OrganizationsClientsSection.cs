namespace Meraki.Api.Sections.General.Organizations;

/// <summary>
/// Provides access to organizations clients API endpoints
/// </summary>
public partial class OrganizationsClientsSection
{
	/// <summary>
	/// Interface for client search and details.
	/// </summary>
	[RefitPromoteCalls]
	internal IOrganizationsClients Clients { get; set; } = null!;

	/// <summary>
	/// Interface for client bandwidth usage history.
	/// </summary>
	public IOrganizationBandwidthUsageHistory BandwidthUsageHistory { get; internal set; } = null!;

	/// <summary>
	/// Interface for client overview information.
	/// </summary>
	public IOrganizationsClientOverview Overview { get; internal set; } = null!;
}
