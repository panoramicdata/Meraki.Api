namespace Meraki.Api.Data;

/// <summary>
/// Live Tools Throughput Test Create Request Callback Payload Template
/// </summary>
[DataContract]

public class LiveToolsThroughputTestCreateRequestCallbackPayloadTemplate
{
	/// <summary>
	/// The ID of the payload template. Defaults to 'wpt_00005' for the Callback (included) template.
	/// </summary>
	[ApiAccess(ApiAccess.Create)]
	[DataMember(Name = "id")]
	public string? Id { get; set; }
}
