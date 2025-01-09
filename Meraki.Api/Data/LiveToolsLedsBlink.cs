namespace Meraki.Api.Data;

/// <summary>
/// Leds Blink
/// </summary>
[DataContract]

public class LiveToolsLedsBlink
{
	/// <summary>
	/// An error message for a failed Blink LEDs execution, if present
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "error")]
	public string Error { get; set; } = string.Empty;

	/// <summary>
	/// ID of led blink job
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "ledsBlinkId")]
	public string LedsBlinkId { get; set; } = string.Empty;

	/// <summary>
	/// Status of the leds blink request
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "status")]
	public string Status { get; set; } = string.Empty;

	/// <summary>
	/// GET this url to check the status of your leds blink request
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "url")]
	public string Url { get; set; } = string.Empty;

	/// <summary>
	/// Callback
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "callback")]
	public LiveToolsLedsBlinkCallback? Callback { get; set; } = new();

	/// <summary>
	/// he parameters of the leds blink request
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "request")]
	public LiveToolsLedsBlinkRequestRequest Request { get; set; } = new();
}
