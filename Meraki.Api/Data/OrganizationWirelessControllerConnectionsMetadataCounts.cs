namespace Meraki.Api.Data;

/// <summary>
/// Counts relating to the paginated dataset
/// </summary>
[DataContract]
public class OrganizationWirelessControllerConnectionsMetadataCounts
{
	/// <summary>
	/// Counts relating to the paginated items
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "items")]
	public OrganizationWirelessControllerConnectionsMetadataCountsItems Items { get; set; } = new();
}
