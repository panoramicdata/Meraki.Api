namespace Meraki.Api.Data;

/// <summary>
/// Leds Blink Request
/// </summary>
[DataContract]

public class LiveToolsLedsBlinkRequestRequest
{
	/// <summary>
	/// The duration to blink leds in seconds
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "duration")]
	public int Duration { get; set; }

	/// <summary>
	/// Device serial number
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "serial")]
	public string Serial { get; set; } = string.Empty;
}
