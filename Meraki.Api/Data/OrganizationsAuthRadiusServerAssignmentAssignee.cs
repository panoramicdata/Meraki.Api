namespace Meraki.Api.Data;

/// <summary>
/// Configuration where it is assigned to
/// </summary>
[DataContract]
public class OrganizationsAuthRadiusServerAssignmentAssignee
{
	/// <summary>
	/// Url of the dashboard configuration page
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "dashboardUrl")]
	public string DashboardUrl { get; set; } = string.Empty;

	/// <summary>
	/// Unique identifier of the configuration
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "id")]
	public string Id { get; set; } = string.Empty;

	/// <summary>
	/// Name of the configuration
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;

	/// <summary>
	/// Type of configuration where the server is being used. enum = ["Access policy"]
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "type")]
	public string Type { get; set; } = string.Empty;
}