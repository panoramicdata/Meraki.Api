namespace Meraki.Api.Data;

/// <summary>
/// Organization Secure Connect Regions
/// </summary>
[DataContract]
public class OrganizationSecureConnectRegions
{
	/// <summary>
	/// Meta information
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "meta")]
	public OrganizationSecureConnectRegionsMetadata Meta { get; set; } = new();

	/// <summary>
	/// List of regions
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "data")]
	public List<OrganizationSecureConnectRegionsDataItem> Data { get; set; } = [];
}
