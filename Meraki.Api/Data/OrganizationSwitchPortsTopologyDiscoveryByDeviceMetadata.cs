namespace Meraki.Api.Data;

/// <summary>
/// Metadata relevant to the paginated dataset
/// </summary>
[DataContract]
public class OrganizationSwitchPortsTopologyDiscoveryByDeviceMetadata
{
	/// <summary>
	/// Counts relating to the paginated dataset
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "counts")]
	public OrganizationSwitchPortsTopologyDiscoveryByDeviceMetadataCounts Counts { get; set; } = new();
}
