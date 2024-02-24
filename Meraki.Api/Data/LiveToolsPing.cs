namespace Meraki.Api.Data;

/// <summary>
/// Ping
/// </summary>
[DataContract]

public class LiveToolsPing
{
	/// <summary>
	/// Ping id
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "pingId")]
	public string PingId { get; set; } = string.Empty;

	/// <summary>
	/// Url
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "url")]
	public string Url { get; set; } = string.Empty;

	/// <summary>
	/// Request
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "request")]
	public LiveToolsPingRequest Request { get; set; } = new();

	/// <summary>
	/// Status
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "status")]
	public string Status { get; set; } = string.Empty;

	/// <summary>
	/// Results
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "results")]
	public LiveToolsPingResults Results { get; set; } = new();

	/// <summary>
	/// Callback
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "callback")]
	public LiveToolsPingCallback Callback { get; set; } = new();
}
