namespace Meraki.Api.Data;

/// <summary>
/// Camera live
/// </summary>
[DataContract]
public class CameraLive
{
	/// <summary>
	/// Ts
	/// </summary>
	[DataMember(Name = "ts")]
	public string Ts { get; set; } = string.Empty;

	/// <summary>
	/// The zones state, keyed by zone ID
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "zones")]
	public Dictionary<string, ZoneData> Zones { get; set; } = [];
}
