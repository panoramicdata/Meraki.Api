namespace Meraki.Api.Data;

/// <summary>
/// Secure Connect Remote Access Logs Exports Create Request
/// </summary>
[DataContract]
public class SecureConnectRemoteAccessLogsExportsCreateRequest
{
	/// <summary>
	/// The start of the interval, must be within the past 30 days.
	/// </summary>
	[DataMember(Name = "from")]
	public int From { get; set; }

	/// <summary>
	/// The end of the interval, must not exceed the current date.
	/// </summary>
	[DataMember(Name = "to")]
	public int To { get; set; }
}
