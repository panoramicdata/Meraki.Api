namespace Meraki.Api.Data;

/// <summary>
/// Live Tools Throughput Test Create Request Callback Http Server
/// </summary>
[DataContract]

public class LiveToolsThroughputTestCreateRequestCallbackHttpServer
{
	/// <summary>
	/// The webhook receiver ID that will receive information. If specifying this, please leave the url and sharedSecret fields blank.
	/// </summary>
	[ApiAccess(ApiAccess.Create)]
	[DataMember(Name = "id")]
	public string? Id { get; set; }
}
