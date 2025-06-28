namespace Meraki.Api.Data;

/// <summary>
/// The payload template of the webhook used for the callback
/// </summary>
[DataContract]
public class DeviceLiveToolsMacTableCreateRequestCallbackPayloadTemplate
{
	/// <summary>
	/// The ID of the payload template. Defaults to 'wpt_00005' for the Callback (included) template.
	/// </summary>
	[DataMember(Name = "id")]
	public string? Id { get; set; }
}