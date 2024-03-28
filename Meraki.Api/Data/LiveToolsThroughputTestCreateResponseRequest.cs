namespace Meraki.Api.Data;

/// <summary>
/// Live Tools Throughput Test Create Response Request
/// </summary>
[DataContract]

public class LiveToolsThroughputTestCreateResponseRequest
{
	/// <summary>
	/// Device serial number
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "serial")]
	public string Serial { get; set; } = string.Empty;
}
