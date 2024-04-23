namespace Meraki.Api.Data;

/// <summary>
/// Live Tools Throughput Test Create Request
/// </summary>
[DataContract]

public class LiveToolsThroughputTestCreateRequest
{
	/// <summary>
	/// Details for the callback. Please include either an httpServerId OR url and sharedSecret
	/// </summary>
	[ApiAccess(ApiAccess.Create)]
	[DataMember(Name = "callback")]
	public LiveToolsThroughputTestCreateRequestCallback Callback { get; set; } = new();

}
