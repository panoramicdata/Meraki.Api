namespace Meraki.Api.Data;

/// <summary>
/// Live Tools Throughput Test Request
/// </summary>
[DataContract]

public class LiveToolsThroughputTestRequest
{
	/// <summary>
	/// Device serial number
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "serial")]
	public string Serial { get; set; } = string.Empty;
}
