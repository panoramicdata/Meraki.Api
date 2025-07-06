namespace Meraki.Api.Data;

/// <summary>
/// Device Live Tools Cycle Port Create Response
/// </summary>
[DataContract]
public class DeviceLiveToolsCyclePortCreateResponse
{
	/// <summary>
	/// ID of the cycle port request
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "cyclePortId")]
	public string CyclePortId { get; set; } = string.Empty;

	/// <summary>
	/// GET this URL to check the status of your cycle port request.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "url")]
	public string Url { get; set; } = string.Empty;

	/// <summary>
	/// Cycle port request parameters
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "request")]
	public DeviceLiveToolsCyclePortCreateResponseRequest Request { get; set; } = new();

	/// <summary>
	/// Status of the cycle port request.enum = ["complete", "failed", "new", "ready", "running", ...]
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "status")]
	public string Status { get; set; } = string.Empty;

	/// <summary>
	/// Information for callback used to send back results
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "callback")]
	public DeviceLiveToolsCyclePortCreateResponseCallback Callback { get; set; } = new();
}
