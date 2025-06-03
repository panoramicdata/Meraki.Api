namespace Meraki.Api.Data;

/// <summary>
/// Counts relating to the paginated networks
/// </summary>
[DataContract]
public class OrganizationIntegrationsXdrMetadataCountsItems
{
	/// <summary>
	/// The number of networks in the dataset that are available on subsequent pages 
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "remaining")]
	public int Remaining { get; set; }

	/// <summary>
	/// The total number of networks in the dataset
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "total")]
	public int Total { get; set; }
}