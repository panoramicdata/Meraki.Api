namespace Meraki.Api.Data;

/// <summary>
/// Speeds.
/// </summary>
[DataContract]
public class DeviceLiveToolsSpeedTestCreateResponseResultsSpeeds
{
	/// <summary>
	/// Average speed.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "average")]
	public int Average { get; set; }
}