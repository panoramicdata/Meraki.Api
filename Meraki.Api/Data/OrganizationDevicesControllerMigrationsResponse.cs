namespace Meraki.Api.Data;

/// <summary>
/// Organization Devices Controller Migrations Response
/// </summary>
[DataContract]
public class OrganizationDevicesControllerMigrationsResponse
{
	/// <summary>
	/// Metadata relevant to the paginated dataset
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "meta")]
	public OrganizationDevicesControllerMigrationsMetadata Meta { get; set; } = new();

	/// <summary>
	/// List of migrations for the specified devices
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "items")]
	public List<OrganizationsDevicesControllerMigration> Items { get; set; } = [];
}
