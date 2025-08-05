namespace Meraki.Api.Data;

/// <summary>
/// Device Live Tools Cycle Port Get Response
/// </summary>
[DataContract]
public class DeviceLiveToolsCyclePortGetResponse
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
	public DeviceLiveToolsCyclePortGetResponseRequest Request { get; set; } = new();

	/// <summary>
	/// Status of the cycle port request. enum = ["complete", "failed", "new", "ready", "running", ...]
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "status")]
	public string Status { get; set; } = string.Empty;

	/// <summary>
	/// An error message for a failed cycle port execution, if present
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "error")]
	public string Error { get; set; } = string.Empty;
}
