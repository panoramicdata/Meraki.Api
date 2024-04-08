namespace Meraki.Api.Data;

/// <summary>
/// Live Tools Throughput Test Callback Payload Message Request
/// </summary>
[DataContract]

public class LiveToolsThroughputTestCallbackMessageRequest
{
	/// <summary>
	///  Device serial number
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "serial")]
	public string? Serial { get; set; }
}
