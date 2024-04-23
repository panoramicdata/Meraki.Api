namespace Meraki.Api.Data;

/// <summary>
/// Live Tools Throughput Test Callback Payload Message Request
/// </summary>
[ApiAccessReadOnlyClass]
[DataContract]

public class LiveToolsThroughputTestCallbackPayloadMessageRequest
{
	/// <summary>
	///  Device serial number
	/// </summary>
	[DataMember(Name = "serial")]
	public string? Serial { get; set; }
}
