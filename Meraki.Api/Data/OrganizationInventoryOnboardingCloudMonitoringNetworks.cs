namespace Meraki.Api.Data;

/// <summary>
/// Organization Inventory Onboarding Cloud Monitoring Networks
/// </summary>
[DataContract]
public class OrganizationInventoryOnboardingCloudMonitoringNetworks
{
	/// <summary>
	/// Enrollment string for the network
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "enrollmentString")]
	public string EnrollmentString { get; set; } = string.Empty;

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
	/// Notes for the network
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "notes")]
	public string Notes { get; set; } = string.Empty;

	/// <summary>
	/// Organization ID
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "organizationId")]
	public string OrganizationId { get; set; } = string.Empty;

	/// <summary>
	/// Timezone of the network
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "timeZone")]
	public string TimeZone { get; set; } = string.Empty;

	/// <summary>
	/// URL to the network Dashboard UI
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "url")]
	public string Url { get; set; } = string.Empty;

	/// <summary>
	/// If the network is bound to a config template
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "isBoundToConfigTemplate")]
	public bool IsBoundToConfigTemplate { get; set; }

	/// <summary>
	/// List of the product types that the network supports
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "productTypes")]
	public List<string> ProductTypes { get; set; } = [];

	/// <summary>
	/// Network tags
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "tags")]
	public List<string> Tags { get; set; } = [];
}
