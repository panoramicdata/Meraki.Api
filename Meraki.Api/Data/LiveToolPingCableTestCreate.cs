namespace Meraki.Api.Data;

/// <summary>
/// Live Tools Cable Test Create
/// </summary>
[DataContract]

public class LiveToolsCableTestCreate
{
	/// <summary>
	/// A list of ports for which to perform the cable test.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "ports")]
	public List<string> Ports { get; set; } = [];

	/// <summary>
	/// Details for the callback. Please include either an httpServerId OR url and sharedSecret
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "callback")]
	public LiveToolsCableTestCreateCallback Callback { get; set; } = new();
}
