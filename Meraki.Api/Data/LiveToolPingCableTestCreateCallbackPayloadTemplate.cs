namespace Meraki.Api.Data;

/// <summary>
/// Live Tools Cable Test Create Callback Payload Template
/// </summary>
[DataContract]

public class LiveToolsCableTestCreateCallbackPayloadTemplate
{
	/// <summary>
	/// The ID of the payload template. Defaults to 'wpt_00005' for the Callback (included) template.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "id")]
	public string? Id { get; set; }
}
