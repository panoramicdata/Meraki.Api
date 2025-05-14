namespace Meraki.Api.Data;

/// <summary>
/// Meta information
/// </summary>
[DataContract]
public class SecureConnectSitesMetadata
{
	/// <summary>
	/// Total count of enrolled sites
	/// </summary> 
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "total")]
	public int Total { get; set; }
}