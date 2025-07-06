namespace Meraki.Api.Data;

/// <summary>
/// Meta information
/// </summary>
[DataContract]
public class OrganizationSecureConnectRegionsMetadata
{
	/// <summary>
	/// Maximum number of cloud hubs that can be deployed
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "maxTotalCloudHubs")]
	public int MaxTotalCloudHubs { get; set; }
}