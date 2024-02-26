namespace Meraki.Api.Data;

/// <summary>
/// Live Tools Arp Table Create
/// </summary>
[DataContract]

public class LiveToolsArpTableCreate
{
	/// <summary>
	/// Details for the callback. Please include either an httpServerId OR url and sharedSecret
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "callback")]
	public LiveToolsArpTableCreateCallback Callback { get; set; } = new();
}
