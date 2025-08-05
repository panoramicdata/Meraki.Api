namespace Meraki.Api.Data;

/// <summary>
/// Meta data details about result
/// </summary>
[DataContract]
public class OrganizationSecureConnectRemoteAccessLogMetadata
{
	/// <summary>
	/// Total count of remote access logs
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "total")]
	public int Total { get; set; }
}