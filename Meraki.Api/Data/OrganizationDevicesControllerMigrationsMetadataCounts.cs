namespace Meraki.Api.Data;

/// <summary>
/// Counts relating to the paginated dataset
/// </summary>
[DataContract]
public class OrganizationDevicesControllerMigrationsMetadataCounts
{
	/// <summary>
	/// Counts relating to the paginated items
	/// </summary> 
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "items")]
	public OrganizationDevicesControllerMigrationsMetadataCountsItems Items { get; set; } = new();
}
