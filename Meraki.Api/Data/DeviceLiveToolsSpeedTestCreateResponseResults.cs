namespace Meraki.Api.Data;

/// <summary>
/// Results of the test.
/// </summary>
[DataContract]
public class DeviceLiveToolsSpeedTestCreateResponseResults
{
	/// <summary>
	/// Speeds.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "speeds")]
	public DeviceLiveToolsSpeedTestCreateResponseResultsSpeeds Speeds { get; set; } = new();
}