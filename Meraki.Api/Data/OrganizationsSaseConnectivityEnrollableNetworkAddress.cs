namespace Meraki.Api.Data;

/// <summary>
/// The address of the site
/// </summary>
[DataContract]
public class OrganizationsSaseConnectivityEnrollableNetworkAddress
{
	/// <summary>
	/// The street address of the site
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "street")]
	public string Street { get; set; } = string.Empty;
}