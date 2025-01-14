namespace Meraki.Api.Data;

/// <summary>
/// Leds Blink Request
/// </summary>
[DataContract]

public class LiveToolsLedsBlinkRequest
{
	/// <summary>
	/// The duration in seconds to blink LEDs.
	/// </summary>
	[DataMember(Name = "duration")]
	public string Duration { get; set; } = string.Empty;

	/// <summary>
	/// Details for the callback. Please include either an httpServerId OR url and sharedSecret
	/// </summary>
	[DataMember(Name = "callback")]
	public LiveToolsLedsBlinkRequestCallback? Callback { get; set; }
}
