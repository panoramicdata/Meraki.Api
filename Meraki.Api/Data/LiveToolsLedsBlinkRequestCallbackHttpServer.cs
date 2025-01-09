namespace Meraki.Api.Data;

/// <summary>
/// Leds Blink Request Callback Http Server
/// </summary>
[DataContract]

public class LiveToolsLedsBlinkRequestCallbackHttpServer
{
	/// <summary>
	/// The webhook receiver ID that will receive information. If specifying this, please leave the url and sharedSecret fields blank.
	/// </summary>
	[DataMember(Name = "id")]
	public string? Id { get; set; }
}
