namespace Meraki.Api.Data;

/// <summary>
/// List of remote access log exports
/// </summary>
[DataContract]
public class SecureConnectRemoteAccessLogsExportsResponseDataItem
{
	/// <summary>
	/// Export logs from timestamp
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "from")]
	public string From { get; set; } = string.Empty;

	/// <summary>
	/// Export ID
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "id")]
	public string Id { get; set; } = string.Empty;

	/// <summary>
	/// Export status
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "status")]
	public string Status { get; set; } = string.Empty;

	/// <summary>
	/// Export logs to timestamp
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "to")]
	public string To { get; set; } = string.Empty;

	/// <summary>
	/// Export user email
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "userEmail")]
	public string UserEmail { get; set; } = string.Empty;

	/// <summary>
	/// Export metadata
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "metadata")]
	public SecureConnectRemoteAccessLogsExportsResponseDataItemMetadata Metadata { get; set; } = new();
}
