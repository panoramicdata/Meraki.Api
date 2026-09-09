namespace Meraki.Api.Data;

/// <summary>
/// Zones
/// </summary>
[Obsolete("Camera analytics zones are keyed by zone ID, not fixed to \"0\". CameraLive.Zones is now Dictionary<string, ZoneData>. This type will be removed in a later release.")]
[DataContract]
public class Zones
{
	/// <summary>
	/// 0
	/// </summary>
	[DataMember(Name = "0")]
	public ZoneData Zone0 { get; set; } = new();
}
