namespace Meraki.Api.Data;

/// <summary>
/// Device Live Tools MAC Table Get Response
/// </summary>
[DataContract]
public class DeviceLiveToolsMacTableGetResponse
{
	/// <summary>
	/// An error message for a failed execution
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "error")]
	public string Error { get; set; } = string.Empty;

	/// <summary>
	/// ID of the MAC table request. Used to check the status of the request.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "macTableId")]
	public string MacTableId { get; set; } = string.Empty;

	/// <summary>
	/// Status of the MAC table request. enum = ["complete", "failed", "new", "ready", "running", ...]
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "status")]
	public string Status { get; set; } = string.Empty;

	/// <summary>
	/// GET this url to check the status of your MAC table request.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "url")]
	public string Url { get; set; } = string.Empty;

	/// <summary>
	/// MAC table request parameters
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "request")]
	public DeviceLiveToolsMacTableGetResponseRequest Request { get; set; } = new();

	/// <summary>
	/// MAC address table entries
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "entries")]
	public List<DeviceLiveToolsMacTableGetResponseEntry> Entries { get; set; } = [];
}
