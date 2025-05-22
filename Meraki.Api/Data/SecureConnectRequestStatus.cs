namespace Meraki.Api.Data;

/// <summary>
/// SecureConnectRequestStatus
/// </summary>
[DataContract]
public class SecureConnectRequestStatus
{
	/// <summary>
	/// The HTTP status code of the response.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "code")]
	public int Code { get; set; }

	/// <summary>
	/// The HTTP message that describes the response.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "text")]
	public string Text { get; set; } = string.Empty;
}
