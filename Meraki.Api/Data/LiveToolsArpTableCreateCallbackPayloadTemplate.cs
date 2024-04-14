namespace Meraki.Api.Data;

/// <summary>
/// Live Tools Arp Table Create Callback PayloadTemplate
/// </summary>
[DataContract]

public class LiveToolsArpTableCreateCallbackPayloadTemplate
{
	/// <summary>
	/// The ID of the payload template. Defaults to 'wpt_00005' for the Callback (included) template.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "id")]
	public string? Id { get; set; }
}
