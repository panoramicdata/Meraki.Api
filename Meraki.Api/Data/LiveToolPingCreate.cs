namespace Meraki.Api.Data;

/// <summary>
/// Ping create request
/// </summary>
[DataContract]
public class LiveToolPingCreate
{
	/// <summary>
	/// Count
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "count")]
	public int Count { get; set; }

	/// <summary>
	/// Target
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "target")]
	public string Target { get; set; } = string.Empty;

	/// <summary>
	/// Details for the callback. Please include either an httpServerId OR url and sharedSecret
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "callback")]
	public LiveToolPingCreateCallback? Callback { get; set; } = new();
}
