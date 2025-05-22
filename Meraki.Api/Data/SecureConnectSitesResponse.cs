namespace Meraki.Api.Data;

/// <summary>
/// Secure Connect Sites Response
/// </summary>
[DataContract]
public class SecureConnectSitesResponse
{
	/// <summary>
	/// Meta information
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "meta")]
	public SecureConnectSitesMetadata Meta { get; set; } = new();

	/// <summary>
	/// List of sites
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "data")]
	public List<SecureConnectSite> Data { get; set; } = [];
}
