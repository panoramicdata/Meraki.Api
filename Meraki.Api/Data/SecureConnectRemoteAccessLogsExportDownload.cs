namespace Meraki.Api.Data;

/// <summary>
/// Secure Connect Remote Access Logs Export Download
/// </summary>
[DataContract]
public class SecureConnectRemoteAccessLogsExportDownload
{
	/// <summary>
	/// Export download link
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "link")]
	public string Link { get; set; } = string.Empty;
}
