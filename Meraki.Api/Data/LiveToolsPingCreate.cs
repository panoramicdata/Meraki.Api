namespace Meraki.Api.Data;

/// <summary>
/// Ping create request
/// </summary>
[DataContract]
public class LiveToolsPingCreate
{
	/// <summary>
	/// Count
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "count")]
	public int Count { get; set; }

	/// <summary>
	/// Target
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "target")]
	public string Target { get; set; } = string.Empty;

	/// <summary>
	/// Details for the callback. Please include either an httpServerId OR url and sharedSecret
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "callback")]
	public LiveToolsPingCreateCallback? Callback { get; set; } = new();
}
