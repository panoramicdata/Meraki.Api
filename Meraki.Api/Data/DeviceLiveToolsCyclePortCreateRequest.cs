namespace Meraki.Api.Data;

/// <summary>
/// Device Live Tools Cycle Port Create Request
/// </summary>
[DataContract]
public class DeviceLiveToolsCyclePortCreateRequest
{
	/// <summary>
	/// A list of ports to cycle. For Catalyst switches, IOS interface names are also supported, such as "GigabitEthernet1/0/8", "Gi1/0/8", or even "1/0/8".
	/// </summary>
	[DataMember(Name = "ports")]
	public List<string> Ports { get; set; } = [];

	/// <summary>
	/// Details for the callback. Please include either an httpServerId OR url and sharedSecret
	/// </summary>
	[DataMember(Name = "callback")]
	public DeviceLiveToolsCyclePortCreateRequestCallback? Callback { get; set; }
}
