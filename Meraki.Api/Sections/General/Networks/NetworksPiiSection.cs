namespace Meraki.Api.Sections.General.Networks;

/// <summary>
/// Provides access to networks pii API endpoints
/// </summary>
public class NetworksPiiSection
{
	/// <summary>
	/// List the keys required to access Personally Identifiable Information (PII) for a given identifier
	/// </summary>

	public INetworksPiiPiiKeys PiiKeys { get; internal set; } = null!;
	/// <summary>
	/// List the PII requests for this network or organization
	/// </summary>

	public INetworksPiiRequests Requests { get; internal set; } = null!;
	/// <summary>
	/// Given a piece of Personally Identifiable Information (PII), return the Systems Manager device ID(s) associated with that identifier
	/// </summary>

	public INetworksPiiSmDevicesForKey SmDevicesForKey { get; internal set; } = null!;
	/// <summary>
	/// Given a piece of Personally Identifiable Information (PII), return the Systems Manager owner ID(s) associated with that identifier
	/// </summary>

	public INetworksPiiSmOwnersForKey SmOwnersForKey { get; internal set; } = null!;
}
