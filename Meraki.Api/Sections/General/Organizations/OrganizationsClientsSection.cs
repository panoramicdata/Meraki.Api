namespace Meraki.Api.Sections.General.Organizations;

/// <summary>
/// Provides access to organizations clients API endpoints
/// </summary>
// Codacy analyses each file on its own, so it cannot see the other parts of this class and reports
// 'partial' as gratuitous (S2333). Both are false positives: the remaining parts are emitted by
// RefitClassSourceGenerator, or live in the sibling MerakiClient files.
#pragma warning disable S2333
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
#pragma warning restore S2333
