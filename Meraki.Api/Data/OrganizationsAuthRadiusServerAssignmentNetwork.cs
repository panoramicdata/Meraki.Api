namespace Meraki.Api.Data;

/// <summary>
/// Network where this server is assigned to
/// </summary>
[DataContract]
public class OrganizationsAuthRadiusServerAssignmentNetwork
{
	/// <summary>
	/// Url for dashboard network page
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "dashboardUrl")]
	public string DashboardUrl { get; set; } = string.Empty;

	/// <summary>
	/// Encrypted network ID
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "eid")]
	public string Eid { get; set; } = string.Empty;

	/// <summary>
	/// Network ID
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "id")]
	public string Id { get; set; } = string.Empty;

	/// <summary>
	/// Network name
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;

	/// <summary>
	/// Tag for network. This is used to build URL for dashboard page
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "tag")]
	public string Tag { get; set; } = string.Empty;
}