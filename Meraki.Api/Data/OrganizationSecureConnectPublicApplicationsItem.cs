namespace Meraki.Api.Data;

/// <summary>
/// A Public Application
/// </summary>
[DataContract]
public class OrganizationSecureConnectPublicApplicationsItem
{
	/// <summary>
	/// App type associated with Public Application
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "appType")]
	public string AppType { get; set; } = string.Empty;

	/// <summary>
	/// Category associated with Public Application
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "category")]
	public string Category { get; set; } = string.Empty;

	/// <summary>
	/// ID for Public Applications
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "id")]
	public string Id { get; set; } = string.Empty;

	/// <summary>
	/// Time at which we last saw activity from this Public Application
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "lastDetected")]
	public string LastDetected { get; set; } = string.Empty;

	/// <summary>
	/// Name of Application. This is required.
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;

	/// <summary>
	/// Risk score associated with Public Application
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "risk")]
	public string Risk { get; set; } = string.Empty;
}