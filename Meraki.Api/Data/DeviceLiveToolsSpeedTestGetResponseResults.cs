namespace Meraki.Api.Data;

/// <summary>
/// Results of the test.
/// </summary>
[DataContract]
public class DeviceLiveToolsSpeedTestGetResponseResults
{
	/// <summary>
	/// Speeds.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "speeds")]
	public DeviceLiveToolsSpeedTestGetResponseResultsSpeeds Speeds { get; set; } = new();
}
