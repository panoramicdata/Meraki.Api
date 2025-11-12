using Meraki.Api.Interfaces.SecureConnect.Policies;

namespace Meraki.Api.Sections.SecureConnect;
/// <summary>
/// Provides access to secure connect policies API endpoints
/// </summary>
public class SecureConnectPoliciesSection
{
	/// <summary>
	/// Get the destination lists in your organization.
	/// </summary>

	public ISecureConnectPoliciesDestinationLists DestinationLists { get; internal set; } = null!;
	/// <summary>
	/// Get destinations in a destination list.
	/// </summary>

	public ISecureConnectPoliciesDestinations Destinations { get; internal set; } = null!;
}
