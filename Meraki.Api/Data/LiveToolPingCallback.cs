namespace Meraki.Api.Data;

/// <summary>
/// Callback Status
/// </summary>
[DataContract]

public class LiveToolPingCallback
{
	/// <summary>
	/// id
	/// </summary>
	[DataMember(Name = "id")]
	public string Id { get; set; } = string.Empty;

	/// <summary>
	/// url
	/// </summary>
	[DataMember(Name = "url")]
	public string Url { get; set; } = string.Empty;

	/// <summary>
	/// status
	/// </summary>
	[DataMember(Name = "status")]
	public string Status { get; set; } = string.Empty;
}
