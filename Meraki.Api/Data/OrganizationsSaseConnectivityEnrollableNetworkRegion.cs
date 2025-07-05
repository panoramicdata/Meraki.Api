namespace Meraki.Api.Data;

/// <summary>
/// The region to which the site is connected
/// </summary>
[DataContract]
public class OrganizationsSaseConnectivityEnrollableNetworkRegion
{
	/// <summary>
	/// The name of the region
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;
}