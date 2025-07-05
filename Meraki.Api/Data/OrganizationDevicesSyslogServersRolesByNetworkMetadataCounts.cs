namespace Meraki.Api.Data;

/// <summary>
/// Counts relating to the paginated dataset
/// </summary>
[DataContract]
public class OrganizationDevicesSyslogServersRolesByNetworkMetadataCounts
{
	/// <summary>
	/// Counts related to the paginated items
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "items")]
	public OrganizationDevicesSyslogServersRolesByNetworkMetadataCountsItems Items { get; set; } = new();
}
