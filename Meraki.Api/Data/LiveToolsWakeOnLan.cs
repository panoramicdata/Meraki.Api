namespace Meraki.Api.Data;

/// <summary>
/// Wake On Lan
/// </summary>
[DataContract]

public class LiveToolsWakeOnLan
{
	/// <summary>
	/// An error message for a failed execution
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "error")]
	public string? Error { get; set; }

	/// <summary>
	/// Status of the Wake-on-LAN request
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "status")]
	public string Status { get; set; } = string.Empty;

	/// <summary>
	/// GET this url to check the status of your ping request
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "url")]
	public string Url { get; set; } = string.Empty;

	/// <summary>
	/// ID of the Wake-on-LAN job
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "wakeOnLanId")]
	public string WakeOnLanId { get; set; } = string.Empty;

	/// <summary>
	/// Information for callback used to send back results
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "callback")]
	public LiveToolsWakeOnLanCallback? Callback { get; set; }

	/// <summary>
	/// The parameters of the Wake-on-LAN request
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "request")]
	public LiveToolsWakeOnLanRequest Request { get; set; } = new();
}
