namespace Meraki.Api.Data;

/// <summary>
/// CreateOrganizationActionBatchCallbackPayloadTemplate
/// </summary>
[DataContract]
public class ActionBatchCreationRequestCallbackPayloadTemplate
{
	/// <summary>
	/// The ID of the payload template. Defaults to 'wpt_00005' for the Callback (included) template.
	/// </summary>
	[DataMember(Name = "id")]
	public string? Id { get; set; }
}
