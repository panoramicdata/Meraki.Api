namespace Meraki.Api.Data;

/// <summary>
/// Secure Connect Remote Access Logs Exports Response
/// </summary>
[DataContract]
public class SecureConnectRemoteAccessLogsExportsResponse
{
	/// <summary>
	/// Meta data details about result
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "meta")]
	public SecureConnectRemoteAccessLogsExportsResponseMetadata Meta { get; set; } = new();

	/// <summary>
	/// List of remote access log exports
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "data")]
	public List<SecureConnectRemoteAccessLogsExportsResponseDataItem> Data { get; set; } = [];
}
