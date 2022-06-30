namespace Meraki.Api.Data;

/// <summary>
/// Ping
/// </summary>
[DataContract]

public class LiveToolPing
{
	/// <summary>
	/// Ping id
	/// </summary>
	[DataMember(Name = "pingId")]
	public string PingId { get; set; } = string.Empty;

	/// <summary>
	/// Url
	/// </summary>
	[DataMember(Name = "url")]
	public string Url { get; set; } = string.Empty;

	/// <summary>
	/// Request
	/// </summary>
	[DataMember(Name = "request")]
	public LiveToolPingRequest Request { get; set; } = new();

	/// <summary>
	/// Status
	/// </summary>
	[DataMember(Name = "status")]
	public string Status { get; set; } = string.Empty;

	/// <summary>
	/// Results
	/// </summary>
	[DataMember(Name = "results")]
	public LiveToolPingResults Results { get; set; } = new();
}
