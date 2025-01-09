namespace Meraki.Api.Data;

/// <summary>
/// Leds Blink Request Callback Payload Template
/// </summary>
[DataContract]

public class LiveToolsLedsBlinkRequestCallbackPayloadTemplate
{
	/// <summary>
	/// The ID of the payload template. Defaults to 'wpt_00005' for the Callback (included) template.
	/// </summary>
	[DataMember(Name = "id")]
	public string? Id { get; set; }
}
