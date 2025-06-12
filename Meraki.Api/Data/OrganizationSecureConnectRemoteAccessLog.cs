namespace Meraki.Api.Data;

/// <summary>
/// Organization Secure Connect Remote Access Log
/// </summary>
[DataContract]
public class OrganizationSecureConnectRemoteAccessLog
{
	/// <summary>
	/// Meta data details about result
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "meta")]
	public OrganizationSecureConnectRemoteAccessLogMetadata Meta { get; set; } = new();

	/// <summary>
	/// List the events logged by remote access.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "data")]
	public List<OrganizationSecureConnectRemoteAccessLogDataItem> Data { get; set; } = [];
}
