namespace Meraki.Api.Data;

/// <summary>
/// Organizations NAC Session Details
/// </summary>
[DataContract]
public class OrganizationsNacSessionDetails
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
	/// Timestamp of Session
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "ts")]
	public string Ts { get; set; } = string.Empty;

	/// <summary>
	/// Has complete event for given session
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "hasCompleteEvent")]
	public bool HasCompleteEvent { get; set; }

	/// <summary>
	/// Authentication details
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "authentication")]
	public OrganizationsNacSessionDetailsAuthentication Authentication { get; set; } = new();

	/// <summary>
	/// Authorization details
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "authorization")]
	public OrganizationsNacSessionDetailsAuthorization Authorization { get; set; } = new();

	/// <summary>
	/// Client details
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "client")]
	public OrganizationsNacSessionDetailsClient Client { get; set; } = new();

	/// <summary>
	/// Counts Details
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "counts")]
	public OrganizationsNacSessionDetailsCounts Counts { get; set; } = new();

	/// <summary>
	/// Device details
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "device")]
	public OrganizationsNacSessionDetailsDevice Device { get; set; } = new();

	/// <summary>
	/// Network details
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "network")]
	public OrganizationsNacSessionDetailsNetwork Network { get; set; } = new();

	/// <summary>
	/// List of RADIUS Attributes
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "radius")]
	public OrganizationsNacSessionDetailsRadius Radius { get; set; } = new();

	/// <summary>
	/// User details
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "user")]
	public OrganizationsNacSessionDetailsUser User { get; set; } = new();
}
