namespace Meraki.Api.Data;

/// <summary>
/// Counts relating to the paginated dataset
/// </summary>
[DataContract]
public class OrganizationApplianceVpnSiteToSiteIpsecPeersSlasMetadataCounts
{
	/// <summary>
	/// Counts relating to the paginated items
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "items")]
	public OrganizationApplianceVpnSiteToSiteIpsecPeersSlasMetadataCountsItems Items { get; set; } = new();
}
