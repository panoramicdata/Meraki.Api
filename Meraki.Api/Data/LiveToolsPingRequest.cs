namespace Meraki.Api.Data;
/// <summary>
/// Ping request
/// </summary>
[DataContract]
public class LiveToolsPingRequest
{
	/// <summary>
	/// Serial
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "serial")]
	public string Serial { get; set; } = string.Empty;

	/// <summary>
	/// Target
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "target")]
	public string Target { get; set; } = string.Empty;

	/// <summary>
	/// Count
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "count")]
	public int Count { get; set; }
}
