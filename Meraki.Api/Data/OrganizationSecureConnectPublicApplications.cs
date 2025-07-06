namespace Meraki.Api.Data;

/// <summary>
/// Organization Secure Connect Public Applications
/// </summary>
[DataContract]
public class OrganizationSecureConnectPublicApplications
{
	/// <summary>
	/// Meta data details about result
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "meta")]
	public OrganizationSecureConnectPublicApplicationsMetadata Meta { get; set; } = new();

	/// <summary>
	/// List of Public Applications
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "items")]
	public List<OrganizationSecureConnectPublicApplicationsItem> Items { get; set; } = [];
}
