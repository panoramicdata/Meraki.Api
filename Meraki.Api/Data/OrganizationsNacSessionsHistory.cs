namespace Meraki.Api.Data;

/// <summary>
/// Organizations NAC Sessions History
/// </summary>
[DataContract]
public class OrganizationsNacSessionsHistory
{
	/// <summary>
	/// RADIUS Sessions metadata
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "meta")]
	public OrganizationsNacSessionsHistoryMetadata Meta { get; set; } = new();

	/// <summary>
	/// List of RADIUS Sessions
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "items")]
	public List<OrganizationsNacSessionsHistoryItem> Items { get; set; } = [];
}

/// <summary>
/// A RADIUS Session
/// </summary>
[DataContract]
public class OrganizationsNacSessionsHistoryItem
{
	/// <summary>
	/// Details
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "details")]
	public string Details { get; set; } = string.Empty;

	/// <summary>
	/// Unique RADIUS Session Id
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "sessionId")]
	public string SessionId { get; set; } = string.Empty;

	/// <summary>
	/// Status
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "status")]
	public string Status { get; set; } = string.Empty;

	/// <summary>
	/// Timestamp of a RADIUS Session
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "ts")]
	public string Ts { get; set; } = string.Empty;

	/// <summary>
	/// Authentication details
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "authentication")]
	public OrganizationsNacSessionsHistoryItemAuthentication Authentication { get; set; } = new();

	/// <summary>
	/// Client details
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "client")]
	public OrganizationsNacSessionsHistoryItemClient Client { get; set; } = new();

	/// <summary>
	/// Counts Details
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "counts")]
	public OrganizationsNacSessionsHistoryItemCounts Counts { get; set; } = new();

	/// <summary>
	/// SSID Details
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "ssid")]
	public OrganizationsNacSessionsHistoryItemSsid Ssid { get; set; } = new();

	/// <summary>
	/// User details
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "user")]
	public OrganizationsNacSessionsHistoryItemUser User { get; set; } = new();
}
