namespace Meraki.Api.Data;

/// <summary>
/// Counts relating to the paginated items
/// </summary>
[DataContract]
public class OrganizationApplianceVpnSiteToSiteIpsecPeersSlasMetadataCountsItems
{
	/// <summary>
	/// The number of items in the dataset available on subsequent pages
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "remaining")]
	public int Remaining { get; set; }


	/// <summary>
	/// The total number of items in the dataset
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "total")]
	public int Total { get; set; }
}