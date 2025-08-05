namespace Meraki.Api.Data;

/// <summary>
/// Device Live Tools Speed Test Get Response
/// </summary>
[DataContract]
public class DeviceLiveToolsSpeedTestGetResponse
{
	/// <summary>
	/// The Meraki device Id.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "speedTestId")]
	public string SpeedTestId { get; set; } = string.Empty;

	/// <summary>
	/// Status of the test.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "status")]
	public string Status { get; set; } = string.Empty;

	/// <summary>
	/// The url of the test.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "url")]
	public string Url { get; set; } = string.Empty;

	/// <summary>
	/// Request details.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "request")]
	public DeviceLiveToolsSpeedTestGetResponseRequest Request { get; set; } = new();

	/// <summary>
	/// Results of the test.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "results")]
	public DeviceLiveToolsSpeedTestGetResponseResults Results { get; set; } = new();
}
